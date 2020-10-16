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
    public partial class FrmGalt : Form
    {
        Clases.Galt convertidor = new Clases.Galt();
        public FrmGalt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gal;
            gal = Convert.ToDouble(TxtGal .Text );

            convertidor.Litros(gal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtGal.Clear();
            TxtGal.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
