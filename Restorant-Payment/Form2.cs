using System;
using System.Windows.Forms;

namespace Restorant_Payment
{
    public partial class Form2 : Form
    {
        Sepet _sepet;
        public Form1 _form1;

        // Parametresiz ctor hata vermemesi için kalsın ama kullanmıyoruz
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Sepet sepet)
        {
            InitializeComponent();
            _sepet = sepet;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // BURAYI SİLDİM. Form açılır açılmaz ekleme yapmamalı.
            // Kullanıcı adeti girip "Kaydet" dediğinde eklemeli.
            txtAdet.Text = "1"; // Varsayılan adet
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (_form1 != null)
            {
                // Sayı girilip girilmediğini kontrol etmezsek program çökebilir
                if (int.TryParse(txtAdet.Text, out int adet))
                {
                    _sepet.Adet = adet;
                    _sepet.Toplam = _sepet.Adet * _sepet.BirimFiyati;

                    _form1.SepeteUrunekle(_sepet);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir sayı giriniz.");
                }
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Boş eventler
        private void label1_Click(object sender, EventArgs e) { }
        private void txtAdet_TextChanged(object sender, EventArgs e) { }
    }
}