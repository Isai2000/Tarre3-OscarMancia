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
    public partial class FrmSemaMinut : Form
    {
        Clases.Minutos old = new Clases.Minutos();
        public FrmSemaMinut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double semana;
            semana = Convert.ToDouble(TxtSemanas .Text );

            old.minutos(semana);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtSemanas.Clear();
            TxtSemanas.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
