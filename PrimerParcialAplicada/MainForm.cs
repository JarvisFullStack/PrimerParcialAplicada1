using PrimerParcialAplicada.UI.Consultas;
using PrimerParcialAplicada.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialAplicada
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rRegistro registro = new rRegistro();
            registro.MdiParent = this;
            registro.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cVendedor ConsultaVendedor = new cVendedor();
            ConsultaVendedor.MdiParent = this;
            ConsultaVendedor.Show();
        }
    }
}
