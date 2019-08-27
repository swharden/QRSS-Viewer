namespace QRSS_Viewer
{
    partial class FormFFT
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbFftSize = new System.Windows.Forms.ComboBox();
            this.nudRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResolution = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(94, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(175, 121);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // cbFftSize
            // 
            this.cbFftSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFftSize.FormattingEnabled = true;
            this.cbFftSize.Location = new System.Drawing.Point(97, 59);
            this.cbFftSize.Name = "cbFftSize";
            this.cbFftSize.Size = new System.Drawing.Size(100, 21);
            this.cbFftSize.TabIndex = 0;
            // 
            // nudRate
            // 
            this.nudRate.Location = new System.Drawing.Point(97, 28);
            this.nudRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudRate.Name = "nudRate";
            this.nudRate.Size = new System.Drawing.Size(100, 20);
            this.nudRate.TabIndex = 0;
            this.nudRate.Value = new decimal(new int[] {
            1234,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sample Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "FFT Size:";
            // 
            // lblResolution
            // 
            this.lblResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResolution.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblResolution.Location = new System.Drawing.Point(12, 83);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(238, 35);
            this.lblResolution.TabIndex = 9;
            this.lblResolution.Text = "Resolution: 1.23 Hz";
            this.lblResolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormFFT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 156);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFftSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudRate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormFFT";
            this.Text = "Spectrograph Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFFT_FormClosing);
            this.Load += new System.EventHandler(this.FormFFT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbFftSize;
        private System.Windows.Forms.NumericUpDown nudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResolution;
    }
}