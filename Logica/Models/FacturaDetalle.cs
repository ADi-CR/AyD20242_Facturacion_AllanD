using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public partial class FacturaDetalle
    {
        //una clase parcial está pensada en ser usada como parte de
        //de algo más grande, no de forma independiente 

        public decimal CantidadFacturada { get; set; }

        public decimal PrecioFacturado { get; set; }

        public Producto MiProducto { get; set; }

        public FacturaDetalle()
        {
            MiProducto = new Producto();
        }



    }
}
