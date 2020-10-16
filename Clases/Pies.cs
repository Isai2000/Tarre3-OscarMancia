using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class Pies
    {
        public void pies(double m)
        {
            double pies = m * 3.281;
            MessageBox.Show("El resultado es: " + pies .ToString ());
        }
    }
}
