using PrimerParcialAplicada.BLL;
using PrimerParcialAplicada.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialAplicada.UI.Registros
{
    public partial class rMeta : Form
    {
        public rMeta()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MetaIdnumericUpDown1.Value = 0;
            DescripciontextBox1.Text = "";
            CuotaNumericUpDown.Value = 1;
            
        }

        private void btnGuargar_Click(object sender, EventArgs e)
        {
            RepositorioBase<Meta> repositorio = new RepositorioBase<Meta>();
            Meta meta = new Meta();
            meta.Descripcion = DescripciontextBox1.Text;
            meta.Cuota = Convert.ToDouble(CuotaNumericUpDown.Value);
            if (repositorio.Guardar(meta))
            {
                MessageBox.Show("Meta Guardada Correctamente");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RepositorioBase<Meta> repositorio = new RepositorioBase<Meta>();
            Meta meta = repositorio.Buscar((int)MetaIdnumericUpDown1.Value);
            if (meta != null)
            {
                DescripciontextBox1.Text = meta.Descripcion;
                CuotaNumericUpDown.Value = Convert.ToDecimal(meta.Cuota);
                MessageBox.Show("Registro encontrado!");

            }
            


        }
    }
}
