using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace NexusLabs.BoRAT.Server
{
    public partial class frmRdp : Form
    {
        public Bitmap image;

        public frmRdp()
        {
            InitializeComponent();
        }

        private void frmRemoteView_Shown(object sender, EventArgs e)
        {
            //tSetImage.Enabled = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void tSetImage_Tick(object sender, EventArgs e)
        {
            if (image != null)
                pictureBox1.Image = image;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                try
                {
                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                    if (image != null)
                        pictureBox1.Invoke((MethodInvoker)delegate { pictureBox1.Image = image; });

                    Thread.Sleep(1000);
                }
                catch (Exception)
                {
                }

                ;
            }
        }

        private void frmRemoteView_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void frmRemoteView_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}