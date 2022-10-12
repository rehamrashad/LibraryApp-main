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
    public partial class Reader : Form
    {
        public Reader()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profile f1 = new Profile();
            f1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            signInPage f1 = new signInPage();
            f1.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void Reader_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet1.comment' table. You can move, or remove it, as needed.
            this.commentTableAdapter.Fill(this.libraryDataSet1.comment);
            // TODO: This line of code loads data into the 'libraryDataSet.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDataSet.book);
            //SqlConnection sq = new SqlConnection("Data Source=MARWA;Initial Catalog=Library;Integrated Security=True");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = MARWA; Initial Catalog=Library; Integrated Security = True");
            SqlDataAdapter adapt;
            DataTable dt;
            con.Open();
            if (comboBox1.Text != "All")
            {
                adapt = new SqlDataAdapter("select * from book where title like '" + textBox1.Text + "%' and bookType = '" + comboBox1.Text + "'", con);
            }
            else
            {
                adapt = new SqlDataAdapter("select * from book where title like '" + textBox1.Text + "%'", con);

            }
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source = MARWA; Initial Catalog=Library; Integrated Security = True");
            try
            {
                string querry = "select * from book where bookid = '" + textBox3.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, sqlconnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    sqlconnection.Open();
                    SqlCommand cmd5 = new SqlCommand();
                    cmd5.CommandType = CommandType.Text;
                    cmd5.CommandText = "UPDATE book set lastsolddate = GetDate() where bookid='" + textBox3.Text + "'";
                    cmd5.Connection = sqlconnection;

                    SqlDataReader dr5 = cmd5.ExecuteReader();
                  
                    sqlconnection.Close();


                    sqlconnection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select sold from book where bookid='" + textBox3.Text + "'";
                    cmd.Connection = sqlconnection;
                    
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    int d = dr.GetInt32(0);
                    sqlconnection.Close();
                    sqlconnection.Open();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select available from book where bookid='" + textBox3.Text + "'";
                    cmd2.Connection = sqlconnection;

                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    dr2.Read();
                    int d2 = dr2.GetInt32(0);

                    sqlconnection.Close();
                    d++;
                    d2--;

                    string q2 = "UPDATE  book SET sold= '" + d + "' WHERE bookid =  '" + textBox3.Text + "' ";
                    string q3 = "UPDATE  book SET available = '" + d2 + "' WHERE bookid =  '" + textBox3.Text + "' ";

                    SqlCommand sqlcommand3 = new SqlCommand();
                    sqlcommand3.Connection = sqlconnection;
                    sqlconnection.Open();
                    sqlcommand3.CommandType = CommandType.Text;
                    sqlcommand3.CommandText = q3;
                    sqlcommand3.Connection = sqlconnection;
                    SqlDataReader sdr3 = sqlcommand3.ExecuteReader();
                    sdr3.Read();
                    sqlconnection.Close();

                    SqlCommand sqlcommand2 = new SqlCommand();
                    sqlcommand2.Connection = sqlconnection;
                    sqlconnection.Open();
                    sqlcommand2.CommandType = CommandType.Text;
                    sqlcommand2.CommandText = q2;
                    sqlcommand2.Connection = sqlconnection;
                    SqlDataReader sdr2 = sqlcommand2.ExecuteReader();
                    sdr2.Read();
                    sqlconnection.Close();


                    SqlCommand sqlcommand = new SqlCommand();
                    sqlcommand.Connection = sqlconnection;
                    sqlconnection.Open();
                    string query = " insert into Buy values(' " + 1 + " ','" + textBox3.Text + " ','" + signInPage.user + " ') ";
                   
                    sqlcommand.CommandType = CommandType.Text;
                    sqlcommand.CommandText = query;
                    sqlcommand.Connection = sqlconnection;
                    SqlDataReader sdr = sqlcommand.ExecuteReader();
                    sdr.Read();



                    MessageBox.Show("Your Book has bought successfully .");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void commentBtn_Click(object sender, EventArgs e)
        {

            SqlConnection sqlconnection = new SqlConnection("Data Source = MARWA; Initial Catalog=Library; Integrated Security = True");
            try
            {
                string querry = "select * from book where bookid = '" + textBox4.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, sqlconnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string querry2 = "select * from comment where  commmentID = '" + textBox5.Text + "' ";
                SqlDataAdapter sda2 = new SqlDataAdapter(querry2, sqlconnection);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                if (dt.Rows.Count > 0&& dt2.Rows.Count <= 0)
                {
                    /* string querry2 = "select sold from buy where bookid = '" + textBox3.Text + "' ";
                     SqlDataAdapter sda2 = new SqlDataAdapter(querry2, sqlconnection);
                     DataTable dt2 = new DataTable();
                     sda2.Fill(dt2);


                     string querry3 = "select available from buy where bookid = '" + textBox3.Text + "' ";
                     SqlDataAdapter sda3 = new SqlDataAdapter(querry3, sqlconnection);
                     DataTable dt3 = new DataTable();
                     sda3.Fill(dt3);
 */


                    SqlCommand sqlcommand = new SqlCommand();
                    sqlcommand.Connection = sqlconnection;
                    sqlconnection.Open();
                    string query = " insert into comment values(' " + textBox2.Text + " ','" + textBox5.Text + " ',' "+ textBox4.Text + "  ','" + signInPage.user + " ') ";

                    sqlcommand.CommandType = CommandType.Text;
                    sqlcommand.CommandText = query;
                    sqlcommand.Connection = sqlconnection;
                    SqlDataReader sdr = sqlcommand.ExecuteReader();
                    sdr.Read();
                    MessageBox.Show("Your Comment has added successfully .");
                    Reader fr = new Reader();
                    fr.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This Book  doesn't exist!! or Comment ID already exists ");
                }
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
