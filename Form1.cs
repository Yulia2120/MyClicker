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
        bool right, left;
        public Form1()
        {
            InitializeComponent();
        }

        private void ArrowMovement()
        {
            if(right == true)
            {
                if (player.Left < 425)
                    player.Left += 3;
            }
            if(left == true)
            {
                if(player.Left > 0)
                {
                    player.Left -= 3;
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ArrowMovement();
        }

    }
}
