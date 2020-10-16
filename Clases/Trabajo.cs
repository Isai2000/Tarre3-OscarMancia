using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class Trabajo
    {
        public void trabajo(double dias, double valor)
        {
            double salario = dias * valor;
            MessageBox.Show("Su salario es: " + salario .ToString ());
        }
    }
}
