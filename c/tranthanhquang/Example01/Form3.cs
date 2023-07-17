using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2();
            frm1.Show();
        }
         private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm1 = new Form3();
            frm1.Show();
        }

    }
}
