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

    }
}
