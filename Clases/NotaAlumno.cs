using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class NotaAlumno
    {
        public void final(double acum, double examen, string nombre)
        {
            double final = acum + examen;

            MessageBox.Show("El alumno "+ nombre  + " Tiene: " + final .ToString ());
        }
    }
}
