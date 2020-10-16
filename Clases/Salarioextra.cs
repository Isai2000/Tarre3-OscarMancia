using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class Salarioextra
    {
        public void funk(double dias, double horas, double extra)
        {
            double funk = dias * horas * extra;
            MessageBox.Show(funk .ToString ());
        }
    }

}
