using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class TotalpLlantas
    {
        public void steel(double cant, double precu)
        {
            double steel = cant * precu;
            MessageBox.Show("SU TOTAL ES: " + steel .ToString ());

        }
    }
}
