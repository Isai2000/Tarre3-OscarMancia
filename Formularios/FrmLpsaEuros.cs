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
    public partial class FrmLpsaEuros : Form
    {
        Clases.Euros jhs = new Clases.Euros();
        public FrmLpsaEuros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lps;
            lps = Convert.ToDouble(TxtLps .Text );

            jhs.marco(lps);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtLps.Clear();
            TxtLps.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
