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
    public partial class AddBookPage : Form
    {
        public AddBookPage()
        {
            InitializeComponent();
        }

        private void typeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Auther f1 = new Auther();
            f1.ShowDialog();
        }

        private void titleInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddBookPage_Load(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection("Data Source=MARWA;Initial Catalog=Library;Integrated Security=True");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=MARWA;Initial Catalog=Library;Integrated Security=True");
            try
            {
                string querry = "select * from book where bookid = '" + numericUpDown1.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, sqlconnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    SqlCommand sqlcommand = new SqlCommand();
                    sqlcommand.Connection = sqlconnection;
                    sqlconnection.Open();
                    string query = "Insert into book Values('" + priceInput.Text + "','" + typeBox.Text + "','" + titleInput.Text + "','" + availableUpDown.Text + "', 0 , null ,'" + publishDate.Value + "', '" + numericUpDown1.Text + "', '" + signInPage.user + "') ";
                    sqlcommand.CommandType = CommandType.Text;
                    sqlcommand.CommandText = query;
                    sqlcommand.Connection = sqlconnection;
                    SqlDataReader sdr = sqlcommand.ExecuteReader();
                    sdr.Read();
                    MessageBox.Show("Your Book added sucssesfuly.");
                }
                else
                {
                    MessageBox.Show("This ID is Alrady Exist");
                }
            }
            finally { sqlconnection.Close(); }
        }
    }
}
