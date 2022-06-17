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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daftarmenuDataSet1.Minuman' table. You can move, or remove it, as needed.
            this.minumanTableAdapter.Fill(this.daftarmenuDataSet1.Minuman);
            // TODO: This line of code loads data into the 'daftarmenuDataSet.Minuman' table. You can move, or remove it, as needed.
            this.minumanTableAdapter.Fill(this.daftarmenuDataSet.Minuman);

        }
    }
}
