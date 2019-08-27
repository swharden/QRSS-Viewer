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
    public partial class FormBrightness : Form
    {
        Spectrogram.Spectrogram spec;

        public FormBrightness(Spectrogram.Spectrogram spec)
        {
            InitializeComponent();
            this.spec = spec;
        }

        private void FormBrightness_Load(object sender, EventArgs e)
        {
            trackBrightness.Value = (int)spec.displaySettings.brightness;
        }

        private void FormBrightness_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void TrackBrightness_Scroll(object sender, EventArgs e)
        {
            spec.displaySettings.brightness = (float)trackBrightness.Value;
        }

        private void BtnAuto_Click(object sender, EventArgs e)
        {
            if (spec.latestFFT == null)
                return;

            int autoVal = (int)(255.0/spec.latestFFT.Max()*10);
            autoVal = Math.Min(trackBrightness.Maximum, autoVal);
            autoVal = Math.Max(trackBrightness.Minimum, autoVal);

            trackBrightness.Value = autoVal;
            TrackBrightness_Scroll(null, null);
        }
    }
}
