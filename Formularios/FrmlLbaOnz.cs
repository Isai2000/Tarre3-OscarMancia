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
    public partial class FrmlLbaOnz : Form
    {
        Clases.LbaOnz shitr = new Clases.LbaOnz();
        public FrmlLbaOnz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lb;
            lb = Convert.ToDouble(TxtLb .Text );

            shitr.onzas(lb);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtLb.Clear();
            TxtLb.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
