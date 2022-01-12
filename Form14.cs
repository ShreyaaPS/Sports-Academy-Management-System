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

namespace sportsacademymanagement
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-MI6UU1D9\SQLEXPRESS01;Initial Catalog=sportsacademy;Integrated Security=True");
            con1.Open();
            string getc = "select fee from fees where academyid=" + Convert.ToInt32(textBox1.Text) + " ;";
            SqlCommand cmd = new SqlCommand(getc, con1);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label3.Text = "Paid";
            }
            else
                label3.Text = "Not Paid yet!";
            con1.Close();
        }
    }
}
