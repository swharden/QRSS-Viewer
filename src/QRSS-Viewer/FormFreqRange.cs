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
    public partial class FormFreqRange : Form
    {
        Spectrogram.Spectrogram spec;

        public FormFreqRange(Spectrogram.Spectrogram spec)
        {
            InitializeComponent();
            this.spec = spec;
            LoadSettings();
        }

        private void FormFreqRange_Load(object sender, EventArgs e)
        {

        }

        private void FormFreqRange_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void LoadSettings()
        {
            nudLower.Value = (decimal)spec.displaySettings.freqLow;
            nudUpper.Value = (decimal)spec.displaySettings.freqHigh;
        }

        private void SaveSettings()
        {
            spec.displaySettings.freqLow = (double)nudLower.Value;
            spec.displaySettings.freqHigh = (double)nudUpper.Value;
        }

        private void UpdateDisplay()
        {
            double freqSpan = (double)(nudUpper.Value - nudLower.Value);
            int height = (int)(freqSpan / spec.displaySettings.fftResolution);
            label3.Text = $"Image height: {height} px";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LoadSettings();
            Hide();
        }

        private void NudLower_ValueChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void NudUpper_ValueChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}
