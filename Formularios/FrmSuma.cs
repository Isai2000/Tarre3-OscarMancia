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
    public partial class FrmSuma : Form
    {
        Clases.Suma fender = new Clases.Suma();
        public FrmSuma()
        {
            InitializeComponent();
        }

        private void FrmSuma_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int a, b, c;

            a = Convert.ToInt16(TxtN1.Text);
            b = Convert.ToInt16(TxtN2.Text);
            c = Convert.ToInt16(TxtN3.Text);

            fender.suma(a, b, c);
        }

        private void BtnLimo_Click(object sender, EventArgs e)
        {
            TxtN1.Clear();
            TxtN2.Clear();
            TxtN3.Clear();
            TxtN1.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
