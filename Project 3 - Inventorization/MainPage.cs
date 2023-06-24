using Project_3___Inventorization.Functionality;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3___Inventorization
{
    public partial class MainPage : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=Inventory_Db;Integrated Security=True");
        public MainPage()
        {
            InitializeComponent();
        }
        private void ShowInventory()
        {
            if (MainForm.LogedIn)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Order_Tb",con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataTable inv = new DataTable();
                inv = dt;
                List<DataRow> rows = new List<DataRow>();
                foreach (DataRow row in dt.Rows)
                {
                    if (row[3].ToString() != MainForm.UserId)
                    {
                        //inv.Rows.Add(dr);
                        rows.Add(row);
                    }
                }

                foreach (var item in rows.ToList())
                {
                    inv.Rows.Remove(item);
                }

                InvDGV.DataSource = inv;

                con.Close();
            }
        }
        private void ShowProducts()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products_Tb", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Order_Tb", con);
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            DataGridView Datasorc = new DataGridView();
            Datasorc.Columns.Add("Id", "Id");
            Datasorc.Columns.Add("Title", "Title");
            Datasorc.Columns.Add("Price", "Price");
            Datasorc.Columns.Add("Description", "Description");
            Datasorc.Columns.Add("SellerId", "SellerId");
            Datasorc.Columns.Add("UploadDate", "IUploadDated");
            Datasorc.Columns.Add("ExpiredDate", "ExpiredDate");
            foreach (DataRow row1 in dt.Rows)
            { 
                foreach (DataRow row2 in dt2.Rows)
                {
                    if (row1[0].ToString() != row2[1].ToString())
                    {
                        Datasorc.Rows.Add(row1);
                    }
                }
                
            }
            ProductsDGV.DataSource = Datasorc;
            //for (int i = 0; i < Datasorc.Count; i++)
            //{
            //    ProductsDGV.Rows.AddRange(Datasorc);
            //    //ProductsDGV.Rows[i].Cells[0].Value = Datasorc[i][0];
            //    //ProductsDGV.Rows[i].Cells[1].Value = Datasorc[i][1];
            //    //ProductsDGV.Rows[i].Cells[2].Value = Datasorc[i][2];
            //    //ProductsDGV.Rows[i].Cells[3].Value = Datasorc[i][3];
            //    //ProductsDGV.Rows[i].Cells[4].Value = Datasorc[i][4];
            //    //ProductsDGV.Rows[i].Cells[5].Value = Datasorc[i][5];
            //    //ProductsDGV.Rows[i].Cells[6].Value = Datasorc[i][6];
            //}

            //DataTable realdt = new DataTable();
            //foreach (DataColumn dc in dt.Columns)
            //{
            //    realdt.Columns.Add(dc);
            //}
            //realdt.Rows.Add(Datasorc);

            //foreach (DataRow item in realdt.Rows)
            //{
            //    decimal price = Convert.ToDecimal(item[2].ToString());
            //    price += Convert.ToDecimal(2);
            //    item[2] = price;
            //}
            //ProductsDGV.DataSource = realdt;


            con.Close();
        }
        private void ShowLimitedProducts()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products_Tb", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataTable fdt = new DataTable();
            adapter.Fill(fdt);
            foreach (DataRow r in dt.Rows)
            {
                if ((Convert.ToDateTime(r[6].ToString()) - DateTime.Now).Days > 3 )
                {
                    foreach (DataRow r2 in fdt.Rows)
                    {
                        if (r2[8].ToString() == r[6].ToString())
                        {
                            fdt.Rows.Remove(r2);
                            break;
                        }
                    }
                    
                }
            }
            foreach (DataRow item in fdt.Rows)
            {
                decimal price = Convert.ToDecimal(item[2].ToString());
                price += Convert.ToDecimal(2);
                item[2] = price;
            }
            ProductsDGV.DataSource = fdt;

            con.Close();
        }
        public void RefrestDGVs()
        {
            ShowProducts();
            ShowInventory();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            RefrestDGVs();
            List<Control> cs = new List<Control>() { InvL, InvDGV, AddBtn, RemoveBtn, UpdateBtn, FunctionsPanel, BuyBtn};
            if (MainForm.LogedIn)
            {
                MainForm.LB.Text = "Log Out";
                MainForm.RB.Visible = false;
                foreach (var c in cs)
                {
                    c.Visible = true;
                }
            }
            else
            {
                MainForm.LB.Text = "Log In";
                MainForm.RB.Visible = true;
                foreach (var c in cs)
                {
                    c.Visible = false;
                }
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Add f = new Add();
            f.BackColor = FunctionsPanel.BackColor;
            MainForm.PanelLoad(f, FunctionsPanel);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            Remove f = new Remove();
            f.BackColor = FunctionsPanel.BackColor;
            MainForm.PanelLoad(f, FunctionsPanel);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Update f = new Update();
            f.BackColor = FunctionsPanel.BackColor;
            MainForm.PanelLoad(f, FunctionsPanel);
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            Buy f = new Buy();
            f.BackColor = FunctionsPanel.BackColor;
            MainForm.PanelLoad(f, FunctionsPanel);
        }

        private void ShowProductsBtn_Click(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void ShowLimitedBtn_Click(object sender, EventArgs e)
        {
            ShowLimitedProducts();
        }

    }
}
