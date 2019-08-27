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
    public partial class FormFFT : Form
    {
        // NOTE: changing FFT settings requires re-initializing the spec class... this should probably happen a level up

        Spectrogram.Spectrogram spec;

        public FormFFT(Spectrogram.Spectrogram spec)
        {
            InitializeComponent();
            this.spec = spec;
        }

        private void FormFFT_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void FormFFT_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
