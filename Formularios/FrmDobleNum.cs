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
    public partial class FrmDobleNum : Form
    {
        Clases.Doble star = new Clases.Doble();
        public FrmDobleNum()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtN1.Clear();
            TxtN1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1;
            n1 = Convert.ToDouble(TxtN1 .Text );

            star.dog(n1);
        }
    }
}
