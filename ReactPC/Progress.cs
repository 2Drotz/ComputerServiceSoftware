using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReactPC
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        int start = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            start += 10;
            progressBar1.Value = start;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Sign frmSign = new Sign();
                this.Hide();
                frmSign.ShowDialog();
            }
        }
        private void Progress_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
