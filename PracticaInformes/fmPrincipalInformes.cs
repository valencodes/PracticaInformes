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
    public partial class fmPrincipalInformes : Form
    {
        public fmPrincipalInformes()
        {
            InitializeComponent();
        }

        private void fmPrincipalInformes_Load(object sender, EventArgs e)
        {

        }

        private void btPaises_Click(object sender, EventArgs e)
        {
            new fmListadoPaises().ShowDialog();
        }

        private void btPaisesRenta_Click(object sender, EventArgs e)
        {
            new fmPaisesRenta().ShowDialog();
        }

        private void btPaisesRentaContinentes_Click(object sender, EventArgs e)
        {
            new fmRentaContinente().ShowDialog();
        }

        private void btPaisesAlfabeticamente_Click(object sender, EventArgs e)
        {
            new fmPaisesAlfabeticamente().ShowDialog();
        }

        private void btPaises1Continente_Click(object sender, EventArgs e)
        {
            new fmPaisesContinente().ShowDialog();
        }
    }
}
