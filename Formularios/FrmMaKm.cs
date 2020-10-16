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
    public partial class FrmMaKm : Form
    {
        Clases.MiaKm hans = new Clases.MiaKm();
        public FrmMaKm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int M;
            M = Convert.ToInt16(TxtMillas.Text);

            hans.Kilometros(M);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtMillas.Clear();
            TxtMillas.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
