using ComponentFactory.Krypton.Toolkit;
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
    public partial class Form2 : KryptonForm
    {
        public Form2()
        {
            string m = "Remédios podem causar efeitos colaterais indesejados, não indicamos automedicação e por isso o programa não divulgará a dose de cada medicamento. Consulte um médico ou farmacêutico antes de usa-los.";
            string c = "ATENÇÃO!";
            MessageBoxButtons b = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(m, c, b);
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            painelPrevencao.Visible = false;
            kryptonButton14.Visible = false;
            doresPainel.Visible = false;
            primeirosSocorrosPainel.Visible = false;
            doresusuario1.Visible = true;
            primeirosSocorros1.Visible = true;
            infecçõespainel.Visible = false;
            DiabetesPainel.Visible = false;
            doençasCardiopainel.Visible=false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton9_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            doresusuario1.Visible = false;
            primeirosSocorros1.Visible = false;
        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            doençasCardiopainel.Visible = true;
            principal.Visible = false;
            kryptonButton14.Visible = true;
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            principal.Visible = false;
            doresPainel.Visible = true;
            doresusuario1.Visible = true;
            primeirosSocorrosPainel.Visible = false;
            primeirosSocorros1.Visible = false;
            kryptonButton14.Visible = true;
            doençasCardiopainel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doresusuario1.Visible = false;
            primeirosSocorros1.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void kryptonButton6_Click_1(object sender, EventArgs e)
        {
            doresusuario1.Visible = false;
            primeirosSocorros1.Visible = false;
            kryptonButton14.Visible = true;
        }

        private void kryptonButton13_Click(object sender, EventArgs e)
        {
            kryptonButton14.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void doresusuario1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton14_Click(object sender, EventArgs e)
        {
            painelPrevencao.Visible = false;
            doençasCardiopainel.Visible = false;
            kryptonButton14.Visible = false;
            principal.Visible = true;
            doresPainel.Visible = false;
            doresusuario1.Visible = false;
            primeirosSocorrosPainel.Visible = false;
            primeirosSocorros1.Visible = false;
            infecçõespainel.Visible = false;
            DiabetesPainel.Visible = false;
        }

        private void kryptonButton6_Click_2(object sender, EventArgs e)
        {
            principal.Visible = false; 
            doresusuario1.Visible = false;
            doresPainel.Visible = false;
            primeirosSocorrosPainel.Visible = true;
            primeirosSocorros1.Visible = true;
            kryptonButton14.Visible = true;
            doençasCardiopainel.Visible = false;
        }

        private void doresusuario1_Load_1(object sender, EventArgs e)
        {

        }

        private void kryptonButton13_Click_1(object sender, EventArgs e)
        {
            doresusuario1.Visible = false;
            primeirosSocorros1.Visible = false;
        }

        private void primeirosSocorros1_Load(object sender, EventArgs e)
        {

        }

        private void doresTipos1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton11_Click_1(object sender, EventArgs e)
        {
            kryptonButton14.Visible = true;
            principal.Visible = false;
            doresPainel.Visible = false;
            doresusuario1.Visible = false;
            primeirosSocorrosPainel.Visible = false;
            primeirosSocorros1.Visible = false;
            infecçõespainel.Visible = true;
            infecções1.Visible = true;
            doençasCardiopainel.Visible = false;
        }

        private void infecções1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            DisfForm disfuncao = new DisfForm();
            disfuncao.Show();
        }

        private void kryptonButton12_Click(object sender, EventArgs e)
        {
            kryptonButton14.Visible = true;
            principal.Visible = false;
            doresPainel.Visible = false;
            doresusuario1.Visible = false;
            primeirosSocorrosPainel.Visible = false;
            primeirosSocorros1.Visible = false;
            infecçõespainel.Visible = false;
            infecções1.Visible = false;
            DiabetesPainel.Visible = true;
            doençasCardiopainel.Visible = false;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            Diabtipo1 diabtipo1 = new Diabtipo1();
            diabtipo1.Show();
        }

        private void kryptonButton15_Click(object sender, EventArgs e)
        {
            Diabtipo2 diabtipo2 = new Diabtipo2();
            diabtipo2.Show();
        }

        private void kryptonButton9_Click_1(object sender, EventArgs e)
        {
            hipertensaoForm hipert = new hipertensaoForm();
            hipert.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            inflamaForm inflama = new inflamaForm();
            inflama.Show();
        }

        private void kryptonButton2_Click_1(object sender, EventArgs e)
        {
            OsteoForm osteo = new OsteoForm();
            osteo.Show();
        }

        private void kryptonButton8_Click_1(object sender, EventArgs e)
        {

        }

        private void diu_Click(object sender, EventArgs e)
        {
            hipertensaoForm hipert = new hipertensaoForm();
            hipert.Show();
        }

        private void kryptonButton8_Click_2(object sender, EventArgs e)
        {
            InfartoForm infarto = new InfartoForm();
            infarto.Show();
        }

        private void kryptonButton5_Click_1(object sender, EventArgs e)
        {
            insufCardio insuf = new insufCardio();
            insuf.Show();
        }

        private void kryptonButton16_Click(object sender, EventArgs e)
        {
            painelPrevencao.Visible = true;
            doençasCardiopainel.Visible = false;
        }
    }
}
