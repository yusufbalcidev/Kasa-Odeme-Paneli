using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel; 

namespace Restorant_Payment
{
    public partial class Form1 : Form
    {
        decimal toplam = 0;
        List<Sepet> sepetim = new List<Sepet>();
        Sepet sepet = new Sepet();
        Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SepetToplami();
        }
        void FisOlustur(string message)
        {
            Excel.Application excel = new Excel.Application();
            object missing=Type.Missing;
            Excel.Workbook workbook = excel.Workbooks.Add(missing); // 'Workbooks' çoðul olmalý
            Excel.Worksheet worksheet = (Excel.Worksheet)excel.Sheets[1];

            worksheet.Range["A1"].Value = "#";
            worksheet.Range["B1"].Value = "Ürün Adý";
            worksheet.Range["C1"].Value = "Adet";
            worksheet.Range["D1"].Value = "Birim Fiyatý";
            worksheet.Range["E1"].Value = "Toplam Tutar";

            worksheet.Range["A1"].ColumnWidth = 3.43;
            worksheet.Range["B1"].ColumnWidth = 13.43;
            worksheet.Range["C1"].ColumnWidth = 4.43;
            worksheet.Range["D1"].ColumnWidth = 10.43;
            worksheet.Range["E1"].ColumnWidth = 13.43;

            worksheet.Range["A1:E1"].Font.ColorIndex = 3;

            int rowCount = worksheet.Range["A" + worksheet.Rows.Count].End[Excel.XlDirection.xlUp].Row;
            rowCount++;
            for (int x= 0; x< sepetim.Count; x++)
            {
                worksheet.Range["A" + rowCount].Value = (x + 1);
                worksheet.Range["B" + rowCount].Value = sepetim[x].UrunAdi;
                worksheet.Range["C" + rowCount].Value = sepetim[x].Adet;
                worksheet.Range["D" + rowCount].Value = sepetim[x].BirimFiyati;

                worksheet.Range["E" + rowCount].Value = sepetim[x].Toplam;
                rowCount++;
            }
            worksheet.Range["A1:E" + (rowCount - 1)].Borders.LineStyle = 1;
            worksheet.Range["E" + rowCount].Formula = "=Sum(E2:E" + (rowCount - 1) + ")";
            worksheet.Range["E" + rowCount].Borders.LineStyle = 1;
            rowCount++;
            worksheet.Range["A" + rowCount].Value = message;
            worksheet.Range["A" + rowCount+":E"+rowCount].MergeCells = true;
            worksheet.Range["A" + rowCount].HorizontalAlignment = 3;
            worksheet.Range["A" + rowCount].VerticalAlignment = 2;
            worksheet.Range["A" + rowCount].Font.ColorIndex = 3;
            worksheet.Range["A" + rowCount].Font.Bold = true;

            worksheet.Range["D2:E" + rowCount].NumberFormat = "#,##0.00";
            workbook.SaveAs(@"C:\1\Test.xlsx");
            excel.Visible= true;

        }

        private void btnCocaCola_Click(object sender, EventArgs e)
        {
            // Yeni bir referans oluþturuyoruz ki her týklamada yeni ürün olsun
            sepet = new Sepet("CocaCola", 1, 50);
            Form2Cagir(sepet);
        }

        void Form2Cagir(Sepet sepet)
        {
            form2 = new Form2(sepet);
            form2._form1 = this; // ÖNCE atama yapýyoruz
            form2.Show();        // SONRA formu açýyoruz (Hata almamak için)
        }

        // Listeye ekleme iþlemini düzelttik
        public void SepeteUrunekle(Sepet sepet)
        {
            sepetim.Add(sepet); // EKSÝK OLAN KOD BUYDU
            SepetiGoster();
        }

        public void SepetiGoster()
        {
            dG1.DataSource = null; // Listeyi sýfýrlayýp tekrar baðlamak en temiz yoldur
            dG1.DataSource = sepetim;
            SepetToplami();
        }

        public void SepetToplami()
        {
            toplam = 0;
            foreach (var x in sepetim)
            {
                toplam += x.Toplam;
            }
            lbToplam.Text = string.Format("{0:C}", toplam);
        }

        // --- Diðer Butonlar (Manuel Adet Giriþi Kýsmý) ---
        void BtnlariKapat()
        {
            bool status = false;
            gBAdet.Visible = true;
            btnCocaCola.Enabled = status;
            btnFanta.Enabled = status;
            btnDondurma.Enabled = status;
            btndomates.Enabled = status;
            btnBiber.Enabled = status;
            btnPatlican.Enabled = status;
            btnNakit.Enabled = status;
            btnKrediKarti.Enabled = status;
        }

        private void btnFanta_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Fanta", 1, 40);
            Form2Cagir(sepet);
        }
        private void btnDondurma_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Dondurma", 1, 70);
            Form2Cagir(sepet);
        }
        private void btndomates_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Domates/kg", 1, 80);
            Form2Cagir(sepet);
        }
        private void btnBiber_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Biber/kg", 1, 100);
            Form2Cagir(sepet);
        }
        private void btnPatlican_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Patlican/kg", 1, 120);
            Form2Cagir(sepet);
        }

        // Manuel Adet Kýsmýndaki "Tamam/Ekle" butonu (Eðer varsa)
        // Kodunda 'button1_Click_1' gibi isimsiz butonlar vardý, 
        // burasý Form1 içindeki adet giriþini onaylamak içindir.
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Eðer Form1 içindeki gBAdet kullanýlarak ekleme yapýlýyorsa:
            if (int.TryParse(txtAdet.Text, out int adet))
            {
                sepet.Adet = adet;
                sepet.Toplam = sepet.BirimFiyati * sepet.Adet;
                SepeteUrunekle(sepet);
                Vazgec(); // Ýþlem bitince butonlarý aç
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Vazgec();
        }

        void Vazgec()
        {
            txtAdet.Text = "1";
            bool status = true;
            gBAdet.Visible = false;
            btnCocaCola.Enabled = status;
            btnFanta.Enabled = status;
            btnDondurma.Enabled = status;
            btndomates.Enabled = status;
            btnBiber.Enabled = status;
            btnPatlican.Enabled = status;
            btnNakit.Enabled = status;
            btnKrediKarti.Enabled = status;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        // Boþ eventler
        private void lbToplam_Click(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }

        private void dG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string urunAdi = dG1.Rows[e.RowIndex].Cells["UrunAdi"].Value.ToString();
                if (MessageBox.Show($"{urunAdi} adli urunu silmek istiyor musunuz?", "Sil",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sepetim.RemoveAt(e.RowIndex);
                    SepetiGoster();

                }

            }
        }

        private void btnNakit_Click(object sender, EventArgs e)
        {
            MesajGoster("Sepetteki urunler nakit olarak Odendi");
        }
        //generic metot
        void MesajGoster(string message)
        {
            if (sepetim.Count>0)
            {

                FisOlustur(message);
                return;
                sepetim = new List<Sepet>();
                SepetiGoster();
                MessageBox.Show(message, "Odeme yapildi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Ödeme yapmak için sepeti doldurunuz","bilgilendirme", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnKrediKarti_Click(object sender, EventArgs e)
        {
            MesajGoster("Sepetteki urunler Kredi Karti ile Odendi");
        }
    }
}