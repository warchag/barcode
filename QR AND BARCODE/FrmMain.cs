using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zen.Barcode;

namespace QR_AND_BARCODE
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Barcode_Click(object sender, EventArgs e)
        {
            Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(Mybarcode.Text,501);
        }

        private void qrcode_Click(object sender, EventArgs e)
        {
            CodeQrBarcodeDraw Qrcode = BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = Qrcode.Draw(Mybarcode.Text,50);
        }
    }
}
