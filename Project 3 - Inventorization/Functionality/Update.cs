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
    
    public partial class Update : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=Inventory_Db;Integrated Security=True");
        DateTime d;
        public Update()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            bool can = true;

            if (string.IsNullOrWhiteSpace(TitleTb.Text))
            {
                MessageBox.Show("You Didn't Fill The Title Text Box", "Input Error");
                TitleTb.BackColor = Color.Red;
                can = false;
            }
            else if (PriceNUAD.Value == 0)
            {
                MessageBox.Show("You Didn't Fill The Price", "Input Error");
                PriceNUAD.BackColor = Color.Red;
                can = false;
            }
            else if (ExpiredDate.Value == d)
            {
                MessageBox.Show("You Didn't Input The Expiring Date", "Input Error");
                can = false;
            }
            else if (IdNUAD.Value == 0)
            {
                MessageBox.Show("You Didn't Input The id", "Input Error");
                can = false;
            }
            if (can)
            {
                UpdateDB();
                MainPage p = new MainPage();
                MainForm.PanelLoad(p, MainForm.mp);
            }
        }

        private void UpdateDB()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand($"UPDATE Products_Tb SET Title = '{TitleTb.Text}', Price = {Convert.ToDecimal(PriceNUAD.Value)}, Description = '{DescriptionTb.Text}', UploadDate = '{DateTime.Now}', ExpriedDate = '{ExpiredDate.Value}' " +
                $"WHERE id = {IdNUAD.Value}", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Updated Successfully", "Success.");
            con.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            ExpiredDate.MinDate = DateTime.Now;
            d = ExpiredDate.Value;
        }
    }
}
