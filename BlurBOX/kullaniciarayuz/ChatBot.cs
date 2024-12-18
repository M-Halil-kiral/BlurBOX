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
    public partial class ChatBot : Form
    {
        public ChatBot()
        {
            InitializeComponent();
        }

        private void webView21_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://dahi.ai/dahi/home?bid=675ab8f1223002ff6016f2e1&bname=BlurBot#");
        }
    }
}
