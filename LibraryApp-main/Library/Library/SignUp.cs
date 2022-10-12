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
    public partial class singUpPage : Form
    {
        private object userNameInput;

        public singUpPage()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void singUpPage_Load(object sender, EventArgs e)
        {

        }

        private void signInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            signInPage f1 = new signInPage();
            f1.ShowDialog();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source = MARWA; Initial Catalog=Library; Integrated Security = True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            sqlconnection.Open();
            string query = "";
            if (passwordInput.Text != confirmPasswordInput.Text) MessageBox.Show("Password Doesn't Match");
            else { if (typeBox.Text == "Reader")
            {
                query = "Insert into Reader Values('" + phoneInput.Text + "','" + firstNameInput.Text + "','" + lastNameInput.Text + "','" + passwordInput.Text + "','" + usernameInput.Text + "','" + typeBox.Text + "') ";

            }
            else if (typeBox.Text == "Admin")
            {
                query = " insert into Admin values(' " + phoneInput.Text + " ','" + firstNameInput.Text + " ','" + lastNameInput.Text + " ','" + passwordInput.Text + " ','" + usernameInput.Text + " ','" + typeBox.Text + "') ";
            }
            else if (typeBox.Text == "Auther")
            {
                query = " insert into Auther values(' " + phoneInput.Text + " ','" + firstNameInput.Text + " ','" + passwordInput.Text + " ','" + lastNameInput.Text + " ','" + usernameInput.Text + " ','" + typeBox.Text + "') ";
            }
            signInPage.s = typeBox.Text;
            signInPage.user = usernameInput.Text;
            sqlcommand.CommandType = CommandType.Text;
            sqlcommand.CommandText = query;
            sqlcommand.Connection = sqlconnection;
            SqlDataReader sdr = sqlcommand.ExecuteReader();
            sdr.Read();
            sqlconnection.Close();
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
        }

        private void firstNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
