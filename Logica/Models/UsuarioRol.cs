using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UsuarioRol
    {
        //atributos simples 
        public int UsuarioTipoID { get; set; }

        public string Rol { get; set; }

        //funciones
        public DataTable Listar()
        { 
            DataTable Ret = new DataTable();
            //todo  el codigo funcional estará acá según indique 
            //la secuencia 

            return Ret;
        }

    }

}
