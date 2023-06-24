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
    public partial class Add : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=Inventory_Db;Integrated Security=True");
        DateTime d;
        public Add()
        {
            InitializeComponent();
        }
        private void AddBtn_Click(object sender, EventArgs e)
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
            if (can)
            {
                AddToDB();
                MainPage p = new MainPage();
                MainForm.PanelLoad(p, MainForm.mp);
            }
        }
        private void AddToDB()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand($"INSERT INTO Products_Tb (Title, Price, Description, SellerId, UploadDate, ExpriedDate) " +
                $"VALUES ('{TitleTb.Text}', {Convert.ToDecimal(PriceNUAD.Value)}, '{DescriptionTb.Text}', '{MainForm.UserId}', '{DateTime.Now}', '{ExpiredDate.Value}')",con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Added Successfully", "Success.");
            con.Close();
        }
        private void TitleTb_TextChanged(object sender, EventArgs e)
        {
            TitleTb.BackColor = Color.White;
        }
        private void PriceNUAD_ValueChanged(object sender, EventArgs e)
        {
            PriceNUAD.BackColor = Color.White;
        }
        private void Add_Load(object sender, EventArgs e)
        {
            ExpiredDate.MinDate = DateTime.Now;
            d = ExpiredDate.Value;
        }
    }
}
