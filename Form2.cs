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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 obj1 = new Form8();
            obj1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 obj2 = new Form7();
            obj2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 obj4 = new Form6();
            obj4.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 obj5 = new Form9();
            obj5.ShowDialog();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 b = new Form15();
            b.ShowDialog();
        }
    }
}
