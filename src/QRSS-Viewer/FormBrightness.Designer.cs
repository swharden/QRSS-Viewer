namespace QRSS_Viewer
{
    partial class FormBrightness
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBrightness = new System.Windows.Forms.TrackBar();
            this.btnAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBrightness
            // 
            this.trackBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBrightness.AutoSize = false;
            this.trackBrightness.Location = new System.Drawing.Point(24, 43);
            this.trackBrightness.Maximum = 100;
            this.trackBrightness.Minimum = 1;
            this.trackBrightness.Name = "trackBrightness";
            this.trackBrightness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBrightness.Size = new System.Drawing.Size(54, 445);
            this.trackBrightness.TabIndex = 2;
            this.trackBrightness.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBrightness.Value = 10;
            this.trackBrightness.Scroll += new System.EventHandler(this.TrackBrightness_Scroll);
            // 
            // btnAuto
            // 
            this.btnAuto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAuto.Location = new System.Drawing.Point(12, 12);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(66, 25);
            this.btnAuto.TabIndex = 1;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.BtnAuto_Click);
            // 
            // FormBrightness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(90, 500);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.trackBrightness);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBrightness";
            this.Text = "Brightness";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBrightness_FormClosing);
            this.Load += new System.EventHandler(this.FormBrightness_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBrightness;
        private System.Windows.Forms.Button btnAuto;
    }
}