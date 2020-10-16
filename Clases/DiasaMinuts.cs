using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class DiasaMinuts
    {
        public void minutos(double dias)
        {
            double minutos = dias * 1440;
            MessageBox.Show("Resultado: " + minutos .ToString ());
        }
    }
}
