using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class CDProducto : Conexion  
    {
        public string NombreProducto(int id)
        {
            SqlCommand cmd = new SqlCommand("Sp_NombreProducto", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", SqlDbType.Int).Value = id;
            try
            {
                ConectarBD();
                return cmd.ExecuteScalar().ToString();
            }
            catch(Exception ex)
            {
                throw new Exception("Error al encontrar nombre correspondiente al id", ex);
            }
            finally
            {
                DesconectarBD();
                cmd.Dispose();
            }
        }
        public decimal PrecioProducto(int id)
        {
            SqlCommand cmd = new SqlCommand("Sp_PrecioProducto", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", SqlDbType.Int).Value = id;
            try
            {
                ConectarBD();
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al encontrar precio correspondiente al id", ex);
            }
            finally
            {
                DesconectarBD();
                cmd.Dispose();
            }
        }
    }
}
