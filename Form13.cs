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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MI6UU1D9\SQLEXPRESS01;Initial Catalog=sportsacademy;Integrated Security=True");

            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getc = "select academyid,name,handedness,sport from academy_records where academyid=" + Convert.ToInt32(textBox1.Text) + " ;";

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
                        MessageBox.Show("Sorry '" + textBox1.Text + "' This Player Id is Invalid, Please Enter Correct Id");
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=LAPTOP-MI6UU1D9\SQLEXPRESS01;Initial Catalog=sportsacademy;Integrated Security=True");
            con1.Open();
            string str = "DELETE FROM personal_info WHERE (firstname + ' ' + lastname) = '" + label3.Text + "'";
            string str1 = "delete from academy_records where academyid= ' " + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(str, con1);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand(str1, con1);
            cmd1.ExecuteNonQuery();
            con1.Close();
            MessageBox.Show("PLayer Record Deleted Successfully");

        }
    }
    
}
