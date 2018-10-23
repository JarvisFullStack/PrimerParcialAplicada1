using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialAplicada.Entidades
{
    public class Meta
    {
        [Key]
        public int MetaId { get; set; }
        public string Descripcion { get; set; }//colocar colgate familiar
        public double Cuota { get; set; }


        public Meta()
        {
            MetaId = 0;
            Descripcion = string.Empty;
            Cuota = 0.0;
        }


    }
}
