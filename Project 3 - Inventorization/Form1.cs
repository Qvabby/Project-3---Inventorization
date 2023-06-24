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
using Project_3___Inventorization.Authorization;

namespace Project_3___Inventorization
{
    public partial class MainForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PS7OKKF;Initial Catalog=Inventory_Db;Integrated Security=True");
        public static bool LogedIn { get; set; }
        public static string UserId { get; set; }
        public static Panel mp { get; set; }
        public static Button LB;
        public static Button RB;
        public MainForm()
        {
            InitializeComponent();
        }
        public static void PanelLoad(Form f, Panel p)
        {
            if (p.Controls.Count > 0)
            {
                p.Controls.RemoveAt(0);
            }
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.BackColor = mp.BackColor;
            p.Controls.Add(f);
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LB = LoginBtn;
            RB = RegisterBtn;
            mp = MainPanel;
            MainPage p = new MainPage();
            PanelLoad(p, MainPanel);
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Register R = new Register();
            PanelLoad(R, MainPanel);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (LogedIn)
            {
                LogOut();
                MainPage p = new MainPage();
                PanelLoad(p, MainPanel);
            }
            else
            {
                Login L = new Login();
                PanelLoad(L, MainPanel);
            }  
        }
        private void LogOut()
        {
            LogedIn = false;
            UserId = null;
            LB.Text = "Log In";
            RB.Visible = true;
        }
    }
}
