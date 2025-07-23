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
    public partial class Infecções : UserControl
    {
        public Infecções()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            principalpainel.Visible = false;
            viruspainel.Visible = false;
            bacteriaspainel.Visible = true;
            kryptonButton5.Visible = true;
        }

        private void principalpainel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void infvirus1_Load(object sender, EventArgs e)
        {
            principalpainel.Visible = true;
            viruspainel.Visible = false;
            bacteriaspainel.Visible = false;
            kryptonButton5.Visible = false;
            fungospainel.Visible = false;
            parasitaspainel.Visible = false;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            principalpainel.Visible = false;
            viruspainel.Visible = true;
            bacteriaspainel.Visible = false;
            kryptonButton5.Visible = true;
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            principalpainel.Visible = true;
            viruspainel.Visible = false;
            bacteriaspainel.Visible = false;
            kryptonButton5.Visible = false;
            fungospainel.Visible = false;
            parasitaspainel.Visible = false;
        }

        private void kryptonButton14_Click(object sender, EventArgs e)
        {
            principalpainel.Visible = true;
            viruspainel.Visible = false;
            bacteriaspainel.Visible = false;
        }

        private void infparasitas1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            principalpainel.Visible = false;
            viruspainel.Visible = false;
            bacteriaspainel.Visible = false;
            kryptonButton5.Visible = true;
            fungospainel.Visible = true;
            parasitaspainel.Visible = false;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            principalpainel.Visible = false;
            viruspainel.Visible = false;
            bacteriaspainel.Visible = false;
            kryptonButton5.Visible = true;
            fungospainel.Visible = false;
            parasitaspainel.Visible = true;
        }
    }
}
