using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class Galt
    {
        public void Litros(double galones)
        {
            double litros = galones * 3.785;
            MessageBox.Show("El resultado es: " + litros .ToString ());
        }
    }
}
