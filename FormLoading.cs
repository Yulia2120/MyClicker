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
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
            this.Opacity = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Opacity < 100)
            {
                Opacity += 0.05;
                progressBar1.Increment(2);
            }
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                Form1 form = new Form1();
                form.ShowDialog();
            }
        }
    }
}
