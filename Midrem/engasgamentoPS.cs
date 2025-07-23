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
    public partial class engasgamentoPS : UserControl
    {
        public engasgamentoPS()
        {
            InitializeComponent();
        }

        private void kryptonButton14_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            VidMassagemCardiaca massagem = new VidMassagemCardiaca();
            massagem.Show();
        }
    }
}
