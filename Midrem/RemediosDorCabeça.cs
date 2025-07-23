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
    public partial class RemediosDorCabeça : KryptonForm
    {
        public RemediosDorCabeça()
        {
            InitializeComponent();
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            Paracetamol.Visible = true;
            principal.Visible = false;
            Dipirona.Visible = false;
            kryptonButton3.Visible = true;
        }

        private void RemediosDorCabeça_Load(object sender, EventArgs e)
        {
            Dipirona.Visible = false;
            Paracetamol.Visible = false;
            principal.Visible = true;
            kryptonButton3.Visible = false;

            principal.Visible = true;
            painelTensional.Visible = false;
            cef.Visible= false;
            sinusite.Visible = false;
            exaqueca.Visible = false;
            tensionalTrata.Visible = false;
            ceftrata.Visible = false;
            sinusiteTrata.Visible = false;
            enxTrata.Visible = false;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Paracetamol.Visible = false;
            principal.Visible = false;
            Dipirona.Visible = true;
            kryptonButton3.Visible = true;
        }

        private void kryptonButton14_Click(object sender, EventArgs e)
        {
            Paracetamol.Visible = false;
            principal.Visible = true;
            Dipirona.Visible = false;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            kryptonButton3.Visible = false;
            principal.Visible = true;
            painelTensional.Visible = false;
            cef.Visible = false;
            sinusite.Visible = false;
            exaqueca.Visible = false;
            tensionalTrata.Visible = false;
            ceftrata.Visible = false;
            sinusiteTrata.Visible = false;
            enxTrata.Visible = false;
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            kryptonButton3.Visible = true;
            principal.Visible = false;
            painelTensional.Visible = true;
            cef.Visible = false;
            sinusite.Visible = false;
            exaqueca.Visible = false;

        }

        private void kryptonButton9_Click(object sender, EventArgs e)
        {
            kryptonButton3.Visible = true;
            principal.Visible = false;
            painelTensional.Visible = false;
            cef.Visible = false;
            sinusite.Visible = false;
            exaqueca.Visible = true;
        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            kryptonButton3.Visible = true;
            principal.Visible = false;
            painelTensional.Visible = false;
            cef.Visible = false;
            sinusite.Visible = true;
            exaqueca.Visible = false;
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            kryptonButton3.Visible = true;
            principal.Visible = false;
            painelTensional.Visible = false;
            cef.Visible = true;
            sinusite.Visible = false;
            exaqueca.Visible = false;
        }

        private void kryptonButton12_Click(object sender, EventArgs e)
        {
            kryptonButton14.Visible = true;
            cef.Visible = false;
            ceftrata.Visible = true;
            kryptonButton3.Visible = false;
        }

        private void kryptonButton11_Click(object sender, EventArgs e)
        {
            sinusite.Visible = false;
            sinusiteTrata.Visible = true;
            kryptonButton3.Visible = false;
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            exaqueca.Visible = false;
            enxTrata.Visible = true;
            kryptonButton3.Visible = false;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            painelTensional.Visible=false;
            tensionalTrata.Visible = true;
            kryptonButton3.Visible = false;
        }

        private void kryptonButton13_Click(object sender, EventArgs e)
        {
            kryptonButton3.Visible = true;
            sinusiteTrata.Visible=false;
            sinusite.Visible = true;
        }

        private void kryptonButton14_Click_1(object sender, EventArgs e)
        {
            kryptonButton3.Visible = true;
            ceftrata.Visible = false;
            cef.Visible = true;
        }

        private void kryptonButton15_Click(object sender, EventArgs e)
        {
            kryptonButton3.Visible = true;
            enxTrata.Visible = false;
            exaqueca.Visible = true;
        }

        private void kryptonButton16_Click(object sender, EventArgs e)
        {
            kryptonButton3.Visible = true;
            tensionalTrata.Visible = false;
            painelTensional.Visible = true;
        }
    }
}
