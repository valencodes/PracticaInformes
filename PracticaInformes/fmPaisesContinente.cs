using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PracticaInformes
{
    public partial class fmPaisesContinente : Form
    {
        public fmPaisesContinente()
        {
            InitializeComponent();
        }

        private void paises1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paises1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_paisesDataSet);

        }

        private void fmPaisesContinente_Load(object sender, EventArgs e)
        {
            cbContinentes.SelectedIndex = 0;
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            paises1TableAdapter.Fill(bd_paisesDataSet.paises1, cbContinentes.Text);
            reportViewer1.RefreshReport();
        }
    }
}
