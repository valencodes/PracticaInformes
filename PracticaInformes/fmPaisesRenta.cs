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
    public partial class fmPaisesRenta : Form
    {
        public fmPaisesRenta()
        {
            InitializeComponent();
        }

        private void paisesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paisesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_paisesDataSet);

        }

        private void fmPaisesRenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_paisesDataSet.paises' Puede moverla o quitarla según sea necesario.
            this.paisesTableAdapter.Fill(this.bd_paisesDataSet.paises);
            // TODO: esta línea de código carga datos en la tabla 'bd_paisesDataSet.paises' Puede moverla o quitarla según sea necesario.
            this.paisesTableAdapter.Fill(this.bd_paisesDataSet.paises);

        }

        private void paisesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.paisesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_paisesDataSet);

        }
    }
}
