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

namespace Library
{
    public partial class signInPage : Form
    {
        public static string s = "";
        public static string user = "";
        public static string pass = "";
        public signInPage()
        {
            InitializeComponent();
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void signInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            singUpPage f1 = new singUpPage();
            f1.ShowDialog();
            
        }

        private void signInPage_Load(object sender, EventArgs e)
        {

        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=MARWA;Initial Catalog=Library;Integrated Security=True");

            try
            {
                s = comboBox1.Text;
                string querry = "";
                if (s == "Reader") querry = "select * from reader where username = '" + usernameInput.Text + "' and UserPassword ='" + passwordInput.Text + "'";
                if (s == "Auther") querry = "select * from Auther where username = '" + usernameInput.Text + "' and UserPassword ='" + passwordInput.Text + "'";
                if (s == "Admin") querry = "select * from Admin where username = '" + usernameInput.Text + "' and UserPassword ='" + passwordInput.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    user = usernameInput.Text;
                    pass = passwordInput.Text;

                    if (signInPage.s == "Reader")
                    {
                        this.Visible = false;
                        Reader f1 = new Reader();
                        f1.ShowDialog();
                    }
                    else if (signInPage.s == "Auther")
                    {
                        this.Visible = false;
                        Auther f1 = new Auther();
                        f1.ShowDialog();
                    }
                    else if (signInPage.s == "Admin")
                    {
                        this.Visible = false;
                        Admin f1 = new Admin();
                        f1.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or password.");
                    usernameInput.Clear();
                    passwordInput.Clear();
                }
            }
            finally
            {
                conn.Close();
            }



        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
