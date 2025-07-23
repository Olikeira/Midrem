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
    public partial class doresusuario : UserControl
    {
        public doresusuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            RemediosDorCabeça dor = new RemediosDorCabeça();
            dor.Show();
        }
    }
}
