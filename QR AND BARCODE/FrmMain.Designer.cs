namespace QR_AND_BARCODE
{
    partial class FrmMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mybarcode = new System.Windows.Forms.TextBox();
            this.Barcode = new System.Windows.Forms.Button();
            this.qrcode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Mybarcode
            // 
            this.Mybarcode.Location = new System.Drawing.Point(28, 276);
            this.Mybarcode.Name = "Mybarcode";
            this.Mybarcode.Size = new System.Drawing.Size(322, 20);
            this.Mybarcode.TabIndex = 1;
            // 
            // Barcode
            // 
            this.Barcode.Location = new System.Drawing.Point(28, 303);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(322, 23);
            this.Barcode.TabIndex = 2;
            this.Barcode.Text = "Barcode";
            this.Barcode.UseVisualStyleBackColor = true;
            this.Barcode.Click += new System.EventHandler(this.Barcode_Click);
            // 
            // qrcode
            // 
            this.qrcode.Location = new System.Drawing.Point(28, 332);
            this.qrcode.Name = "qrcode";
            this.qrcode.Size = new System.Drawing.Size(322, 23);
            this.qrcode.TabIndex = 3;
            this.qrcode.Text = "QR-Code";
            this.qrcode.UseVisualStyleBackColor = true;
            this.qrcode.Click += new System.EventHandler(this.qrcode_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 383);
            this.Controls.Add(this.qrcode);
            this.Controls.Add(this.Barcode);
            this.Controls.Add(this.Mybarcode);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmMain";
            this.Text = "MyBarcode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Mybarcode;
        private System.Windows.Forms.Button Barcode;
        private System.Windows.Forms.Button qrcode;
    }
}

