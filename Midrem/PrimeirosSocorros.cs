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
    public partial class PrimeirosSocorros : UserControl
    {
        public PrimeirosSocorros()
        {
            InitializeComponent();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            engasgamentoForm engasga = new engasgamentoForm();
            engasga.Show();
        }

        private void PrimeirosSocorros_Load(object sender, EventArgs e)
        {
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            paradaCard paradacardio = new paradaCard();
            paradacardio.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            cortesform cortes = new cortesform();
            cortes.Show();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            queimaduras queima = new queimaduras();
            queima.Show();
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            ConvulsForm cardio = new ConvulsForm();
            cardio.Show();
        }
    }
}
