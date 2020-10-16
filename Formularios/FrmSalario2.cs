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
    public partial class FrmSalario2 : Form
    {
        Clases.Salarioextra walls = new Clases.Salarioextra();
        public FrmSalario2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dias, horas, valor;
            dias = Convert.ToDouble(TxtDias .Text );
            horas = Convert.ToDouble(TxtHoras .Text );
            valor = Convert.ToDouble(TxtValor .Text );

            walls.funk(dias , horas , valor );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtDias.Clear();
            TxtHoras.Clear();
            TxtValor.Clear();
            TxtDias.Focus();
        }
    }
}
