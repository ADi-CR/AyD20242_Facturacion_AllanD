using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {
        //atributos simples 
        public int UsuarioId { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Identificacion { get; set; }
        public string? Correo { get; set; }
        public string? Contrasennia { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Notas { get; set; }
        public bool Activo { get; set; }

        //atributos complejos
        public UsuarioRol MiUsuarioRol { get; set; }

        //constructores
        public Usuario()
        {
            MiUsuarioRol = new UsuarioRol();
        }

        //funciones y métodos (operaciones)
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
                
        public bool ConsultarPorCorreo()
        {
            bool Ret = false;

            //1.3.1 y 1.3.2
            Services.Conexion MiCnn = new Services.Conexion();

            //1.3.3 y 1.3.4
            DataTable dt = MiCnn.EjecutarSelect("SPUsuarioConsultarPorCorreo");

            //1.3.5
            if (dt != null && dt.Rows.Count > 0)
            {
                Ret = true;
            }
            
            return Ret;
        }

        public bool ConsultarPorCedula()
        {
            bool Ret = false;

            return Ret;
        }

        public DataTable ListarActivos()
        { 
            DataTable Ret = new DataTable();

            return Ret;
        }

        public DataTable ListarInactivos()
        {
            DataTable Ret = new DataTable();

            return Ret;
        }





    }
}
