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
    public partial class FormMain : Form
    {
        FormBrightness formBrightness;
        FormFreqRange formFreqRange;
        FormFFT formFFT;

        public FormMain()
        {
            InitializeComponent();

            foreach (string audioDevice in Audio.GetInputDevices())
            {
                var item = new ToolStripMenuItem();
                item.Text = audioDevice;
                soundCardToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.DoEvents();

            //spectrogramViewer1.Start(preLoadWavFile: "qrss.wav");
            spectrogramViewer1.Start();

            spectrogramViewer1.spec.SetDisplayRange(1000, 1500);
            spectrogramViewer1.SetIntensity(5);

            formBrightness = new FormBrightness(spectrogramViewer1.spec.displaySettings);
            formFreqRange = new FormFreqRange(spectrogramViewer1.spec.displaySettings);
            formFFT = new FormFFT(spectrogramViewer1.spec.fftSettings);
        }

        private void BrightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBrightness.Show();
        }

        private void TimerInfo_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");

            if (spectrogramViewer1.spec == null)
                return;

            lblRange.Text = $"Range: {spectrogramViewer1.spec.displaySettings.freqLow} - {spectrogramViewer1.spec.displaySettings.freqHigh} Hz";
            lblImageSize.Text = $"Image: {spectrogramViewer1.spec.displaySettings.width} x {spectrogramViewer1.spec.displaySettings.height}";
            lblFftInfo.Text = $"FFT: {spectrogramViewer1.spec.fftSettings.fftSize} ({spectrogramViewer1.spec.fftSettings.step} step)";
        }

        private void FrequencyRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFreqRange.Show();
        }

        private void FFTSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFFT.Show();
        }

        private void AboutQRSSViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void DocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/swharden/QRSS-Viewer");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
