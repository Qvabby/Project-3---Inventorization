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
    public partial class Buy : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=Inventory_Db;Integrated Security=True");

        public Buy()
        {
            InitializeComponent();
        }

        private void BuyBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            bool can = true;
            if (IdNUAD.Value == 0)
            {
                can = false;
            }
            if (can)
            {
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Products_Tb where id = {IdNUAD.Value}", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                SqlCommand cmd2 = new SqlCommand($"SELECT * FROM User_Tb Where id = {MainForm.UserId}", con);
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);


                if (Convert.ToDecimal(dt2.Rows[0][6]) >= (Convert.ToDecimal(dt.Rows[0][2]) + 2))
                {
                    SqlCommand UpUser = new SqlCommand($"Update User_Tb Set Balance = {Convert.ToDecimal(dt2.Rows[0][6]) - (Convert.ToDecimal(dt.Rows[0][2]) + 2)} WHERE id = {MainForm.UserId}",con);
                    UpUser.ExecuteNonQuery();
                    SqlCommand UpOrder = new SqlCommand($"Insert Into Order_Tb (ProductId ,SellerId, OwnerId, OrderDate, OrderPrice) values" +
                        $"({dt.Rows[0][0]}, {dt.Rows[0][4]}, {MainForm.UserId}, '{DateTime.Now}', {Convert.ToDecimal(dt.Rows[0][2]) + 2})", con);
                    UpOrder.ExecuteNonQuery();
                    SqlCommand UpSell = new SqlCommand($"Update User_Tb Set Balance += {Convert.ToDecimal(dt.Rows[0][2])} WHERE id = {dt.Rows[0][4]}", con);
                    UpSell.ExecuteNonQuery();
                    MessageBox.Show("You Bought Item","Success");
                    MainPage p = new MainPage();
                    MainForm.PanelLoad(p, MainForm.mp);
                }
                else
                {
                    MessageBox.Show("Not enough balance","Balance Error");
                }
            }
            
            con.Close();
        }
    }
}
