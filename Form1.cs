using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;

namespace sportsacademymanagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection  con = new SqlConnection(@"Data Source=LAPTOP-MI6UU1D9\SQLEXPRESS01;Initial Catalog=sportsacademy;Integrated Security=True");
            con.Open();
            string str = "SELECT * FROM login WHERE username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if(dr.GetValue(0).ToString() == "admin")
                {
                    this.Visible = false;
                    Form11 obj6 = new Form11();
                    obj6.ShowDialog();
                   
                }
                else
                {
                    this.Visible = false;
                    Form2 obj2 = new Form2();
                    obj2.ShowDialog();
                }
               
            }
            else
            {
                System.Windows.MessageBox.Show("Invalid username and Password.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MI6UU1D9\SQLEXPRESS01;Initial Catalog=sportsacademy;Integrated Security=True");
            con.Open();
            this.Hide();
            string str = "insert into login values('" + textBox1.Text + "','" + textBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr = cmd.ExecuteReader();
            System.Windows.MessageBox.Show("Registered Successfully");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
            Form2 obj5 = new Form2();
            obj5.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
