using Microsoft.Reporting.WinForms;
using System;
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
    public partial class fmPaisesAlfabeticamente : Form
    {
        public fmPaisesAlfabeticamente()
        {
            InitializeComponent();
        }

        private void fmPaisesAlfabeticamente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_paisesDataSet.paises' Puede moverla o quitarla según sea necesario.
            this.paisesTableAdapter.Fill(this.bd_paisesDataSet.paises);
           
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            // using Microsoft.Reporting.WinForms; // Es necesaria esta librería
            ReportParameter p = new ReportParameter("Parametro1", tbNombre.Text,false);
            reportViewer.LocalReport.SetParameters(p);
            this.reportViewer.RefreshReport();
        }

        private void tbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {  // using Microsoft.Reporting.WinForms; // Es necesaria esta librería
                ReportParameter p = new ReportParameter("Parametro1", tbNombre.Text, false);
                reportViewer.LocalReport.SetParameters(p);
                this.reportViewer.RefreshReport();
            }
           
        }

        private void paisesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paisesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_paisesDataSet);

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
