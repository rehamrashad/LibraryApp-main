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
    public partial class AddReport : Form
    {
        public AddReport()
        {
            InitializeComponent();
        }

        private void AddReport_Load(object sender, EventArgs e)
        {

        }

        private void addReportLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin f1 = new Admin();
            f1.ShowDialog();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source = MARWA; Initial Catalog=Library; Integrated Security = True");
            try
            {
                string querry = "select * from book where bookid = '" + textBox1.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, sqlconnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    SqlCommand sqlcommand = new SqlCommand();
                    sqlcommand.Connection = sqlconnection;
                    sqlconnection.Open();
                    string query = " insert into report values(' " + nameInput.Text + " ','" + contentInput.Text + " ','" + textBox1.Text + " ','" + textBox1.Text + " ','" + signInPage.user + " ') ";

                    sqlcommand.CommandType = CommandType.Text;
                    sqlcommand.CommandText = query;
                    sqlcommand.Connection = sqlconnection;
                    SqlDataReader sdr = sqlcommand.ExecuteReader();
                    sdr.Read();
                    MessageBox.Show("Your report has been successfully added.");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            finally
            {
                sqlconnection.Close();
            }
        }
    }
}
