using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace BlurBOX
{
    public partial class FormTV : Form
    {
        public FormTV()
        {
            InitializeComponent();
        }

        private async void FormTV_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.youtube.com/watch?v=7uBpwcn2ZZ0");
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.youtube.com/watch?v=hHSmBJk6w0c&list=PLmVzVfed7ZE-jFf8ln2O3iF3qUgi70ZOn&index=3");
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.youtube.com/watch?v=6BX-NUzBSp8&list=PLmVzVfed7ZE-jFf8ln2O3iF3qUgi70ZOn&index=1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.youtube.com/watch?v=t1TaNys7xd8");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.youtube.com/watch?v=VCl1wO81VdM");
        }
    }
}
