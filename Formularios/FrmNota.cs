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
    public partial class FrmNota : Form
    {
        Clases.NotaAlumno piña = new Clases.NotaAlumno();

        public FrmNota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double acum, examen;
            string nombre;
            acum = Convert.ToDouble(TxtAcum .Text );
            examen = Convert.ToDouble(TxtNota .Text );

            piña.final(acum , examen, TxtNombre .Text  );
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtAcum.Clear();
            TxtNota.Clear();
            TxtNombre.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
