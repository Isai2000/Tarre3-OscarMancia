using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class Euros
    {
        public void marco(double lps)
        {
            double euros = lps * 0.034;
            MessageBox.Show("El resultado es: " + euros .ToString ());
        }
    }
}
