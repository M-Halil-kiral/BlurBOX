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
    public partial class Zibodifykul : Form
    {
        public Zibodifykul()
        {
            InitializeComponent();
        }

        private void Zibodifykul_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'blurBOXDataSet.Muzik' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.muzikTableAdapter.Fill(this.blurBOXDataSet.Muzik);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    string dosyaYolu = row.Cells[2].Value.ToString();
                    Filmoynat(dosyaYolu);
                }
            
            void Filmoynat(string dosyaYolu)
            {
                axWindowsMediaPlayer1.URL = dosyaYolu;
                axWindowsMediaPlayer1.Ctlcontrols.play();


            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MuzikIslemleridal muzikIslemleri = new MuzikIslemleridal();
            string aramaKriteri = textBox1.Text;
            string aramakriteri2 = textBox1.Text;
            DataTable sonuc = muzikIslemleri.MuzikAra(aramaKriteri, aramakriteri2);
            dataGridView1.DataSource = sonuc;
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

        private void button5_Click(object sender, EventArgs e)
        {
            blurBOX blurBox = new blurBOX();
            blurBox.Show();
            
        }
    }
}
