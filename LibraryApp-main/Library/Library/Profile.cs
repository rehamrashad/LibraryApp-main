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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            label1.Text = signInPage.user;
         
            if (signInPage.s != "Reader")
            {
                label4.Visible=false;
                label5.Visible=false;
            }
            else
            {
                SqlConnection sqlconnection = new SqlConnection("Data Source = MARWA; Initial Catalog=Library; Integrated Security = True");
                sqlconnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(username) FROM buy WHERE username = '" + signInPage.user + "'";
                cmd.Connection = sqlconnection;

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int xx= dr.GetInt32(0);
                label5.Text = xx.ToString();
                sqlconnection.Close();
               
                //string query = "SELECT COUNT(username) FROM buy WHERE username = '" + signInPage.user + "'";



            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateProfile f1 = new UpdateProfile();
            f1.ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //for now to reader
            this.Visible = false;
            Reader f1 = new Reader();
            f1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
