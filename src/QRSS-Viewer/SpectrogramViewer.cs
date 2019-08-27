using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spectrogram;

namespace QRSS_Viewer
{
    public partial class SpectrogramViewer : UserControl
    {
        FormBrightness formBrightness;
        FormFreqRange formFreqRange;
        FormFFT formFFT;

        private NAudio.Wave.WaveInEvent wvin;
        public Spectrogram.Spectrogram spec;

        bool busyRendering;

        public SpectrogramViewer()
        {
            InitializeComponent();

        }

        public void Start(int deviceIndex = 0, int fftPower = 14, string preLoadWavFile = null)
        {
            int sampleRate = 8000;
            int fftSize = (int)(Math.Pow(2, fftPower));

            int tenMinutePixelWidth = 1000;
            int samplesInTenMinutes = sampleRate * 10 * 60;
            int segmentSize = samplesInTenMinutes / tenMinutePixelWidth;

            spec = new Spectrogram.Spectrogram(sampleRate, fftSize, segmentSize);
            spec.displaySettings.brightness = 5;
            spec.displaySettings.freqLow = 1000;
            spec.displaySettings.freqHigh = 1500;
            spec.displaySettings.tickSpacingHz = 50;
            spec.displaySettings.tickSpacingSec = 30;

            formBrightness = new FormBrightness(spec);
            formFreqRange = new FormFreqRange(spec);
            formFFT = new FormFFT(spec);

            pbSpec.Width = tenMinutePixelWidth;
            pbSpec.Height = spec.displaySettings.height;

            if (preLoadWavFile != null)
            {
                spec.AddExtend(Tools.ReadWav(preLoadWavFile));
            }
            else
            {
                int bitRate = 16;
                int channels = 1;
                int bufferMilliseconds = 20;
                wvin = new NAudio.Wave.WaveInEvent();
                wvin.DeviceNumber = deviceIndex;
                wvin.WaveFormat = new NAudio.Wave.WaveFormat(sampleRate, bitRate, channels);
                wvin.DataAvailable += OnDataAvailable;
                wvin.BufferMilliseconds = bufferMilliseconds;
                wvin.StartRecording();
            }
        }

        public void SetIntensity(float intensity)
        {
            spec.displaySettings.brightness = intensity;
            spec.displaySettings.renderNeeded = true;
        }

        public double lastAmplitudeFrac = 0;
        private void OnDataAvailable(object sender, NAudio.Wave.WaveInEventArgs args)
        {
            int bytesPerSample = wvin.WaveFormat.BitsPerSample / 8;
            float[] buffer = new float[args.BytesRecorded / bytesPerSample];
            for (int i = 0; i < buffer.Length; i++)
                buffer[i] = BitConverter.ToInt16(args.Buffer, i * bytesPerSample);
            lastAmplitudeFrac = (double)buffer.Max() / Int16.MaxValue;

            try
            {
                spec.AddCircular(buffer, fixedSize: pbSpec.Width);
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION: " + ex);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            pbLevelMask.Height = (int)(panelLevel.Height * (1 - lastAmplitudeFrac));
            if (lastAmplitudeFrac < .9)
                panelLevel.BackColor = Color.Green;
            else
                panelLevel.BackColor = Color.Red;

            if ((spec == null) || (spec.fftList.Count == 0))
                return;

            if (!spec.displaySettings.renderNeeded)
                return;

            if (!busyRendering)
            {
                busyRendering = true;
                spec.displaySettings.renderNeeded = false;
                pbSpec.BackgroundImage = spec.GetBitmap(
                    intensity: spec.displaySettings.brightness, 
                    freqLow: spec.displaySettings.freqLow, 
                    freqHigh: spec.displaySettings.freqHigh
                    );
                pbSpec.Size = pbSpec.BackgroundImage.Size;
                busyRendering = false;
            }
        }

        private void BrightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBrightness.Show();
        }

        private void FrequencyRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFreqRange.Show();
        }

        private void AudioDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FFTSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFFT.Show();
        }

        private void RightClickMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ShowTicksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spec.displaySettings.showTicks = !spec.displaySettings.showTicks;
            showTicksToolStripMenuItem.Checked = spec.displaySettings.showTicks;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.ShowDialog();
        }

        private void ViridisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spec.displaySettings.colormap = Colormap.viridis;
        }

        private void GrayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spec.displaySettings.colormap = Colormap.grayscale;
        }

        private void GreensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spec.displaySettings.colormap = Colormap.vdGreen;
        }

        private void BluesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spec.displaySettings.colormap = Colormap.vdBlue;
        }
    }
}
