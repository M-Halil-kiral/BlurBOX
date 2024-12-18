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
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                MuzikIslemleri muzikIslemleri = new MuzikIslemleri();
            muzikIslemleri.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Filmislemleri filmislemleri = new Filmislemleri();
            filmislemleri.Show();
            this.Hide();
        }

        private void YoneticiPaneli_Load(object sender, EventArgs e)
        {

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
