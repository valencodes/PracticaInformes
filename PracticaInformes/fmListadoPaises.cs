﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaInformes
{
    public partial class fmListadoPaises : Form
    {
        public fmListadoPaises()
        {
            InitializeComponent();
        }

        private void fmListadoPaises_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_paisesDataSet.paises' Puede moverla o quitarla según sea necesario.
            this.paisesTableAdapter.Fill(this.bd_paisesDataSet.paises);
            // TODO: esta línea de código carga datos en la tabla 'bd_paisesDataSet.paises' Puede moverla o quitarla según sea necesario.
            this.paisesTableAdapter.Fill(this.bd_paisesDataSet.paises);

            this.reportViewer.RefreshReport();
            this.reportViewer.RefreshReport();
            this.reportViewer.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla
            // 'bd_paisesDataSet.paises' Puede moverla o quitarla según sea necesario.
            this.paisesTableAdapter.Fill(this.bd_paisesDataSet.paises);
            this.reportViewer.RefreshReport();//muestra el ReportViewer 
        }

        private void paisesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paisesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_paisesDataSet);

        }

        private void paisesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.paisesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_paisesDataSet);

        }
    }
}
