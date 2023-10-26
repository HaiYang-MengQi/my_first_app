using System;
using System.Drawing;
using System.Windows.Forms;

namespace FileXplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("666");
        }

 

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = !checkBox2.Checked;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            checkBox3.Checked = !checkBox3.Checked;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            checkBox4.Checked = !checkBox4.Checked;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            checkBox5.Checked = !checkBox5.Checked;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            checkBox6.Checked = !checkBox6.Checked;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            checkBox7.Checked = !checkBox7.Checked;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            checkBox8.Checked = !checkBox8.Checked;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Green,13);
            Pen pen1 = new Pen(Color.Red,13);
           // Brush brush = new SolidBrush(Color.Green);
            Rectangle rectangle1 = new Rectangle(25,10,100,100);
            g.DrawEllipse(pen, rectangle1);
            g.DrawArc(pen1,rectangle1,-90,200);
            Rectangle rectangle2 = new Rectangle(185,10,100,100);
            g.DrawEllipse(pen, rectangle2);
            g.DrawArc(pen1, rectangle2, -90, 350);
            Rectangle rectangle3 = new Rectangle(350, 10, 100, 100);
            g.DrawEllipse(pen, rectangle3);
            g.DrawArc(pen1, rectangle3, -90, 300);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
