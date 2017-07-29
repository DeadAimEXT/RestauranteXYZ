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
    public class CDDetalleFactura : Conexion
    {
        public int InsertarDFactura(CEDetalleFactura objDf)
        {
            int resultado;
            SqlCommand cmd = new SqlCommand("Sp_InsertarDFactura", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFactura", SqlDbType.NVarChar).Value = objDf.IdFactura;
            cmd.Parameters.AddWithValue("@IdProducto", SqlDbType.NVarChar).Value = objDf.IdProducto;
            cmd.Parameters.AddWithValue("@Cantidad", SqlDbType.VarChar).Value = objDf.Cantidad;
            
            try
            {
                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de almacenar", ex);
            }
            finally
            {
                DesconectarBD();
                cmd.Dispose();
            }
            return resultado;
        }
    }
}
