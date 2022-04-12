using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyClicker
{
    public partial class Form1 : Form
    {
        Graphics g;
        Point mouse_location = new Point();

        string[] textR = { "100", "200", "300" };
        Font font = new Font("Arial", 14);
        SolidBrush exbrush = new SolidBrush(Color.Yellow);
        int click, missed, upgradecount;
        int sum = 1;
        int upgradecost = 5;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();

        }
        private void MonetMove()
        {
            Random random = new Random();
            int x, y, z;
            if (pB1.Top >= ClientSize.Height)
            {
                x = random.Next(0, 300);
                pB1.Location = new Point(x, 0);
                pB1.Image = Properties.Resources._1;
            }
            if (pB2.Top >= ClientSize.Height)
            {
                y = random.Next(0, 300);
                pB2.Location = new Point(y, 0);
                pB2.Image = Properties.Resources._1;
            }
            if (pB3.Top >= ClientSize.Height)
            {
                z = random.Next(0, 300);
                pB3.Location = new Point(z, 0);
                pB3.Image = Properties.Resources._1;
            }
            pB1.Top += 3;
            pB2.Top += 4;
            pB3.Top += 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MonetMove();
            GameResult();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_location.X = e.Location.X;
            mouse_location.Y = e.Location.Y;
            Invalidate();
        }

        private void Sound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\Admin\source\repos\MyClicker\Resources\zvon monet.wav");
            sound.Play();

        }
        private void pB1_Click(object sender, EventArgs e)
        {
            click++;
            l_Click.Text = $"Clicked: {click}";
            Sound();
        
                g.DrawString(textR[0], font, exbrush, mouse_location.X - 50, mouse_location.Y - 50);
                int res = Convert.ToInt32(textR[0]);
                sum = click * res;
                labBitcoin.Text = $"Money Per Click: {sum} $";
                if (upgradecount == 1)
                {
                    pB1.Image = Properties.Resources.kill;
                    g.DrawString(textR[1], font, exbrush, mouse_location.X - 50, mouse_location.Y - 50);
                    res = Convert.ToInt32(textR[1]);
                    sum = click * res;
                    labBitcoin.Text = $"Money Per Click: {sum} $";
                }
                if (upgradecount == 2)
                {
                    pB1.Image = Properties.Resources.kill;
                    g.DrawString(textR[2], font, exbrush, mouse_location.X - 50, mouse_location.Y - 50);
                    res = Convert.ToInt32(textR[2]);
                    sum = click * res;
                    labBitcoin.Text = $"Money Per Click: {sum} $";

                }
            
        }
    

        private void pB2_Click(object sender, EventArgs e)
        {
            click++;
            l_Click.Text = $"Clicked: {click}";
            Sound();
           
                g.DrawString(textR[0], font, exbrush, mouse_location.X - 50, mouse_location.Y - 50);
                int res = Convert.ToInt32(textR[0]);
                sum = click * res;
                labBitcoin.Text = $"Money Per Click: {sum} $";
                if (upgradecount == 1)
                {
                    pB2.Image = Properties.Resources.kill;
                    g.DrawString(textR[1], font, exbrush, mouse_location.X - 50, mouse_location.Y - 50);
                    res = Convert.ToInt32(textR[1]);
                    sum = click * res;
                    labBitcoin.Text = $"Money Per Click: {sum} $";
                }
                if (upgradecount == 2)
                {
                    pB2.Image = Properties.Resources.kill;
                    g.DrawString(textR[2], font, exbrush, mouse_location.X - 50, mouse_location.Y - 50);
                    res = Convert.ToInt32(textR[2]);
                    sum = click * res;
                    labBitcoin.Text = $"Money Per Click: {sum} $";
                }
            
        }

        private void pB3_Click(object sender, EventArgs e)
        {
            click++;
            l_Click.Text = $"Clicked: {click}";
            Sound();

                    g.DrawString(textR[0], font, exbrush, mouse_location.X - 50, mouse_location.Y - 50);
                    int res = Convert.ToInt32(textR[0]);
                    sum = click * res;
                    labBitcoin.Text = $"Money Per Click: {sum} $";
                    if (upgradecount == 1)
                    {
                        pB3.Image = Properties.Resources.kill;
                        g.DrawString(textR[1], font, exbrush, mouse_location.X - 50, mouse_location.Y - 50);
                        res = Convert.ToInt32(textR[1]);
                        sum = click * res;
                        labBitcoin.Text = $"Money Per Click: {sum} $";
                    }
                    if (upgradecount == 2)
                    {
                        pB3.Image = Properties.Resources.kill;
                        g.DrawString(textR[2], font, exbrush, mouse_location.X - 50, mouse_location.Y - 50);
                        res = Convert.ToInt32(textR[2]);
                        sum = click * res;
                        labBitcoin.Text = $"Money Per Click: {sum} $";
                    }
                
            
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Sound();
            missed++;
            l_Missed.Text = "Missed: " + missed;
        }

        private void cButUpgrade_Click(object sender, EventArgs e)
        {
            if (click > upgradecost - 1)
            {
                click = click - upgradecost;
                l_Click.Text = $"Clicked: {click}";
                upgradecount++;
                labUpgCount.Text = $"Upgrades Count: {upgradecount}";
                upgradecost = upgradecost * 2;
                labUpgCost.Text = $"Upgrade Cost:\n {upgradecost}";
             
            }
            else
            {
                MessageBox.Show("You don’t have enough money!", "Error");
            }
        }
        private void GameResult()
        {
            if(l_Missed.Text == "Missed: 5")
            {
                labOver.Visible = true;
                timer1.Stop();
            
            }
            if (l_Click.Text == "Clicked: 50")
            {
                labOver.Text = "Level Up...";
                labOver.Visible = true;
                timer1.Stop();
            }
        }
    }
}
