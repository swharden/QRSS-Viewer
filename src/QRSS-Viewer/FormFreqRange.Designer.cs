namespace QRSS_Viewer
{
    partial class FormFreqRange
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
            this.nudLower = new System.Windows.Forms.NumericUpDown();
            this.nudUpper = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpper)).BeginInit();
            this.SuspendLayout();
            // 
            // nudLower
            // 
            this.nudLower.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudLower.Location = new System.Drawing.Point(23, 47);
            this.nudLower.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudLower.Name = "nudLower";
            this.nudLower.Size = new System.Drawing.Size(82, 20);
            this.nudLower.TabIndex = 5;
            this.nudLower.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudUpper
            // 
            this.nudUpper.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudUpper.Location = new System.Drawing.Point(125, 47);
            this.nudUpper.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudUpper.Name = "nudUpper";
            this.nudUpper.Size = new System.Drawing.Size(82, 20);
            this.nudUpper.TabIndex = 6;
            this.nudUpper.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(74, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(155, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lower (Hz)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Upper (Hz)";
            // 
            // label3
            // 
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Image height: 1234 px";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormFreqRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 163);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudUpper);
            this.Controls.Add(this.nudLower);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormFreqRange";
            this.Text = "Frequency Range";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFreqRange_FormClosing);
            this.Load += new System.EventHandler(this.FormFreqRange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudLower;
        private System.Windows.Forms.NumericUpDown nudUpper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}