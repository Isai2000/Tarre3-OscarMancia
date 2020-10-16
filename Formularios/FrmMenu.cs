using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Formularios
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios.FrmSuma toyota = new Formularios.FrmSuma();
            toyota.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formularios.FrmPromedio ford = new Formularios.FrmPromedio();
            ford.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formularios.FrmConvertirMam nissan = new Formularios.FrmConvertirMam();
            nissan.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formularios.FrmMaKm stick = new Formularios.FrmMaKm();
            stick.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formularios.FrmLpsaDolar chair = new Formularios.FrmLpsaDolar();
            chair.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Formularios.FrmLpsaEuros onix = new Formularios.FrmLpsaEuros();
            onix.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Formularios.FrmLlantas surh = new Formularios.FrmLlantas();
            surh.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Formularios.FrmDiastrab psi = new Formularios.FrmDiastrab();
            psi.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Formularios.FrmSalario2 sol = new Formularios.FrmSalario2();
            sol.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Formularios.FrmGalt lader = new Formularios.FrmGalt();
            lader.ShowDialog();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Formularios.FrmPulaCm guitar = new Formularios.FrmPulaCm();
            guitar.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Formularios.FrmAumento phone = new Formularios.FrmAumento();
            phone.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Formularios.FrmDiasAMinut red = new Formularios.FrmDiasAMinut();
            red.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Formularios.FrmlLbaOnz prs = new Formularios.FrmlLbaOnz();
            prs.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Formularios.FrmDoble smook = new Formularios.FrmDoble();
            smook.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Formularios.FrmEdadProm promedio = new Formularios.FrmEdadProm();
            promedio.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Formularios.FrmCubo wine = new Formularios.FrmCubo();
            wine.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Formularios.FrmMetrosaPies bote = new Formularios.FrmMetrosaPies();
            bote.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Formularios.FrmTotalpCons naranja = new Formularios.FrmTotalpCons();
            naranja.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Formularios.FrmNota work = new Formularios.FrmNota();
            work.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Formularios.FrmSemaMinut marvel = new Formularios.FrmSemaMinut();
            marvel.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Formularios.FrmDobleNum mac = new Formularios.FrmDobleNum();
            mac.ShowDialog();
        }
    }
}
