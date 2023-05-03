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
    public partial class Form11 : Form
    {
        Form2 form2 = new Form2();
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.sql_conn.Open();
            SqlCommand cmd = form2.sql_conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            int id = Convert.ToInt32(textBox1.Text);
            cmd.CommandText = "update ggg set name = '" + textBox2.Text + "' , adress = '" + textBox3.Text + "', tel = '" + textBox4.Text + "' where id =" + id;
            cmd.ExecuteNonQuery();
            form2.sql_conn.Close();
            if (MessageBox.Show("Мәліметтер өзгерту!.Өзгерту жалғастырасыз ба?", "Мәліметтер өзгерту", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else Close();
        }
    }
}
