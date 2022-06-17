using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExeCRUD
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daftarmenuuDataSet.Makanan' table. You can move, or remove it, as needed.
            this.makananTableAdapter1.Fill(this.daftarmenuuDataSet.Makanan);
            // TODO: This line of code loads data into the 'daftarmenuDataSet.Makanan' table. You can move, or remove it, as needed.
            this.makananTableAdapter.Fill(this.daftarmenuDataSet.Makanan);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
