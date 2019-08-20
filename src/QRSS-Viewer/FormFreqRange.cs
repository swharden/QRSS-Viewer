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
        Spectrogram.Settings.DisplaySettings displaySettings;

        public FormFreqRange(Spectrogram.Settings.DisplaySettings displaySettings)
        {
            InitializeComponent();
            this.displaySettings = displaySettings;
        }

        private void FormFreqRange_Load(object sender, EventArgs e)
        {

        }

        private void FormFreqRange_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
