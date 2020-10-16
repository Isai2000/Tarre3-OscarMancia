using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class Lempiras
    {
        public void dolar(double Lemp)
        {
            double Dolar = Lemp * 0.04;
            
            MessageBox.Show("El resultado es: " + Dolar .ToString ());
        }
    }
}
