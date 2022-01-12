using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportsacademymanagement
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 obj1 = new Form7();
            obj1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 obj2 = new Form3();
            obj2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 obj3 = new Form4();
            obj3.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 obj4 = new Form6();
            obj4.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 ob = new Form12();
            ob.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form13 o = new Form13();
            o.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form14 o1 = new Form14();
            o1.ShowDialog();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
