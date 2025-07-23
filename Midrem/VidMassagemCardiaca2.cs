using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n_sei_mais_o_que_fazer
{
    public partial class VidMassagemCardiaca2 : UserControl
    {
        public VidMassagemCardiaca2()
        {
            InitializeComponent();
        }

        private void wbVideo_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/WrcdMYX4Ydc' width='700' height='400' frameborder='0' allowfullscreen='true'></iframe";
            html += "</body></html>";
            this.wbVideo.DocumentText = string.Format(html);
        }

        private void VidMassagemCardiaca2_Load(object sender, EventArgs e)
        {

        }
    }
}
