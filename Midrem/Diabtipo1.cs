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
    public partial class Diabtipo1 : KryptonForm
    {
        public Diabtipo1()
        {
            InitializeComponent();
        }

        private void Diabtipo1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label2.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            kryptonButton14.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label3.Visible=true;
            label2.Visible = false;
            label1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            kryptonButton14.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            kryptonButton14.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton14_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label3.Visible = false;
            label2.Visible = true;
            label1.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            kryptonButton14.Visible = false;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
