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

namespace library_management
{
    public partial class add_student : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\data base\Database1.mdf;Integrated Security=True;MultipleActiveResultSets=False;Connect Timeout=30;Context Connection=False");
        string gender;
        string course;
        public add_student()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            course = "BCA";
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            course = "BBA";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " Insert into student_info values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "'," + textBox3.Text + ",'"+gender+"','" + textBox4.Text + "','"+ textBox5.Text+"',"+textBox6.Text+",'"+course+"' , getdate())";
            cmd.ExecuteNonQuery();
            MessageBox.Show("details saved succesfully");
            this.Hide();
            con.Close();
        }

       
    }
}
