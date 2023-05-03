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
    public partial class Form10 : Form
    {
        Form2 form2 = new Form2();
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.sql_conn.Open();
            SqlCommand cmd = form2.sql_conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into ggg(name,adress,kyryldy,tel,floor,bolme,mesto) values(@t1,@t2,@t3,@t4,@t5,@t6,@t7)";
            cmd.Parameters.AddWithValue("@t1", textBox1.Text);
            cmd.Parameters.AddWithValue("@t2", textBox2.Text);
            cmd.Parameters.AddWithValue("@t3", textBox3.Text);
            cmd.Parameters.AddWithValue("@t4", textBox4.Text);
            cmd.Parameters.AddWithValue("@t5", textBox5.Text);
            cmd.Parameters.AddWithValue("@t6", textBox6.Text);
            cmd.Parameters.AddWithValue("@t7", textBox7.Text);
            cmd.ExecuteNonQuery();
            form2.sql_conn.Close();
            if (MessageBox.Show("Мәліметтер енгізілді!.Енгізуді жалғастырасыз ба?", "Мәліметтер енгізу", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
             
            }
            else Close();
        }

    }
}
