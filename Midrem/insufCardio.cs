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
    public partial class insufCardio : KryptonForm
    {
        public insufCardio()
        {
            InitializeComponent();
        }

        private void btntipos_Click(object sender, EventArgs e)
        {
            painelcausas.Visible = false;
            painelsintomas.Visible = false;
            painelTipos.Visible = true;
            paineltratamento.Visible = false;
            principal.Visible = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btntratamento_Click(object sender, EventArgs e)
        {
            painelcausas.Visible = false;
            painelsintomas.Visible = false;
            painelTipos.Visible = false;
            paineltratamento.Visible = true;
            principal.Visible = false;
        }

        private void insufCardio_Load(object sender, EventArgs e)
        {
            painelcausas.Visible = false;
            painelsintomas.Visible = false;
            painelTipos.Visible = false;
            paineltratamento.Visible = false;
            principal.Visible = true;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            painelcausas.Visible = false;
            painelsintomas.Visible = false;
            painelTipos.Visible = false;
            paineltratamento.Visible = false;
            principal.Visible = true;
        }

        private void btnsintomas_Click(object sender, EventArgs e)
        {
            painelcausas.Visible = false;
            painelsintomas.Visible = true;
            painelTipos.Visible = false;
            paineltratamento.Visible = false;
            principal.Visible = false;
        }

        private void btncausas_Click(object sender, EventArgs e)
        {
            painelcausas.Visible = true;
            painelsintomas.Visible = false;
            painelTipos.Visible = false;
            paineltratamento.Visible = false;
            principal.Visible = false;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            painelcausas.Visible = false;
            painelsintomas.Visible = false;
            painelTipos.Visible = false;
            paineltratamento.Visible = false;
            principal.Visible = true;
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            painelcausas.Visible = false;
            painelsintomas.Visible = false;
            painelTipos.Visible = false;
            paineltratamento.Visible = false;
            principal.Visible = true;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            painelcausas.Visible = false;
            painelsintomas.Visible = false;
            painelTipos.Visible = false;
            paineltratamento.Visible = false;
            principal.Visible = true;
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
