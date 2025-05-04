using Microsoft.VisualBasic.Devices;
using System;
using System.Net;

namespace YSA
{
    public partial class Form1 : Form
    {
        ButtonOlustur butonMatris;
        SinirAglari aglar;
        bool controlButton = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            aglar = new SinirAglari();

        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            butonMatris.Temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void egitim_Click(object sender, EventArgs e)
        {
            aglar.Egit(Convert.ToDouble(numericUpDown1.Value), 1000);
            if (controlButton) {
                butonMatris = new ButtonOlustur(this, new Point(20, 20), aglar, a_label, b_label, c_label, d_label, e_label);
                controlButton = false;
            }
        }
    }
}
