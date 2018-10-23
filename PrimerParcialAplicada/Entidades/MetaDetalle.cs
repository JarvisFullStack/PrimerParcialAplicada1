using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialAplicada.Entidades
{
    public class MetaDetalle
    {
        [Key]
        public int MetaDetalleId { get; set; }
        public int MetaId { get; set; }
        public int VendedorId { get; set; }
        public Double Cuota { get; set; }

        public MetaDetalle()
        {
            MetaDetalleId = 0;
            MetaId = 0;
            VendedorId = 0;
            Cuota = 0;
        }
    }
}
