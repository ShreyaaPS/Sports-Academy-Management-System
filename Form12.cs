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
    public partial class Form12 : Form
    {

        public Form12()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-MI6UU1D9\SQLEXPRESS01;Initial Catalog=sportsacademy;Integrated Security=True");
                con1.Open();
                string str = "DELETE FROM coach WHERE coachid = '" + textBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con1);
                cmd.ExecuteNonQuery();
                con1.Close();
                MessageBox.Show("Coach Record Deleted Successfully");
            
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MI6UU1D9\SQLEXPRESS01;Initial Catalog=sportsacademy;Integrated Security=True");

            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getc = "select coachid,name,gender,sport from coach where coachid=" + Convert.ToInt32(textBox1.Text) + " ;";

                    SqlCommand cmd = new SqlCommand(getc, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label2.Text = dr.GetValue(0).ToString();
                        label3.Text = dr.GetValue(1).ToString();
                        label4.Text = dr.GetValue(2).ToString();
                        label5.Text = dr.GetValue(3).ToString();

                    }
                    else
                    {
                        MessageBox.Show("Sorry '" + textBox1.Text + "' This coach Id is Invalid, Please Enter Correct Id");
                        textBox1.Text = "";

                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }
    }
}
