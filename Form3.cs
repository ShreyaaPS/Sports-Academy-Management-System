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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection  con = new SqlConnection(@"Data Source=LAPTOP-MI6UU1D9\SQLEXPRESS01;Initial Catalog=sportsacademy;Integrated Security=True");
            con.Open();
            string gender = string.Empty;
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }
            try
            {
                string str = " INSERT INTO coach(name,email,mobile,gender,sport,address,awards,coachid) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + gender + "','" + textBox6.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox7.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();



                string str1 = "select max(coachid) from coach ;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Coach Registered");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                }
                this.Close();
                



            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MI6UU1D9\SQLEXPRESS01;Initial Catalog=sportsacademy;Integrated Security=True");
            con.Open();
            string str1 = "select max(coachid) from coach;";

            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    textBox7.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    textBox7.Text = a.ToString();
                }
            }
            con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
