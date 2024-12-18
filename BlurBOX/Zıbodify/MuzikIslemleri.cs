using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlurBOX
{
    public partial class MuzikIslemleri : Form
    {
        MuzikIslemleridal muzikIslemleridal = new MuzikIslemleridal();
        public MuzikIslemleri()
        {
            InitializeComponent();
        }

        private void MuzikIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'blurBOXDataSet.Muzik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.muzikTableAdapter.Fill(this.blurBOXDataSet.Muzik);
            // TODO: Bu kod satırı 'blurBOXDataSet.Filmler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmlerTableAdapter.Fill(this.blurBOXDataSet.Filmler);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Örnek inputlar, bunları formdaki textBox'lardan alabilirsiniz
            string baslik = textBox1.Text;
            string sanatci = textBox2.Text;
            string dosyaYolu = textBox3.Text;
            muzikIslemleridal.MuzikEkle(baslik, sanatci, dosyaYolu);
            //yabloyu yenile
            this.muzikTableAdapter.Fill(this.blurBOXDataSet.Muzik);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int muzikId = Convert.ToInt32(textBox4.Text);
            muzikIslemleridal.MuzikSil(muzikId);
            //yabloyu yenile
            this.muzikTableAdapter.Fill(this.blurBOXDataSet.Muzik);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    string dosyaYolu = row.Cells[3].Value.ToString();
                    MuzikCal(dosyaYolu);
                }
            }
            void MuzikCal(string dosyaYolu)
            {
                axWindowsMediaPlayer1.URL = dosyaYolu;
                axWindowsMediaPlayer1.Ctlcontrols.play();


            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int x = dataGridView1.SelectedCells[0].RowIndex;
            textBox4.Text = dataGridView1.Rows[x].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[x].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[x].Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\"; openFileDialog.Filter = "Müzik dosyaları (*.mp3;*.wav)|*.mp3;*.wav|Tüm dosyalar (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { // Seçilen dosya yolunu TextBox'a yazdır
                  textBox3.Text = openFileDialog.FileName; 


                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            YoneticiPaneli yntpanel = new YoneticiPaneli();
            yntpanel.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oturum Kapatılsın Mı ?", "Onay", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                GirisKontrolu form2 = new GirisKontrolu();
                form2.Show();
                this.Close();

            }
            else
            {

            }
        }
    }
}
