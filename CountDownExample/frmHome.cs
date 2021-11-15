using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDownExample
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        int count = 0;

        int min = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmCount.Start();
        }

        private void tmCount_Tick(object sender, EventArgs e)
        {
            count++;
            if (count >= 60)
            {
                min++;
                if (min.ToString().Length == 1)
                {
                    lbMin.Text = "0" + min.ToString();
                } else
                {
                    lbMin.Text =  min.ToString();
                }
                
                count = 0;
            }
           
            if (count.ToString().Length == 1)
            {
                lbSec.Text = "0" + count.ToString();
            }
            else
            {
                lbSec.Text = count.ToString();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmCount.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            min = 0;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
