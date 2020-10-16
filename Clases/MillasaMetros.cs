using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class MillasaMetros
    {
        public void Millas(double M)
        {
            double rest = M * 1609;
            MessageBox.Show(rest .ToString ());
        }
    }
}
