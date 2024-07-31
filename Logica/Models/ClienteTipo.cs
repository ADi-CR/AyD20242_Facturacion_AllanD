using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ClienteTipo
    {

        public int ClienteTipoID { get; set; }

        public string? Descripcion { get; set; }

        public DataTable Listar()
        {
            DataTable Ret = new DataTable();

            return Ret;
        }

    }
}
