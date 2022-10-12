using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Profile f1 = new Profile();
            f1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddReport f1 = new AddReport();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddOffer f1 = new AddOffer();
            f1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            signInPage f1 = new signInPage();
            f1.ShowDialog();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.offer' table. You can move, or remove it, as needed.
            this.offerTableAdapter.Fill(this.libraryDataSet.offer);
            // TODO: This line of code loads data into the 'libraryDataSet.report' table. You can move, or remove it, as needed.
            this.reportTableAdapter.Fill(this.libraryDataSet.report);

        }
    }
}
