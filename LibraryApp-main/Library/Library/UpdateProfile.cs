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
    public partial class UpdateProfile : Form
    {
        private object sqlconnection;
        private object sqlcommand;

        public UpdateProfile()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profile f1 = new Profile();
            f1.ShowDialog();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (passwordInput.Text == confirmPasswordInput.Text) { 

            SqlConnection sqlconnection = new SqlConnection("Data Source=MARWA;Initial Catalog=Library;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            string query = "";
            if (signInPage.s == "Reader")
            {
                query = "Update Reader set fname ='" + firstNameInput.Text + "', lname ='" + lastNameInput.Text + "', phone = '" + phoneInput.Text + "', UserPassword = '" + passwordInput.Text + "' where username= '" + signInPage.user + "' ";
            }
            else if (signInPage.s == "Admin")
            {
                query = "Update Admin set fname ='" + firstNameInput.Text + "', lname ='" + lastNameInput.Text + "', phone = '" + phoneInput.Text + "', UserPassword = '" + passwordInput.Text + "' where username= '" + signInPage.user + "' ";
            }
            else if (signInPage.s == "Auther")
            {
                query = "Update Auther set fname ='" + firstNameInput.Text + "', lname ='" + lastNameInput.Text + "', phone = '" + phoneInput.Text + "', UserPassword = '" + passwordInput.Text + "' where username= '" + signInPage.user + "' ";
            }
            sqlcommand.CommandType = CommandType.Text;
            sqlcommand.CommandText = query;
            sqlcommand.Connection = sqlconnection;
            SqlDataReader sdr = sqlcommand.ExecuteReader();
            sdr.Read();
            sqlconnection.Close();
             }
            else{
                MessageBox.Show("Password doesn't Match.");
                } 

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

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
