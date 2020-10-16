using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class MetroCuadrado
    {
        public void metro(double cant, double valor)
        {
            double metro = cant * valor;
            MessageBox.Show("Total a pagar: " + metro .ToString ());
        }
    }
}
