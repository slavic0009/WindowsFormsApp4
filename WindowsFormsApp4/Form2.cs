using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 form1_)
        {
            InitializeComponent();
            form1 = form1_;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = "Счет: " + form1.score.ToString();
            label3.Text = "Цена: " + form1.p1.ToString();
            label5.Text = "Клик: " + form1.click.ToString();
            label6.Text = "Автоклик: " + form1.autoclick.ToString();
            label7.Text = "Цена: " + form1.p2.ToString();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (form1.score >= form1.p1)
            {
                form1.click += 3;
                form1.score -= form1.p1;
                label4.Text = "Счет: " + form1.score.ToString();
                form1.label1.Text = "Счет: " + form1.score.ToString();
                form1.p1 *= 2;
                label3.Text = "Цена: " + form1.p1.ToString();
                label5.Text = "Клик: " + form1.click.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = "Счет: " + form1.score.ToString();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (form1.score >= form1.p2)
            {
                form1.autoclick += 20;
                form1.score -= form1.p2;
                label4.Text = "Счет: " + form1.score.ToString();
                form1.label1.Text = "Счет: " + form1.score.ToString();
                form1.p2 *= 2;
                label7.Text = "Цена: " + form1.p2.ToString();
                label6.Text = "Автоклик: " + form1.autoclick.ToString();
            }
        }
    }
}
