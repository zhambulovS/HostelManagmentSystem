using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    
    public partial class Form1 : Form
    {
       
        private Button currentButton;
        
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
           
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }


        private void main_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form7(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form5(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form6(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form8(), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form9(), sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
