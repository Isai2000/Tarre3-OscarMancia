using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Clases
{
    class Promedio
    {
        public void promedio(int n1, int n2,int n3, int n4)
        {
            int prom = (n1 + n2 + n3 + n4) / 4;
            MessageBox.Show(prom .ToString ());
        }
    }
}
