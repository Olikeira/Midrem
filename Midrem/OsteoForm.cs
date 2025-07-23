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
    public partial class OsteoForm : KryptonForm
    {
        public OsteoForm()
        {
            InitializeComponent();
        }

        private void OsteoForm_Load(object sender, EventArgs e)
        {
            principal.Visible = true;
            exercPainel.Visible = false;
            suplementosPainel.Visible=false;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = false;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = false;
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            principal.Visible = true;
            exercPainel.Visible = false;
            suplementosPainel.Visible = false;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = false;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = false;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void causasButton_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            exercPainel.Visible = false;
            suplementosPainel.Visible = false;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = false;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = true;

        }

        private void sintomas_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            exercPainel.Visible = false;
            suplementosPainel.Visible = false;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = false;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = true;
            Causaspainel.Visible = false;
        }

        private void tratamentoButton_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            exercPainel.Visible = false;
            suplementosPainel.Visible = false;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = true;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = false;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            principal.Visible = true;
            exercPainel.Visible = false;
            suplementosPainel.Visible = false;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = false;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = false;
        }

        private void back2_Click(object sender, EventArgs e)
        {
            principal.Visible = true;
            exercPainel.Visible = false;
            suplementosPainel.Visible = false;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = false;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = false;
        }

        private void remediosButton_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            exercPainel.Visible = false;
            suplementosPainel.Visible = false;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = false;
            Remediospainel.Visible = true;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = false;
        }

        private void alimentButton_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            exercPainel.Visible = false;
            suplementosPainel.Visible = false;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = false;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = true;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = false;
        }

        private void repHormbutton_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            exercPainel.Visible = false;
            suplementosPainel.Visible = false;
            RepHormPainel.Visible = true;
            tratamentoPainel.Visible = false;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = false;
        }

        private void suplementosButton_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            exercPainel.Visible = false;
            suplementosPainel.Visible = true;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = false;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = false;
        }

        private void ExercíciosButton_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            exercPainel.Visible = true;
            suplementosPainel.Visible = false;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = false;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = false;
        }

        private void botãoRemedios_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            exercPainel.Visible = false;
            suplementosPainel.Visible = false;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = true;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = false;
        }

        private void botaoExerci_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            exercPainel.Visible = false;
            suplementosPainel.Visible = false;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = true;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = false;
        }

        private void botaosuplementos_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            exercPainel.Visible = false;
            suplementosPainel.Visible = false;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = true;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = false;
        }

        private void botãorepos_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            exercPainel.Visible = false;
            suplementosPainel.Visible = false;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = true;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = false;
        }

        private void botaoAlimentacao_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            exercPainel.Visible = false;
            suplementosPainel.Visible = false;
            RepHormPainel.Visible = false;
            tratamentoPainel.Visible = true;
            Remediospainel.Visible = false;
            alimentacaopainel.Visible = false;
            sintomaspainel.Visible = false;
            Causaspainel.Visible = false;
        }
    }
}
