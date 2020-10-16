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
    public partial class FrmPromedio : Form
    {
        Clases.Promedio squier = new Clases.Promedio();
        public FrmPromedio()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4;
            n1 = Convert.ToInt16(TxtN1.Text);
            n2 = Convert.ToInt16(TxtN2 .Text );
            n3 = Convert.ToInt16(TxtN3.Text);
            n4 = Convert.ToInt16(TxtN4.Text);

            squier.promedio(n1, n2, n3, n4);
        }

        private void BtnLimo_Click(object sender, EventArgs e)
        {
            TxtN1.Clear();
            TxtN2.Clear();
            TxtN3.Clear();
            TxtN4.Clear();
            TxtN1.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
