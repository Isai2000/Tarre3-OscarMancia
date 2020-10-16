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
    public partial class FrmLlantas : Form
    {
        Clases.TotalpLlantas tablet = new Clases.TotalpLlantas();
        public FrmLlantas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cant, precu;
            cant = Convert.ToDouble(TxtCant.Text);
            precu = Convert.ToDouble(TxtPrecu .Text );

            tablet.steel(cant , precu );

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtCant.Clear();
            TxtPrecu.Clear();
            TxtCant.Focus();
        }
    }
}
