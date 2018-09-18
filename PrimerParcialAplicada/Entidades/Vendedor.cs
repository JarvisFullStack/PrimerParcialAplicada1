using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialAplicada.Entidades
{
    public class Vendedor
    {
        [Key]
        public int VendedorId { get; set; }
        public string Nombres { get; set; }
        public double Sueldo { get; set; }
        public double Retencion { get; set; }
        public double Porciento { get; set; }

        public Vendedor()
        {
            VendedorId = 0;
            Nombres = String.Empty;
            Sueldo = 0;
            Retencion = 0;
            Porciento = 0;

        }

        public Vendedor(int vendedorId, string nombres, double sueldo, double retencion, double porciento)
        {
            VendedorId = vendedorId;
            Nombres = nombres;
            Sueldo = sueldo;
            Retencion = retencion;
            Porciento = porciento;
        }
    }
}
