using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProgressBarDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(new Action(delegate
            {

                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                    this.circleProgramBar.Progress = i + 1;
                }
            })));
            thread.IsBackground = true;
            thread.Start();
        }
    }
}
