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

namespace Project_3___Inventorization.Functionality
{
    public partial class Remove : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=Inventory_Db;Integrated Security=True");
        public Remove()
        {
            InitializeComponent();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            bool can = true;
            if (IdNUAD.Value == 0)
            {
                can = false;
                MessageBox.Show("You forgot to Input Id", "Input Error");
            }

            if (can)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM Products_Tb", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                SqlCommand cmd = new SqlCommand($"DELETE from Products_Tb where id = {IdNUAD.Value} and SellerId = {MainForm.UserId}",con);
                cmd.ExecuteNonQuery();

                bool show = true;
                foreach (DataRow row in dt.Rows )
                {
                    if (row[0].ToString() == IdNUAD.Value.ToString())
                    {
                        if (row[4].ToString() != MainForm.UserId)
                        {
                            MessageBox.Show("You are not the seller", "User Error");
                            show = false;
                        }
                    }
                }
                if (show)
                {
                    MessageBox.Show("Successfully deleted.","Success");
                    IdNUAD.Value = 0;
                    MainPage p = new MainPage();
                    MainForm.PanelLoad(p, MainForm.mp);
                }
                con.Close();
            }
        }
    }
}
