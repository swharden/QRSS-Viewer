namespace QRSS_Viewer
{
    partial class SpectrogramViewer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbSpec = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSpec = new System.Windows.Forms.Panel();
            this.panelLevel = new System.Windows.Forms.Panel();
            this.pbLevelMask = new System.Windows.Forms.PictureBox();
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frequencyRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fFTSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTicksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colormapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viridisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bluesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpec)).BeginInit();
            this.panelSpec.SuspendLayout();
            this.panelLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelMask)).BeginInit();
            this.rightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSpec
            // 
            this.pbSpec.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbSpec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbSpec.Location = new System.Drawing.Point(0, 0);
            this.pbSpec.Name = "pbSpec";
            this.pbSpec.Size = new System.Drawing.Size(322, 233);
            this.pbSpec.TabIndex = 0;
            this.pbSpec.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panelSpec
            // 
            this.panelSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSpec.AutoScroll = true;
            this.panelSpec.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSpec.Controls.Add(this.pbSpec);
            this.panelSpec.Location = new System.Drawing.Point(11, 4);
            this.panelSpec.Name = "panelSpec";
            this.panelSpec.Size = new System.Drawing.Size(787, 376);
            this.panelSpec.TabIndex = 1;
            // 
            // panelLevel
            // 
            this.panelLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLevel.BackColor = System.Drawing.Color.Red;
            this.panelLevel.Controls.Add(this.pbLevelMask);
            this.panelLevel.Location = new System.Drawing.Point(3, 4);
            this.panelLevel.Margin = new System.Windows.Forms.Padding(0);
            this.panelLevel.Name = "panelLevel";
            this.panelLevel.Size = new System.Drawing.Size(5, 376);
            this.panelLevel.TabIndex = 2;
            // 
            // pbLevelMask
            // 
            this.pbLevelMask.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbLevelMask.Location = new System.Drawing.Point(0, 0);
            this.pbLevelMask.Name = "pbLevelMask";
            this.pbLevelMask.Size = new System.Drawing.Size(90, 200);
            this.pbLevelMask.TabIndex = 0;
            this.pbLevelMask.TabStop = false;
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.audioDeviceToolStripMenuItem,
            this.fFTSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.frequencyRangeToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.colormapToolStripMenuItem,
            this.showTicksToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem});
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size(181, 192);
            this.rightClickMenu.Opening += new System.ComponentModel.CancelEventHandler(this.RightClickMenu_Opening);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.BrightnessToolStripMenuItem_Click);
            // 
            // frequencyRangeToolStripMenuItem
            // 
            this.frequencyRangeToolStripMenuItem.Name = "frequencyRangeToolStripMenuItem";
            this.frequencyRangeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.frequencyRangeToolStripMenuItem.Text = "Frequency Range";
            this.frequencyRangeToolStripMenuItem.Click += new System.EventHandler(this.FrequencyRangeToolStripMenuItem_Click);
            // 
            // audioDeviceToolStripMenuItem
            // 
            this.audioDeviceToolStripMenuItem.Name = "audioDeviceToolStripMenuItem";
            this.audioDeviceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.audioDeviceToolStripMenuItem.Text = "Audio Device";
            this.audioDeviceToolStripMenuItem.Click += new System.EventHandler(this.AudioDeviceToolStripMenuItem_Click);
            // 
            // fFTSettingsToolStripMenuItem
            // 
            this.fFTSettingsToolStripMenuItem.Name = "fFTSettingsToolStripMenuItem";
            this.fFTSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fFTSettingsToolStripMenuItem.Text = "FFT Settings";
            this.fFTSettingsToolStripMenuItem.Click += new System.EventHandler(this.FFTSettingsToolStripMenuItem_Click);
            // 
            // showTicksToolStripMenuItem
            // 
            this.showTicksToolStripMenuItem.Name = "showTicksToolStripMenuItem";
            this.showTicksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showTicksToolStripMenuItem.Text = "Show Ticks";
            this.showTicksToolStripMenuItem.Click += new System.EventHandler(this.ShowTicksToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // colormapToolStripMenuItem
            // 
            this.colormapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viridisToolStripMenuItem,
            this.grayscaleToolStripMenuItem,
            this.greensToolStripMenuItem,
            this.bluesToolStripMenuItem});
            this.colormapToolStripMenuItem.Name = "colormapToolStripMenuItem";
            this.colormapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colormapToolStripMenuItem.Text = "Colormap";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // viridisToolStripMenuItem
            // 
            this.viridisToolStripMenuItem.Name = "viridisToolStripMenuItem";
            this.viridisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viridisToolStripMenuItem.Text = "Viridis";
            this.viridisToolStripMenuItem.Click += new System.EventHandler(this.ViridisToolStripMenuItem_Click);
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.GrayscaleToolStripMenuItem_Click);
            // 
            // greensToolStripMenuItem
            // 
            this.greensToolStripMenuItem.Name = "greensToolStripMenuItem";
            this.greensToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greensToolStripMenuItem.Text = "Greens";
            this.greensToolStripMenuItem.Click += new System.EventHandler(this.GreensToolStripMenuItem_Click);
            // 
            // bluesToolStripMenuItem
            // 
            this.bluesToolStripMenuItem.Name = "bluesToolStripMenuItem";
            this.bluesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bluesToolStripMenuItem.Text = "Blues";
            this.bluesToolStripMenuItem.Click += new System.EventHandler(this.BluesToolStripMenuItem_Click);
            // 
            // SpectrogramViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.rightClickMenu;
            this.Controls.Add(this.panelLevel);
            this.Controls.Add(this.panelSpec);
            this.Name = "SpectrogramViewer";
            this.Size = new System.Drawing.Size(801, 383);
            ((System.ComponentModel.ISupportInitialize)(this.pbSpec)).EndInit();
            this.panelSpec.ResumeLayout(false);
            this.panelLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelMask)).EndInit();
            this.rightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSpec;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelSpec;
        private System.Windows.Forms.Panel panelLevel;
        private System.Windows.Forms.PictureBox pbLevelMask;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frequencyRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fFTSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTicksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem colormapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viridisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bluesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
