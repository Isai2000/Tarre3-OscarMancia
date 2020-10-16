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
    public partial class FrmTotalpCons : Form
    {
        Clases.MetroCuadrado snow = new Clases.MetroCuadrado();
        public FrmTotalpCons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cant, valor;
            cant = Convert.ToDouble(TxtCant .Text );
            valor = Convert.ToDouble(TxtValor .Text );

            snow.metro(cant , valor );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtCant.Clear();
            TxtValor.Clear();
            TxtCant.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
