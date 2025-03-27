using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class D_Categorias
    {
        //muestreo de informacion
        public DataTable Listado_ca(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Listado_ca", SQLCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SQLCon.Open();
                Resultado = comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open)
                {
                    SQLCon.Close();
                }
            }
        }

        public string Guardar_ca(int nOpcion, Categorias oCa)
        {
            string rto = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Guardar_ca", sqlCon);
                comando.CommandType = CommandType.StoredProcedure; //asigno una caracteristica
                comando.Parameters.Add("@nOpcion",SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@nCodigo_ca", SqlDbType.Int).Value = oCa.Codigo_ca;
                comando.Parameters.Add("@cDescripcion_ca", SqlDbType.VarChar).Value = oCa.Descripcion_ca;
                sqlCon.Open();
                rto = comando.ExecuteNonQuery() == 1 ? "OK" : "NO SE PUDO REGISTRAR LOS DATOS";
            }
            catch (Exception ex) 
            {
                rto = ex.Message;
            }
            finally
            {
                if(sqlCon.State == ConnectionState.Open) 
                { 
                    sqlCon.Close();
                }
            }
            return rto;
        }
    }
}
