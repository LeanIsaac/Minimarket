using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Datos;

namespace Negocio
{
    public class Categorias
    {
        public static DataTable Listado_ca(String cTexto)
        {
            D_Categorias Datos = new D_Categorias();
            return Datos.Listado_ca(cTexto);
        }
    }
}
