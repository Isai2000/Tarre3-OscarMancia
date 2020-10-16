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
    public partial class FrmCubo : Form
    {
        Clases.Cubo grectch = new Clases.Cubo();
        public FrmCubo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1;
            n1 = Convert.ToDouble(TxtN1 .Text );

            grectch.cubo(n1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtN1.Clear();
            TxtN1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
