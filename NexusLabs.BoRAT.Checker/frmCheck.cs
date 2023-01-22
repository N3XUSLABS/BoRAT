using MetroFramework.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Threading;

namespace NexusLabs.BoRAT.Checker
{
    public partial class frmCheck : MetroForm
    {
        private bool startupExists { get; set; }

        public frmCheck()
        {
            InitializeComponent();
        }

        private void frmCheck_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            btnCheck.Text = "Checking...";
            btnCheck.Enabled = false;

            Thread.Sleep(1000);

            string appStartPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "/SearchHost.exe";

            if (File.Exists(appStartPath))
            {
                startupExists = true;
            }

            if (startupExists)
            {
                Tripped();
            }
            else
            {
                NotTripped();
            }
        }

        private void Tripped()
        {
            btnCheck.Text = "Check";
            btnCheck.Enabled = true;

            lbBoRATStatus.Text = "BoRAT Found!";
            lbRiskLabel.Text = "Your computer is at risk.\nA copy of BoRAT was found.";

            iconWarning.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            iconWarning.ForeColor = Color.DarkRed;
        }

        private void NotTripped()
        {
            btnCheck.Text = "Check";
            btnCheck.Enabled = true;

            lbBoRATStatus.Text = "BoRAT not found";
            lbRiskLabel.Text = "A copy of BoRAT was not found.\nYou are safe from BoRAT.";

            iconWarning.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconWarning.ForeColor = Color.Green;
        }
    }
}
