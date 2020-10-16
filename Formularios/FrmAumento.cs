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
    public partial class FrmAumento : Form
    {
        Clases.Aumento luna = new Clases.Aumento();
        public FrmAumento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salb, aument;
            string nombre;

            salb = Convert.ToDouble(TxtSalario .Text );
            aument = Convert.ToDouble(TxtAument .Text );

            luna.aumentar(salb ,aument,TxtNombre.Text );
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtAument.Clear();
            TxtSalario.Clear();
            TxtNombre.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
