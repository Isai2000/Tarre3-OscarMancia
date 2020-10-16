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
    public partial class FrmDoble : Form
    {
        Clases.Cudrado tv = new Clases.Cudrado();
        public FrmDoble()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1;
            n1 = Convert.ToDouble(TxtDoble .Text );

            tv.doble(n1 );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtDoble.Clear();
            TxtDoble.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
