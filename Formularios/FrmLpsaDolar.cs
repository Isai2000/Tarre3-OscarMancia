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
    public partial class FrmLpsaDolar : Form
    {
        Clases.Lempiras gol = new Clases.Lempiras();
        public FrmLpsaDolar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Lps;
            Lps = Convert.ToInt16(TxtLps .Text );

            gol.dolar(Lps);
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
