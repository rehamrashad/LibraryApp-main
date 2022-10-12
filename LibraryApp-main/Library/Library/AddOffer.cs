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
    public partial class AddOffer : Form
    {
        public static Int32 id = 0;
        public AddOffer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlconnection = new SqlConnection("Data Source=MARWA;Initial Catalog=Library;Integrated Security=True");
            try
            {
                string querry = "select * from book where bookid = '" + textBox2.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, sqlconnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    SqlCommand sqlcommand = new SqlCommand();
                    sqlcommand.Connection = sqlconnection;
                    sqlconnection.Open();
                  
                    string query = " insert into offer values(' " + numericUpDown1.Text + " ','" + textBox1.Text + " ','" + textBox2.Text + " ','" + signInPage.user + " ') ";

                    sqlcommand.CommandType = CommandType.Text;
                    sqlcommand.CommandText = query;
                    sqlcommand.Connection = sqlconnection;
                    SqlDataReader sdr = sqlcommand.ExecuteReader();
                    sdr.Read();
                    MessageBox.Show("Your offer has been successfully added.");

                }
                else
                {
                    MessageBox.Show("There is no book with this ID");

                }

            }
            finally
            {
                sqlconnection.Close();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin f1 = new Admin();
            f1.ShowDialog();
        }

        private void AddOffer_Load(object sender, EventArgs e)
        {

        }
    }
}
