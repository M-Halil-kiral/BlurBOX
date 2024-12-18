using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlurBox.BlurFinans
{
    public partial class BlurFinans : Form
    {
        public BlurFinans()
        {
            InitializeComponent();
            KrediTurleriniYukle();
            VadeleriYukle();
        }

        private void KrediTurleriniYukle()
        {
            cmbKrediTuru.Items.Add("İhtiyaç Kredisi");
            cmbKrediTuru.Items.Add("Araba Kredisi");
            cmbKrediTuru.Items.Add("Konut Kredisi");
            cmbKrediTuru.SelectedIndex = 0;

            cmbKrediTuru.SelectedIndexChanged += cmbKrediTuru_SelectedIndexChanged;
            VadeleriYukle(); // Başlangıçta vadeleri yükleyelim
        }

        private void VadeleriYukle()
        {
            cmbVade.Items.Clear(); // Önceki seçenekleri temizle
            string krediTuru = cmbKrediTuru.SelectedItem.ToString();

            if (krediTuru == "Konut Kredisi")
            {
                for (int i = 12; i <= 120; i += 12)
                {
                    cmbVade.Items.Add(i.ToString() + " Ay");
                }
            }
            else
            {
                for (int i = 3; i <= 48; i += 3)
                {
                    cmbVade.Items.Add(i.ToString() + " Ay");
                }
            }

            if (cmbVade.Items.Count > 0)
            {
                cmbVade.SelectedIndex = 0;
            }
        }

        private void cmbKrediTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            VadeleriYukle();
        }

        private void btnHesapla_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKrediMiktari.Text))
            {
                MessageBox.Show("Lütfen kredi miktarını giriniz.");
                return;
            }

            double krediMiktari;
            if (!double.TryParse(txtKrediMiktari.Text, out krediMiktari))
            {
                MessageBox.Show("Lütfen geçerli bir kredi miktarı giriniz.");
                return;
            }

            int taksitSuresi = int.Parse(cmbVade.SelectedItem.ToString().Split(' ')[0]);
            string krediTuru = cmbKrediTuru.SelectedItem.ToString();

            if ((krediTuru == "İhtiyaç Kredisi" && (krediMiktari > 100000 || taksitSuresi > 12)) ||
                (krediTuru == "Araba Kredisi" && (krediMiktari > 400000 || taksitSuresi > 48)) ||
                (krediTuru == "Konut Kredisi" && (krediMiktari > 1000000 || taksitSuresi > 120)))
            {
                MessageBox.Show("Kredi miktarı veya vade süresi limitlerin dışında.");
                return;
            }

            Dictionary<string, double> faizOranlari = new Dictionary<string, double>();

            switch (krediTuru)
            {
                case "İhtiyaç Kredisi":
                    faizOranlari.Add("ÇiftlikBank", 0.033);
                    faizOranlari.Add("İnşaatBank", 0.035);
                    faizOranlari.Add("Çalışma Bankası", 0.039);
                    faizOranlari.Add("Güvence Bankası", 0.042);
                    faizOranlari.Add("OkyanusBank", 0.028);
                    break;
                case "Araba Kredisi":
                    faizOranlari.Add("ÇiftlikBank", 0.045);
                    faizOranlari.Add("İnşaatBank", 0.048);
                    faizOranlari.Add("Çalışma Bankası", 0.048);
                    faizOranlari.Add("Güvence Bankası", 0.063);
                    faizOranlari.Add("OkyanusBank", 0.039);
                    break;
                case "Konut Kredisi":
                    faizOranlari.Add("ÇiftlikBank", 0.025);
                    faizOranlari.Add("İnşaatBank", 0.035);
                    faizOranlari.Add("Çalışma Bankası", 0.036);
                    faizOranlari.Add("Güvence Bankası", 0.045);
                    faizOranlari.Add("OkyanusBank", 0.029);
                    break;
            }

            List<KrediSonuc> krediSonuclar = new List<KrediSonuc>();

            foreach (var banka in faizOranlari)
            {
                double aylikFaizOrani = banka.Value;
                double aylikTaksit = (krediMiktari * aylikFaizOrani * Math.Pow(1 + aylikFaizOrani, taksitSuresi)) / (Math.Pow(1 + aylikFaizOrani, taksitSuresi) - 1);
                double toplamOdenecekTutar = aylikTaksit * taksitSuresi;

                krediSonuclar.Add(new KrediSonuc
                {
                    BankaAdi = banka.Key,
                    AylikTaksit = Math.Round(aylikTaksit, 2),
                    ToplamOdenecekTutar = Math.Round(toplamOdenecekTutar, 2)
                });
            }

            dataGridViewSonuclar.DataSource = krediSonuclar;
            dataGridViewSonuclar.Columns["AylikTaksit"].DefaultCellStyle.Format = "N2";
            dataGridViewSonuclar.Columns["ToplamOdenecekTutar"].DefaultCellStyle.Format = "N2";
        }

        private void dataGridViewSonuclar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbVade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtKrediMiktari_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbKrediTuru_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BlurFinans_Load(object sender, EventArgs e)
        {

        }
    }

    public class KrediSonuc
    {
        public string BankaAdi { get; set; }
        public double AylikTaksit { get; set; }
        public double ToplamOdenecekTutar { get; set; }
    }
}
