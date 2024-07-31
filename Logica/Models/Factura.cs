using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Factura
    {
        public int FacturaID { get; set; }
        public int NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string? Notas { get; set; }

        //composiciones
        public VentaTipo MiTipoVenta { get; set; }
        public Cliente MiCliente { get; set; }
        public Usuario MiUsuario { get; set; }

        //cuando queremos hacer una composición múltiple, por ejemplo
        //con un detalle como el de la factura (que es una tabla
        //de muchos a muchos) entonces la creamos mediante un List
        public List<FacturaDetalle> ListaProductos { get; set; }

        public Factura()
        {
            MiTipoVenta = new VentaTipo();
            MiCliente = new Cliente();
            MiUsuario = new Usuario();

            ListaProductos = new List<FacturaDetalle>();
        }

        public bool Crear()
        {
            bool Ret = false;

            return Ret;
        }

        public Factura ConsultarPorID(int pID)
        {
            Factura Ret = new Factura();

            return Ret;
        }

        public DataTable ListarPorCliente(int pIDCliente)
        {
            DataTable Ret = new DataTable();

            return Ret;
        }

        public DataTable ListarPorRangoDeFechas(DateTime pFechaInicio,
                                                DateTime pFechaFinal)
        {
            DataTable Ret = new DataTable();

            return Ret;
        }

        public DataTable ListarPorTipo(int pTipoID)
        {
            DataTable Ret = new DataTable();

            return Ret;
        }







    }
}
