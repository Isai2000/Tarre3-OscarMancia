using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class Minutos
    {
        public void minutos(double semana)
        {
            double minutos = semana * 10080;
            MessageBox.Show("Resultado: " + minutos .ToString () + " Minutos");
        }
    }
}
