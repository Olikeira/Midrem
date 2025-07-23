using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace n_sei_mais_o_que_fazer
{
    public partial class paradaCard : KryptonForm
    {
        public paradaCard()
        {
            InitializeComponent();

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            webVid.Visible = true;
            kryptonButton14.Visible = true;
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/WrcdMYX4Ydc' width='700' height='400' frameborder='0' allowfullscreen='true'></iframe";
            html += "</body></html>";
            this.webVid.DocumentText = string.Format(html);
            kryptonButton2.Visible = false;
        }

        private void paradaCard_Load(object sender, EventArgs e)
        {
            kryptonButton14.Visible = false;
            webVid.Visible = false;
            kryptonButton14.Visible = false;
        }

        private void wbVideo_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton14_Click(object sender, EventArgs e)
        {
            webVid.Visible = false;
            kryptonButton14.Visible = false;
            kryptonButton2.Visible = true;

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
