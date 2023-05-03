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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        string[] gggId = { };
        string[] gggname = { };
        Form2 f = new Form2();
        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Array.Resize(ref gggId, 0);
            Array.Resize(ref gggname, 0);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Admin\Desktop\Test\Test\zzz.mdf;Integrated Security=True");
            try
            {
                conn.Open();
                string sql = "select * from ggg where name LIKE '%" + textBox1.Text + "%'";

                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Array.Resize(ref gggId, gggId.Length + 1);
                    Array.Resize(ref gggname, gggname.Length + 1);
                    gggId[gggId.Length - 1] = reader[0].ToString();
                    gggname[gggname.Length - 1] = reader[1].ToString();
                }
                for (int i = 0; i < gggname.Length; i++)
                    listBox1.Items.Add(gggname[i].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\v11.0; AttachDbFilename = 'C:\Users\Admin\Desktop\Test\Test\zzz.mdf'; Integrated Security = True");
            try
            {
                conn.Open();
                string sql = "delete from ggg where id=" + gggId[listBox1.SelectedIndex];
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Сәтті өшірілді!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
