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
    public partial class add_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\data base\Database1.mdf;Integrated Security=True;MultipleActiveResultSets=False;Connect Timeout=30;Context Connection=False");

        public add_books()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText= " Insert into book_info values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text+ "'," + textBox4.Text + "," + textBox5.Text + ",getdate(),CURRENT_TIMESTAMP)";
            cmd.ExecuteNonQuery();
            MessageBox.Show("details saved succesfully");
            this.Hide();

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
