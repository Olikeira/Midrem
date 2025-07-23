using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace n_sei_mais_o_que_fazer
{
    public partial class VidMassagemCardiaca : Form
    {
        public VidMassagemCardiaca()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<center><iframe id='video' src='https://www.youtube.com/watch?v=qVPmYAClXdA' width='560' height='315' frameborder='0' allowfullscreen='true'><iframe><center>";
        }
        
        public System.String URL { get; set; }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            const string page = "<html><head><title></title></head><body>{0}</body></html>";
            wbVideo.DocumentText = string.Format(page, "<iframe width=\"560\" height=\"315\" src=\"http://www.youtube.com/embed/yg2u_De8j5o\" frameborder=\"0\" allowfullscreen></iframe>");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VidMassagemCardiaca_Load(object sender, EventArgs e)
        {
            //exibicao em detalhes
            lvlVideos.View = View.Details;
            //permite selecionar linha toda
            lvlVideos.FullRowSelect = true;
            //exibir linhas de grade
            lvlVideos.GridLines = true;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text.Trim().Equals(string.Empty))
                {
                MessageBox.Show("Você deve informar a URL do video", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }

            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<center><iframe id='video' src='https://www.youtube.com/embeded/ (0)' width='560 height='315' frameborder='0' allowfullscreen='true'></iframe><center>";
            html += "</body></html>";

            wbVideo.DocumentText = string.Format(html, txtUrl.Text.Trim().Split('=')[1]);

            txtUrl.Text = string.Empty;
        }
    }
}
