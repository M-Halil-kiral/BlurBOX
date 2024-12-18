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
    public partial class Filmislemleri : Form
    {
        Filmislemleridal filmislemleridal= new Filmislemleridal();
        public Filmislemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filmislemleridal.FilmEkle(textBox2.Text,textBox3.Text,textBox4.Text);
            this.filmlerTableAdapter.Fill(this.blurBOXDataSet.Filmler);
        }

        private void Filmislemleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'blurBOXDataSet.Filmler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmlerTableAdapter.Fill(this.blurBOXDataSet.Filmler);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            filmislemleridal.FilmSil(Convert.ToInt32(textBox1.Text));

            // TODO: Bu kod satırı 'blurBOXDataSet.Filmler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmlerTableAdapter.Fill(this.blurBOXDataSet.Filmler);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\"; 
                openFileDialog.Filter = "Video dosyaları (*.mp4;*.avi)|*.mp4;*.avi|Tüm dosyalar (*.*)|*.*"; 
                openFileDialog.FilterIndex = 1; 
                openFileDialog.RestoreDirectory = true; 
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { // Seçilen dosya yolunu TextBox'a yazdır
                  textBox4.Text = openFileDialog.FileName; } }
                }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
              {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    string dosyaYolu = row.Cells[3].Value.ToString();
                    Filmoynat(dosyaYolu);
                }
            }
            void Filmoynat(string dosyaYolu)
            {
                axWindowsMediaPlayer1.URL = dosyaYolu;
                axWindowsMediaPlayer1.Ctlcontrols.play();


            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int x = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[x].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[x].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[x].Cells[3].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
