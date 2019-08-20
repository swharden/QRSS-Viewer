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
        Spectrogram.Settings.FftSettings fftSettings;

        public FormFFT(Spectrogram.Settings.FftSettings fftSettings)
        {
            InitializeComponent();
            this.fftSettings = fftSettings;
        }

        private void FormFFT_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
