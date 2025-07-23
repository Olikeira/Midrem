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
    public partial class DisfForm : KryptonForm
    {
        public DisfForm()
        {
            InitializeComponent();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Vid.Visible = false;
            principal.Visible = false;
            DiferençaPainel.Visible = true;
            causasPainel.Visible = false;
        }

        private void DisfForm_Load(object sender, EventArgs e)
        {
            Vid.Visible = false;
            principal.Visible = true;
            DiferençaPainel.Visible = false;
            causasPainel.Visible = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton14_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            DiferençaPainel.Visible = false;
            causasPainel.Visible = false;
            webVid.Visible = true;
            Vid.Visible = true;
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/tvuafWQoAG8' width='700' height='400' frameborder='0' allowfullscreen='true'></iframe";
            html += "</body></html>";
            this.webVid.DocumentText = string.Format(html);
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
        }

        private void btncausas_Click(object sender, EventArgs e)
        {
            Vid.Visible = false;
            principal.Visible = false;
            DiferençaPainel.Visible = false;
            causasPainel.Visible = true;
        }

        private void voltDif_Click(object sender, EventArgs e)
        {
            Vid.Visible = false;
            principal.Visible = true;
            DiferençaPainel.Visible = false;
            causasPainel.Visible = false;
        }

        private void volt_Click(object sender, EventArgs e)
        {
            Vid.Visible = false;
            principal.Visible = true;
            DiferençaPainel.Visible = false;
            causasPainel.Visible = false;
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            Vid.Visible = false;
            principal.Visible = true;
            DiferençaPainel.Visible = false;
            causasPainel.Visible = false;
        }
    }
}
