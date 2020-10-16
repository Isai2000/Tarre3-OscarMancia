using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaaObjetos.Formularios
{
    public partial class FrmEdadProm : Form
    {
       
        Clases.EdadPromedio radio = new Clases.EdadPromedio();
        
        public FrmEdadProm()
        {
            InitializeComponent();
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LstMostrar.Items.Add(TxtEdad .Text .Trim ());
            TxtEdad.Clear();
            TxtEdad.Focus();

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double edad;
            int i,sum;
            edad = Convert.ToDouble(LstMostrar.Items.Add(TxtEdad .Text ));
            for (i=1;i<=10;i++)
            {
                
            }

            radio.prom(edad, i);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEdadProm_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLmipiar_Click(object sender, EventArgs e)
        {
            TxtEdad.Clear();
            LstMostrar.Items.Clear();
            TxtEdad.Focus();

        }
    }
}
