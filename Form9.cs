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

namespace sportsacademymanagement
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MI6UU1D9\SQLEXPRESS01;Initial Catalog=sportsacademy;Integrated Security=True");
            con.Open();

            try
            {
                string str = " INSERT INTO fees VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

              
                    MessageBox.Show("Your Fees Submitted..");
                    this.Hide();
                    Form2 obj2 = new Form2();
                    obj2.ShowDialog();
               
                this.Close();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MI6UU1D9\SQLEXPRESS01;Initial Catalog=sportsacademy;Integrated Security=True");

            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string get = "select name,sport from academy_records where academyid=" + Convert.ToInt32(textBox1.Text) + " ;";      // saving new custmer info

                    SqlCommand cmd = new SqlCommand(get, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label2.Text = dr.GetValue(0).ToString();
                        label3.Text = dr.GetValue(1).ToString();
      
                    }
                    else
                    {
                        MessageBox.Show("Sorry '" + textBox1.Text + "' This Academy Id is Invalid, Please Enter Correct Id");
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
