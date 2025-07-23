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
    public partial class inflamaForm : KryptonForm
    {
        public inflamaForm()
        {
            InitializeComponent();
        }

        private void inflamaForm_Load(object sender, EventArgs e)
        {
            principal.Visible = true;
            tratamento.Visible = false;
            causaspainel.Visible = false;
        }

        private void causasButton_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            tratamento.Visible = false;
            causaspainel.Visible = true;
        }

        private void tratamentoButton_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            tratamento.Visible = true;
            causaspainel.Visible = false;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            principal.Visible = true;
            tratamento.Visible = false;
            causaspainel.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            principal.Visible = true;
            tratamento.Visible = false;
            causaspainel.Visible = false;
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
