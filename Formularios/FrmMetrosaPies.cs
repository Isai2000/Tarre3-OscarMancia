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
    public partial class FrmMetrosaPies : Form
    {
        Clases.Pies shield = new Clases.Pies();
        public FrmMetrosaPies()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtMetros.Clear();
            TxtMetros.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1;
            n1 = Convert.ToDouble(TxtMetros .Text );

            shield.pies(n1);
        }
    }
}
