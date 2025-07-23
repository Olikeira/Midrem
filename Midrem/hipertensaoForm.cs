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
    public partial class hipertensaoForm : KryptonForm
    {
        public hipertensaoForm()
        {
            InitializeComponent();
        }

        private void kryptonButton16_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            diureticospainel.Visible = true;
            alfaApainel.Visible = false;
            bloqueadpainel.Visible = false;
            bloqadrepainel.Visible = false;
            vasodilpainel.Visible = false;
            iecapainel.Visible = false;
            back.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hipertensaoForm_Load(object sender, EventArgs e)
        {
            principal.Visible = true;
            diureticospainel.Visible = false;
            alfaApainel.Visible = false;
            bloqueadpainel.Visible = false;
            bloqadrepainel.Visible = false;
            vasodilpainel.Visible = false;
            iecapainel.Visible = false;
            back.Visible = false;
        }

        private void ieca_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            diureticospainel.Visible = false;
            alfaApainel.Visible = false;
            bloqueadpainel.Visible = false;
            bloqadrepainel.Visible = false;
            vasodilpainel.Visible = false;
            iecapainel.Visible = true;
            back.Visible = true;
        }

        private void bloqadrene_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            diureticospainel.Visible = false;
            alfaApainel.Visible = false;
            bloqueadpainel.Visible = false;
            bloqadrepainel.Visible = true;
            vasodilpainel.Visible = false;
            iecapainel.Visible = false;
            back.Visible = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            principal.Visible = true;
            diureticospainel.Visible = false;
            alfaApainel.Visible = false;
            bloqueadpainel.Visible = false;
            bloqadrepainel.Visible = true;
            vasodilpainel.Visible = false;
            iecapainel.Visible = false;
            back.Visible = false;
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void vasodil_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            diureticospainel.Visible = false;
            alfaApainel.Visible = false;
            bloqueadpainel.Visible = false;
            bloqadrepainel.Visible = false;
            vasodilpainel.Visible = true;
            iecapainel.Visible = false;
            back.Visible = true;
        }

        private void bloquead_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            diureticospainel.Visible = false;
            alfaApainel.Visible = false;
            bloqueadpainel.Visible = true;
            bloqadrepainel.Visible = false;
            vasodilpainel.Visible = false;
            iecapainel.Visible = false;
            back.Visible = true;
        }

        private void alfaagonis_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            diureticospainel.Visible = false;
            alfaApainel.Visible = true;
            bloqueadpainel.Visible = false;
            bloqadrepainel.Visible = false;
            vasodilpainel.Visible = false;
            iecapainel.Visible = false;
            back.Visible = true;
        }
    }
}
