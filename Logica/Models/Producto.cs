using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string? ProductoNombre { get; set; }
        public string? CodigoBarras { get; set; }
        public decimal CantidadStock { get; set; }
        public decimal Precio { get; set; }
        public string? Marca { get; set; }
        public string? Notas { get; set; }
        public bool Activo { get; set; }

        public ProductoCategoria MiCategoria { get; set; }
        public Impuesto MiImpuesto { get; set; }

        public Producto()
        {
            MiCategoria = new ProductoCategoria();
            MiImpuesto = new Impuesto();
        }

        public bool Agregar()
        {
            bool Ret = false;

            return Ret;
        }

        public bool Editar()
        {
            bool Ret = false;

            return Ret;
        }

        public bool Eliminar()
        {
            bool Ret = false;

            return Ret;
        }

        public bool ConsultarPorID()
        {
            bool Ret = false;

            return Ret;
        }

        public bool ConsultarPorCodigoDeBarras(string pCodigoBarras)
        {
            bool Ret = false;

            return Ret;
        }

        public bool ConsultarPorNombre(string pNombreProducto)
        {
            bool Ret = false;

            return Ret;
        }

        public DataTable Listar(bool pVerActivos = true)
        { 
            DataTable Ret = new DataTable();

            return Ret;
        }

    }
}
