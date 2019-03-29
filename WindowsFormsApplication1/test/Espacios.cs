﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class Espacios : Estilo
    {
        public Espacios()
        {
            InitializeComponent();
        }

        private void Espacios_Load(object sender, EventArgs e)
        {
            bindingSourceInstalaciones.DataSource = BD.Instalacions.SelectAllInstalaciones();
            bindingSourceEspacios.DataSource = BD.EspaciosORM.SelectAllInstalaciones();
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
            Instalacion int2;

            if (comboBox1.SelectedItem != null)
            {
                int2 = (Instalacion)comboBox1.SelectedItem;
                bindingSource1.DataSource = int2.Espacio.ToList();
            }
        }

        private void comboBoxEsport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
