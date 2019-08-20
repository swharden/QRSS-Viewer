using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRSS_Viewer
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/swharden/QRSS-Viewer");
        }
    }
}
