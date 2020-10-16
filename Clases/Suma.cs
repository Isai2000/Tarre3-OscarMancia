using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProgramacionOrientadaaObjetos.Clases
{
    class Suma
    {
        public void suma(int a, int b, int c)
        {
            int rest = a + b + c;
            MessageBox.Show(rest .ToString());
        }
    }
}
