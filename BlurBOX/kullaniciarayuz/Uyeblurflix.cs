using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlurBOX.kullaniciarayuz
{
    public partial class Uyeblurflix : Form
    {
        public Uyeblurflix()
        {
            InitializeComponent();
        }

        private void Uyeblurflix_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'blurBOXDataSet.Filmler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmlerTableAdapter.Fill(this.blurBOXDataSet.Filmler);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Filmislemleridal filmIslemleri = new Filmislemleridal();
            string aramaKriteri = textBox1.Text;
            string aramakriteri2 = textBox1.Text;
            DataTable sonuc = filmIslemleri.FilmAra(aramaKriteri, aramakriteri2);
            dataGridView1.DataSource = sonuc;
        }

        private void filmlerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text=null;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string dosyaYolu = row.Cells[2].Value.ToString();
                MuzikCal(dosyaYolu);
            }

            void MuzikCal(string dosyaYolu)
            {
                axWindowsMediaPlayer1.URL = dosyaYolu;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            blurBOX blurBox = new blurBOX();
            blurBox.Show();
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
