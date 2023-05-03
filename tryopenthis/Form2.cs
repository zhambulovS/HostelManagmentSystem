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
    public partial class Form2 : Form
    {
        public SqlConnection sql_conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Admin\Desktop\Test\Test\zzz.mdf';Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zzzDataSet.ggg". При необходимости она может быть перемещена или удалена.
            this.gggTableAdapter.Fill(this.zzzDataSet.ggg);

        }
        private void upDateBD()
        {
            sql_conn.Open();
            SqlCommand cmd = sql_conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ggg";
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            ds.Fill(dt);
            gggDataGridView.DataSource = dt;
            sql_conn.Close();
        }
        private void gggBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gggBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zzzDataSet);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            sql_conn.Open();
            SqlCommand cmd = sql_conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ggg";
            cmd.ExecuteNonQuery();
            sql_conn.Close();
            upDateBD();
        }

        private void мәліметтердіЕнгізуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            f.Show();
        }

        private void редактрлеуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void мәліметтердіӨзгертуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void мәліметтердіІздеуЖәнеӨшіруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void gggBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void gggDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
