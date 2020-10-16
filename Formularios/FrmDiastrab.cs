﻿using System;
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
    public partial class FrmDiastrab : Form
    {
        Clases.Trabajo limon = new Clases.Trabajo();
        public FrmDiastrab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dias, valor;
            dias = Convert.ToDouble(TxtDiastrab .Text );
            valor = Convert.ToDouble(TxtValorD .Text );

            limon.trabajo(dias, valor);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtDiastrab.Clear();
            TxtValorD.Clear();
            TxtDiastrab.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
