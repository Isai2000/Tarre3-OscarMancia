using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class PulgaCemtn
    {
        public void cambiar(double Pulg)
        {
            double cm = Pulg * 2.54;
            MessageBox.Show("El resultado es: " + cm .ToString ());
        }
    }
}
