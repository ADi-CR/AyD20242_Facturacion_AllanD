using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Services
{
    public class Conexion
    {
        //esta clase sirve como puente entre las funcionalidad de los
        //modelos y la capa de datos. Normalmente procedimientos almacenados,
        //pero también consultas SQL directas. 


        public string? CadenaDeConexion { get; set; }

        public List<SqlParameter> ListaDeParametros { get; set; }

        public Conexion()
        {
            ListaDeParametros = new List<SqlParameter>();
        }

        public DataTable EjecutarSelect(string NombreProcedimientoAlmacenado)
        { 
            DataTable Ret = new DataTable();

            //los pasos de 4 niveles que se ven en la secuencia
            //no se muestran acá 

            //1.3.3.1 de SQ Consultar Usuario por correo
            //acá estaría el código para llamar al SP en la Capa de Datos 

            //.....

            //1.3.3.2 de SQ Consultar Usuario por correo
            //se captura el resultado en la variable Ret. 
            //...

            return Ret;
        }

        public int EjecutarInsertUpdateDelete(string NombreProcedimientoAlmacenado)
        { 
            int Ret = 0;

            return Ret;
        }


    }
}
