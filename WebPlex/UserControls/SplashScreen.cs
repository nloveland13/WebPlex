﻿using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WebPlex.CControls
{
    public partial class SplashScreen : UserControl
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timerCount_Tick(object sender, System.EventArgs e)
        {
            lblLoadingStuckRestart.Visible = true;
        }

        private void lblLoadingStuckRestart_Click(object sender, System.EventArgs e)
        {
            if (Directory.Exists(MainForm.pathData)) { Directory.Delete(MainForm.pathData, true); } Application.Restart();
        }
    }
}
