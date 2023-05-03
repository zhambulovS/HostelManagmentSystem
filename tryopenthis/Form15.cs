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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        string[] ggId = { };
        string[] ggfio = { };
        Form3 f = new Form3();

        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            Array.Resize(ref ggId, 0);
            Array.Resize(ref ggfio, 0);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Acer\Desktop\СРСП 2-2\Курсовой\Test\Test\xxx.mdf';Integrated Security=True");
            try
            {
                conn.Open();
                string sql = "select * from gg where fio LIKE '%" + textBox1.Text + "%'";

                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Array.Resize(ref ggId, ggId.Length + 1);
                    Array.Resize(ref ggfio, ggfio.Length + 1);
                    ggId[ggId.Length - 1] = reader[0].ToString();
                    ggfio[ggfio.Length - 1] = reader[1].ToString();
                }
                for (int i = 0; i < ggfio.Length; i++)
                    listBox1.Items.Add(ggfio[i].ToString());
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
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Admin\Desktop\Test\Test\xxx.mdf';Integrated Security=True");
            try
            {
                conn.Open();
                string sql = "delete from gg where id=" + ggId[listBox1.SelectedIndex];
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
