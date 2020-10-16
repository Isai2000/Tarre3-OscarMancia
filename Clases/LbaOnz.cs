using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class LbaOnz
    {
        public void onzas(double lb)
        {
            double onzas = lb * 16;
            MessageBox.Show("El resultado es: " + onzas .ToString ());
        }
    }
}
