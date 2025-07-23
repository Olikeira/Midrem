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
    public partial class engasgamentoForm : KryptonForm
    {
        public engasgamentoForm()
        {
            InitializeComponent();
        }

        private void engasgamentoForm_Load(object sender, EventArgs e)
        {
            webVid.Visible = false;
            panel2.Visible = false;
            kryptonButton3.Visible = false;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            kryptonButton3.Visible = true;
            panel2.Visible = true;
            webVid.Visible = true;
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/nVztTfKBT6M' width='700' height='400' frameborder='0' allowfullscreen='true'></iframe";
            html += "</body></html>";
            this.webVid.DocumentText = string.Format(html);
            panel1.Visible = false;

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            webVid.Visible = false;
            kryptonButton3.Visible = false;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
