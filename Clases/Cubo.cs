using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class Cubo
    {
        public void cubo(double n1)
        {
            double cubo = n1 * n1 * n1;
            MessageBox.Show("El resultado es: " + cubo .ToString ());
        }
    }
}
