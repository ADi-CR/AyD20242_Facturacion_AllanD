using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string? ClienteNombre { get; set; }
        public string? Identificacion { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Notas { get; set; }
        public bool Activo { get; set; }

        public VentaTipo MiTipoVenta { get; set; }

        public ClienteTipo MiTipoCliente { get; set; }

        public Cliente()
        {
            MiTipoCliente = new ClienteTipo();
            MiTipoVenta = new VentaTipo();

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

        public bool ConsultarPorIdentificacion(string pIdentificacion)
        {
            bool Ret = false;

            return Ret;
        }

        public DataTable Listar(bool pVerActivos = true)
        {
            DataTable Ret = new();

            return Ret;
        }


    }
}
