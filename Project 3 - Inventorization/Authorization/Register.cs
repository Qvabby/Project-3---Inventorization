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
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=Inventory_Db;Integrated Security=True");
        public Register()
        {
            InitializeComponent();
        }

        private void UsernameTaken()
        {
            UsernameTakenL.Visible = true;
            UsernameTb.BackColor = Color.Red;
        }
        private void TbChange(TextBox tb)
        {
            tb.BackColor = Color.White;
        }
        private void RegisterSuccess()
        {
            MessageBox.Show("Registration Completed Successfully", "Success");
            ClearTbs();
            MainPage p = new MainPage();
            MainForm.PanelLoad(p, MainForm.mp);
        }

        private void ClearTbs()
        {
            List<TextBox> Tbs = new List<TextBox>() { NameTb, LastNameTb, UsernameTb, PassowrdTb, NumberTb };
            foreach (var tb in Tbs)
            {
                tb.Clear();
                tb.BackColor = Color.White;
                UsernameTakenL.Visible = false;
            }
        }

        private bool CheckValid(List<TextBox> Tbs)
        {
            foreach (var tb in Tbs)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.BackColor = Color.Red;
                    return false;   
                }
            }
            return true;
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            List<TextBox> Tbs = new List<TextBox>() { NameTb, LastNameTb, UsernameTb, PassowrdTb };
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM User_Tb",con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            bool can = true;
            foreach (DataRow row in dt.Rows)
            {
                if (row[3].ToString() == UsernameTb.Text)
                {
                    can = false;
                    UsernameTaken();
                }
            }
            if (can)
            {
                can = CheckValid(Tbs);
            }    
            if (can)
            {
                SqlCommand cmd2 = new SqlCommand($"INSERT INTO User_Tb (Name, LastName, Username, Password, Number, Balance) VALUES ('{NameTb.Text}','{LastNameTb.Text}','{UsernameTb.Text}','{PassowrdTb.Text}','{NumberTb.Text}', 100000)",con);
                cmd2.ExecuteNonQuery();
                RegisterSuccess();
            }

            con.Close();
        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {
            TbChange(NameTb);
        }

        private void LastNameTb_TextChanged(object sender, EventArgs e)
        {
            TbChange(LastNameTb);
        }

        private void UsernameTb_TextChanged(object sender, EventArgs e)
        {
            TbChange(UsernameTb);
        }

        private void PassowrdTb_TextChanged(object sender, EventArgs e)
        {
            TbChange(PassowrdTb);
        }

        private void NumberTb_TextChanged(object sender, EventArgs e)
        {
            TbChange(NumberTb);
        }
    }
}
