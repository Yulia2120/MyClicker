using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClicker
{
    public partial class Form1 : Form
    {
        Graphics g;
      //  Pen pen = new Pen(Color.Black, 2);
        Point mouse_location = new Point();

        string[] textR = { "100", "300", "400", "150" };
        Font font = new Font("Arial", 14);
        SolidBrush exbrush = new SolidBrush(Color.Yellow);
        int click, missed;

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();

            MouseMove += Form1_MouseMove;
        }
        private void MonetMove()
        {
            Random random = new Random();
            int x, y, z;
            if(pB1.Top >= 500)
            {
                x = random.Next(0, 300);
                pB1.Location = new Point(x, 0);
            }
            if (pB2.Top >= 500)
            {
                y = random.Next(0, 300);
                pB2.Location = new Point(y, 0);
            }
            if (pB3.Top >= 500)
            {
                z = random.Next(0, 300);
                pB3.Location = new Point(z, 0);
            }
            pB1.Top += 2;
            pB2.Top += 1;
            pB3.Top += 3;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            MonetMove();
        }
       
        private void pB1_MouseDown(object sender, EventArgs e)
        {
            click++;
            l_Click.Text = "Clicked: " + click;
            int index = new Random().Next(0, textR.Length);
            g.DrawString(textR[index], font, exbrush, mouse_location.X - 50, mouse_location.Y - 50);
            Sound();
        }

        private void pB2_MouseDown(object sender, EventArgs e)
        {
            click++;
            l_Click.Text = "Clicked: " + click;
            int index = new Random().Next(0, textR.Length);
            g.DrawString(textR[index], font, exbrush, mouse_location.X - 50, mouse_location.Y - 50);
            Sound();
        }

        private void pB3_MouseDown(object sender, EventArgs e)
        {
            click++;
            l_Click.Text = "Clicked: " + click;
            int index = new Random().Next(0, textR.Length);
            g.DrawString(textR[index], font, exbrush, mouse_location.X - 50, mouse_location.Y - 50);
            Sound();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_location.X = e.Location.X;
            mouse_location.Y = e.Location.Y;
            this.Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            missed++;
            l_Missed.Text = "Missed: " + missed;
        }
        private void Sound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\Admin\source\repos\MyClicker\Resources\zvon monet.wav");
            sound.Play();

        }
    }
}
