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
    public partial class FrmDiasAMinut : Form
    {
        Clases.DiasaMinuts withe = new Clases.DiasaMinuts();
        public FrmDiasAMinut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dias;
            dias = Convert.ToDouble(TxtDias .Text );

            withe.minutos(dias);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtDias.Clear();
            TxtDias.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
                
        }
    }
}
