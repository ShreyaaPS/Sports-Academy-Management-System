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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection  con = new SqlConnection(@"Data Source=LAPTOP-MI6UU1D9\SQLEXPRESS01;Initial Catalog=sportsacademy;Integrated Security=True");

            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select name,height,weight,handedness,indianrank,worldrank from academy_records where academyid=" + Convert.ToInt32(textBox1.Text) + " ;";     

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        label3.Text = dr.GetValue(0).ToString();
                        label4.Text = dr.GetValue(1).ToString();
                        label5.Text = dr.GetValue(2).ToString();
                        label6.Text = dr.GetValue(3).ToString();
                        label7.Text = dr.GetValue(4).ToString();
                        label8.Text = dr.GetValue(5).ToString();
                       
                    }
                    else
                    {
                        MessageBox.Show("Sorry '" + textBox1.Text + "' This Academy Id is Invalide, Please Enter Correct Id");
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
