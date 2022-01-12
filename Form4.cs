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
    public partial class Form4 : Form
    {
        public Form4()
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
            else
            {
                gender = "Female";
            }
            try                                 
            {
                string str = "INSERT INTO personal_info(firstname,lastname,age,dob,gender,address,phoneno,parentn,parentphone) VALUES('" + textBox1.Text + "','" + textBox2.Text +"','" + textBox4.Text + "','" + dateTimePicker1.Text + "','" + gender + "','" + textBox3.Text + "','" + textBox7.Text + "','" + textBox5.Text + "','" +textBox6.Text +"'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Player Information Saved Successfully..");
                Form5 obj2 = new Form5();
                obj2.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

              
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            this.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 obj6 = new Form5();
            obj6.ShowDialog();
        }
    }
}
