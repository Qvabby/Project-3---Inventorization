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

namespace Project_3___Inventorization.Authorization
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=Inventory_Db;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * from User_Tb",con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                if (row[3].ToString() == UsernameTb.Text && PassowrdTb.Text == row[4].ToString() )
                {
                    LoginSuccess(row[0].ToString());
                }
            }
            if (!MainForm.LogedIn)
            {
                LoginNotSuccess();
            }


            con.Close();
        }

        private void LoginNotSuccess()
        {
            if (string.IsNullOrWhiteSpace(UsernameTb.Text))
            {
                MessageBox.Show("Username Text Box is not filled", "Error");
            }
            else if(string.IsNullOrWhiteSpace(PassowrdTb.Text))
            {
                MessageBox.Show("Password Text Box is Not Filled", "Error");
            }
            else
            {
                MessageBox.Show("Something went wrong","Unknown error");
            }
        }

        private void LoginSuccess(string id)
        {
            MainForm.UserId = id;
            MainForm.LogedIn = true;
            MainPage mp = new MainPage();
            MainForm.PanelLoad(mp, MainForm.mp);
        }
    }
}
