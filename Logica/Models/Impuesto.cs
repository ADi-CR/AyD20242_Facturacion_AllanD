using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public  class Impuesto
    {
        public int ImpuestoID { get; set; }
        public string? ImpuestoNombre { get; set; }
        public string? CodigoImpuesto { get; set; }
        public decimal TasaImpuesto { get; set; }

        public DataTable Listar()
        {
            DataTable Ret = new DataTable();

            return Ret;
        }

    }
}
