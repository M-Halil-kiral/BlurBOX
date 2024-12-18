using BlurBox.BlurFinans;
using BlurBOX.kullaniciarayuz;
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
    public partial class blurBOX : Form
    {
        public blurBOX()
        {
            InitializeComponent();
        }

        private void blurBOX_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            blurGames blurGames = new blurGames();
            blurGames.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zibodifykul Sipotfy = new Zibodifykul();
            Sipotfy.Show();
            this.Close();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Uyeblurflix uyeblurflix = new Uyeblurflix();
            uyeblurflix.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            BlurFinans blurFinans = new BlurFinans();   
            blurFinans.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormTV tv = new FormTV();
            tv.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChatBot chatBot = new ChatBot();
            chatBot.Show();
        }
    }
}
