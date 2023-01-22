using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexusLabs.BoRAT.Client
{
    public partial class frmImage : Form
    {
        public frmImage()
        {
            InitializeComponent();

            Console.WriteLine(frmMain.URL);

            pbImage.ImageLocation = frmMain.URL;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmImage_Load(object sender, EventArgs e)
        {

        }
    }
}
