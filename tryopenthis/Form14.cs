using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
   
    public partial class Form14 : Form
    {
        Form3 form3 = new Form3();

        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form3.sql_conn.Open();
            SqlCommand cmd = form3.sql_conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            int id = Convert.ToInt32(textBox1.Text);
            cmd.CommandText = "update gg set adress = '" + textBox2.Text + "' , tel = '" + textBox3.Text + "' where id =" + id;
            cmd.ExecuteNonQuery();
            form3.sql_conn.Close();
            if (MessageBox.Show("Мәліметтер өзгерту!.Өзгерту жалғастырасыз ба?", "Мәліметтер өзгерту", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                
            }
            else Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
