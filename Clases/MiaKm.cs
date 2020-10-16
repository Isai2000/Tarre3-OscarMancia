using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class MiaKm
    {
        public void Kilometros(double M)
        {
            double rest = M * 1.609;
            MessageBox.Show("El resultado es: " + rest .ToString ());
        }
    }
}
