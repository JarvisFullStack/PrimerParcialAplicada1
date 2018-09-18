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
    public partial class rRegistro : Form
    {
        public rRegistro()
        {
            InitializeComponent();
        }

        static bool pasoSueldo = true;
        static bool pasoRetencion = true;

        //Inicio de metodos de soporte
        private void LimpiarProvider()
        {
            NombreserrorProvider.Clear();
            PorcientoerrorProvider.Clear();
            SueldoerrorProvider.Clear();
        }
        private void LimpiarCampos()
        {
            LimpiarProvider();
            VendedorIdnumericUpDown1.Value = 0;
            NombrestextBox1.Text = string.Empty;
            SueldotextBox.Text = Convert.ToString(0);
            PorcientotextBox.Text = Convert.ToString(0.0);
            RetenciontextBox.Text = Convert.ToString(0.0);
        }

        private Vendedor LlenarClase()
        {
            Vendedor vendedor = new Vendedor();
            vendedor.VendedorId = (int)VendedorIdnumericUpDown1.Value;
            vendedor.Nombres = NombrestextBox1.Text;
            vendedor.Sueldo = Convert.ToDouble(SueldotextBox.Value);
            vendedor.Porciento = Convert.ToDouble(PorcientotextBox.Value);
            vendedor.Retencion = Convert.ToDouble(RetenciontextBox.Text);
            return vendedor;
        }

        private bool ValidarGuardar()
        {
            bool paso = true;
            if (string.IsNullOrWhiteSpace(NombrestextBox1.Text) || SueldotextBox.Value == 0 || PorcientotextBox.Value == 0)
            {
                if (string.IsNullOrWhiteSpace(NombrestextBox1.Text))
                {
                    NombreserrorProvider.SetError(NombrestextBox1, "Debe llenar este campo");
                    MessageBox.Show("El campo nombre debe llenarse", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if ((SueldotextBox.Value) == 0)
                {
                    NombreserrorProvider.SetError(SueldotextBox, "Debe llenar este campo");
                    MessageBox.Show("El campo Sueldo debe llenarse", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if ((PorcientotextBox.Value) == 0)
                {
                    NombreserrorProvider.SetError(PorcientotextBox, "Debe llenar este campo");
                    MessageBox.Show("El campo Porciento Retencion debe llenarse", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                paso = false;
            }

            return paso;
        }

        private void LlenarCampos(Vendedor vendedor)
        {
            VendedorIdnumericUpDown1.Value = vendedor.VendedorId;
            NombrestextBox1.Text = vendedor.Nombres;
            SueldotextBox.Value = Convert.ToDecimal(vendedor.Sueldo);
            PorcientotextBox.Value = Convert.ToDecimal(vendedor.Porciento);
            RetenciontextBox.Text = Convert.ToString(vendedor.Retencion);
        }

        //fin de metodos de soporte

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuargar_Click(object sender, EventArgs e)
        {
            bool paso = false;
            if (ValidarGuardar())
            {
                Vendedor vendedor = LlenarClase();
                int id = (int)VendedorIdnumericUpDown1.Value;
                if (id == 0)
                {
                    paso = VendedorBLL.Guardar(vendedor);

                }
                else
                {
                    paso = VendedorBLL.Modificar(vendedor);
                }

                if (paso)
                {
                    if (id == 0)
                    {
                        MessageBox.Show("Registro Guardado Correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("Actualizado Guardado Correctamente!");
                    }
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al intentar Guardar o Actualizar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool paso = false;
            int id = (int)VendedorIdnumericUpDown1.Value;
            if (id > 0)
            {
                Vendedor vendedor = VendedorBLL.Buscar(id);
                paso = VendedorBLL.Eliminar(id);
                if (paso)
                {
                    MessageBox.Show("Registro : " + vendedor.Nombres + " Eliminado Correctamente!");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al intentar eliminar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe introducir un id valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            int id = (int)VendedorIdnumericUpDown1.Value;
            if (id > 0)
            {
                Vendedor vendedor = VendedorBLL.Buscar(id);
                if (vendedor != null)
                {
                    LlenarCampos(vendedor);
                    MessageBox.Show("Registro encontrado");



                }
                else
                {
                    MessageBox.Show("Registro no encontrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("ID incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void SueldotextBox_TextChanged(object sender, EventArgs e)
        {
            /*
            string valor = r.Text;
            
            if(valor != string.Empty)
            {
                try
                {
                    Convert.ToDouble(valor);
                    pasoSueldo = true;
                }
                catch (InvalidCastException) {
    
                    pasoSueldo = false;
                }
            }*/


        }

        private void PorcientotextBox_TextChanged(object sender, EventArgs e)
        {
            /*
            string valor = PorcientotextBox.Text;
            double sueldo = 0;
            double porciento= 0;
            double retencion = 0;

            if (valor != string.Empty)
            {
                try
                {
                     Convert.ToDouble(valor);
                    pasoRetencion = true;
                    if(pasoRetencion && pasoSueldo)
                    {
                        sueldo = Convert.ToDouble(r.Text);
                        porciento = Convert.ToDouble(RetenciontextBox.Text);
                        retencion = (sueldo * porciento);
                        RetenciontextBox.Text = Convert.ToString(retencion);
                    }
                    else
                    {
                        
                    }
                }
                catch (InvalidCastException)
                {

                    pasoRetencion = false;
                }
            }
        }*/
        }

        private void PorcientotextBox_ValueChanged(object sender, EventArgs e)
        {
            double sueldo = Convert.ToDouble(SueldotextBox.Value);
            double porciento = Convert.ToDouble(PorcientotextBox.Value);
            porciento /= 100;
            double retencion = (sueldo * porciento);
            RetenciontextBox.Text = Convert.ToString(retencion);
        }

        private void SueldotextBox_ValueChanged(object sender, EventArgs e)
        {
            double sueldo = Convert.ToDouble(SueldotextBox.Value);
            double porciento = Convert.ToDouble(PorcientotextBox.Value);
            porciento /= 100;
            double retencion = (sueldo * porciento);
            RetenciontextBox.Text = Convert.ToString(retencion);
        }
    }
}
