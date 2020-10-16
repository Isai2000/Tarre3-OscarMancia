using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class Aumento
    {
        public void aumentar(double sal, double aumn, string nombre)
        {
            aumn = aumn / 100;
            double aumentar = (sal * aumn) + sal;
            MessageBox.Show("Su nuevo salario del empleado " + nombre +" es: " +aumentar.ToString ());
        }
    }
}
