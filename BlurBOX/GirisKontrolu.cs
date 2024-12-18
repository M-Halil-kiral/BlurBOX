using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BlurBOX
{
    public partial class GirisKontrolu : Form
    {
        private VeritabaniBaglanti veritabani;

        

        public GirisKontrolu()
        {
            InitializeComponent();
            veritabani = new VeritabaniBaglanti();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string kullaniciAdi = textBox3.Text;
            string sifre = textBox4.Text;
            Kullanici kullanici = new Kullanici(kullaniciAdi, sifre);
            if (kullanici.KullaniciGirisKontrol())
            {
                MessageBox.Show("Giriş başarılı"); 
                // Kullanıcı paneline yönlendirme // Örneğin,
                blurBOX kullaniciPaneli = new blurBOX();
                 kullaniciPaneli.Show(); 
               this.Hide(); }
               else { MessageBox.Show("Giriş başarısız!"); 
           
                    } 
        }
           
       
        private void button1_Click(object sender, EventArgs e)
        {

          
                string yoneticiAdi = textBox1.Text;
                string yoneticiSifre = textBox2.Text;

                Yonetici yonetici = new Yonetici(yoneticiAdi, yoneticiSifre);
                if (yonetici.YoneticiGirisKontrol())
                {
                    MessageBox.Show("Giris basarili");
                    YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
                    yoneticiPaneli.Show();
                    this.Hide(); // Form1'i gizle
                }
                else
                {
                    MessageBox.Show("Giris basarisiz!");
                }
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Hide();
        }


        public void YoneticiKayit(string uyeisim, string uyesoyisim, string uyekullaniciadi, string uyesifre, string telno)
        {
            using (SqlConnection conn = veritabani.GetConnection())
            {
                string query = "INSERT INTO Uyeler (uyeisim, uyesoyisim, uyekullanciadi, uyesifre, telno)" +
                    " VALUES (@uyeisim, @uyesoyisim, @uyekullaniciadi, @uyesifre, @telno)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uyeisim", uyeisim);
                cmd.Parameters.AddWithValue("@uyesoyisim", uyesoyisim);
                cmd.Parameters.AddWithValue("@uyekullaniciadi", uyekullaniciadi);
                cmd.Parameters.AddWithValue("@uyesifre", uyesifre);
                cmd.Parameters.AddWithValue("@telno", telno);
                conn.Open(); cmd.ExecuteNonQuery();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            
                string uyeisim = textBox5.Text;
                string uyesoyisim = textBox6.Text;
                string uyekullaniciadi = textBox7.Text; 
                string uyesifre = textBox8.Text; 
                string telno = textBox9.Text;
               
                YoneticiKayit(uyeisim, uyesoyisim, uyekullaniciadi, uyesifre, telno);
                MessageBox.Show("Kayıt başarılı!"); 
   
                panel1.Hide();
        }

        public class VeritabaniBaglanti 
        {
            private string connectionString = "Data Source=MHALILKIRAL\\SQLEXPRESS;Initial Catalog=blurBOX;Integrated Security=True;";
            public SqlConnection GetConnection()
            { 
                return new SqlConnection(connectionString);
            } 
        
        }


    }
}
