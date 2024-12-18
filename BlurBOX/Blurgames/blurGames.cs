using BlurBOX.Blurgames.BlurBall;
using BlurBOX.Blurgames.MayınTarlası;
using BlurBOX.Blurgames.Snake;
using BlurBOX.Blurgames.TicTacToe;
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
    public partial class blurGames : Form
    {
        public blurGames()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form1 gameForm = new Form1(); 
            gameForm.FormClosed += GameForm_FormClosed;
            
            gameForm.Show();

        }
        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Ana formu yeniden göster
         }

        private void button2_Click(object sender, EventArgs e)
        {
            TicTacToe sos = new TicTacToe();
            sos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MayinTarlasi myn =new MayinTarlasi();
            myn.Show();
        }

        private void blurGames_Load(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            blurBOX blurBox = new blurBOX();
            blurBox.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BlurBall blurBall = new BlurBall();
            blurBall.Show();
        }
    }
}
