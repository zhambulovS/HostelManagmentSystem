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
    public partial class Form3 : Form
    {
        public SqlConnection sql_conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Admin\Desktop\Test\Test\xxx.mdf';Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }
        private void upDateBD()
        {
            sql_conn.Open();
            SqlCommand cmd = sql_conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from gg";
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            ggDataGridView.DataSource = dt;
            sql_conn.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "xxxDataSet.gg". При необходимости она может быть перемещена или удалена.
            this.ggTableAdapter.Fill(this.xxxDataSet.gg);

        }

        private void ggBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ggBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.xxxDataSet);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void мәліметтердіЕнгізуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            f.Show();

        }

        private void мәліметтердіӨзгертуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 f = new Form14();
            f.Show();
        }

        private void мәліметтердіІздеуЖәнеӨшіруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 f = new Form15();
            f.Show();
        }

        private void ggDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            sql_conn.Open();
            SqlCommand cmd = sql_conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from gg";
            cmd.ExecuteNonQuery();
            sql_conn.Close();
            upDateBD();
        }
    }
}
