using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Int64 score, click, p1, p2, autoclick;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score += autoclick;
            label1.Text = "Счет: " + score.ToString();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Location = new Point(195, 110);
            Thread.Sleep(100);
            SoundPlayer sp1 = new SoundPlayer("щелк.wav");
            sp1.Play();
            score += click;
            label1.Text = "Счет: " + score.ToString();
            pictureBox1.Location = new Point(195, 80);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter save = new StreamWriter("save.txt");
            save.WriteLine(score);
            save.WriteLine(click);
            save.WriteLine(autoclick);
            save.WriteLine(p1);
            save.WriteLine(p2);
            save.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader save = new StreamReader("save.txt");
            score = Convert.ToInt64(save.ReadLine());
            click = Convert.ToInt64(save.ReadLine());
            autoclick = Convert.ToInt64(save.ReadLine());
            p1 = Convert.ToInt64(save.ReadLine());
            p2 = Convert.ToInt64(save.ReadLine());
            save.Close();
            label1.Text = "Счет: " + score.ToString();
            SoundPlayer sp1 = new SoundPlayer("щелк.wav");
            sp1.Play();
        }

    }
}
