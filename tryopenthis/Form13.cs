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
    public partial class Form13 : Form
    {
        Form3 form3 = new Form3();
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form3.sql_conn.Open();
            SqlCommand cmd = form3.sql_conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into gg(fio,age,adress,tel,kafedra,spec) values(@t1,@t2,@t3,@t4,@t5,@t6)";
            cmd.Parameters.AddWithValue("@t1", textBox1.Text);
            cmd.Parameters.AddWithValue("@t2", textBox2.Text);
            cmd.Parameters.AddWithValue("@t3", textBox3.Text);
            cmd.Parameters.AddWithValue("@t4", textBox4.Text);
            cmd.Parameters.AddWithValue("@t5", textBox5.Text);
            cmd.Parameters.AddWithValue("@t6", textBox6.Text);
           
            cmd.ExecuteNonQuery();
            form3.sql_conn.Close();
            if (MessageBox.Show("Мәліметтер енгізілді!.Енгізуді жалғастырасыз ба?", "Мәліметтер енгізу", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();

            }
            else Close();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
