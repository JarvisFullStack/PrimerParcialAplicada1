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

namespace PrimerParcialAplicada.UI.Consultas
{
    public partial class cVendedor : Form
    {
        public cVendedor()
        {
            InitializeComponent();
        }

        private void cVendedor_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Lista de vendedores
            var lista = new List<Vendedor>();
            RepositorioBase<Vendedor> repositorio = new RepositorioBase<Vendedor>();
            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://todos
                        lista = repositorio.GetList(x=>true);
                        break;
                    case 1://ID

                        int id = 0;
                        try
                        {
                             id = Convert.ToInt32(CriterioTextBox.Text);
                            lista = repositorio.GetList(x => x.VendedorId == id);
                        }
                        catch (FormatException) { MessageBox.Show("Introduzca un criterio valido en base al filtro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        
                        break;
                    case 2://Nombres
                        lista = repositorio.GetList(x => x.Nombres.Contains(CriterioTextBox.Text));
                        break;
                    case 3://Sueldo
                        Double sueldo = 0.0;
                        try
                        {
                            sueldo = Convert.ToDouble(CriterioTextBox.Text);                           
                            lista = repositorio.GetList(x => x.Sueldo == sueldo);
                        }
                        catch (FormatException) { MessageBox.Show("Introduzca un criterio valido en base al filtro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }                        
                        break;
                    case 4://Retencion
                        Double retencion = 0.0;
                        try
                        {
                            retencion = Convert.ToDouble(CriterioTextBox.Text);
                            lista = repositorio.GetList(x => x.Retencion == retencion);                        
                        }
                        catch (FormatException) { MessageBox.Show("Introduzca un criterio valido en base al filtro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        
                        break;
                    case 5://Porciento
                        Double porciento = 0.0;
                        try
                        {
                            porciento = Convert.ToDouble(CriterioTextBox.Text);
                            lista = repositorio.GetList(x => x.Porciento == porciento);
                        }
                        catch (FormatException) { MessageBox.Show("Introduzca un criterio valido en base al filtro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }                        
                        break;
                }

                lista = lista.Where(x => x.Fecha.Date >= DesdeDateTimePicker.Value.Date && x.Fecha <= HastaDateTimePicker.Value.Date).ToList(); ;
            }
            else
            {
                lista = repositorio.GetList(x=>true);
            }

            vendedorBindingSource.DataSource = null;
            vendedorBindingSource.DataSource = lista;
        }
    }
}
