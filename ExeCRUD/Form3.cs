using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeCRUD
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daftarmenuDataSet1.Dessert' table. You can move, or remove it, as needed.
            this.dessertTableAdapter.Fill(this.daftarmenuDataSet1.Dessert);
            // TODO: This line of code loads data into the 'daftarmenuDataSet.Dessert' table. You can move, or remove it, as needed.
            this.dessertTableAdapter.Fill(this.daftarmenuDataSet.Dessert);
            // TODO: This line of code loads data into the 'daftarmenuDataSet.Minuman' table. You can move, or remove it, as needed.
            this.minumanTableAdapter.Fill(this.daftarmenuDataSet.Minuman);

        }
    }
}
