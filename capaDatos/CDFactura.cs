using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capaEntidades;

namespace capaDatos
{
    public class CDFactura : Conexion
    {
        public int InsertarFactura(CEFactura objF)
        {
            int resultado;

            SqlCommand cmd = new SqlCommand("Sp_InsertarFactura", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", SqlDbType.Int).Value = objF.IdEmpleado;
            cmd.Parameters.AddWithValue("@Fecha", SqlDbType.DateTime).Value = objF.Fecha;

            try
            {
                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de almacenar el registro", ex);
            }
            finally
            {
                DesconectarBD();
                cmd.Dispose();
            }
            return resultado;
        }

        public int ActualizarFactura(CEFactura objF)
        {
            int resultado;

            SqlCommand cmd = new SqlCommand("Sp_ModificarFactura", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdFactura", SqlDbType.Int).Value = objF.IdFactura;
            cmd.Parameters.AddWithValue("NombreCliente", SqlDbType.NVarChar).Value = objF.NombreCliente;
            cmd.Parameters.AddWithValue("RTN", SqlDbType.NVarChar).Value = objF.RTN;
           

            try
            {
                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de actualizar el registro", ex);
            }
            finally
            {
                DesconectarBD();
                cmd.Dispose();
            }
            return resultado;
        }

        public int EliminarFactura(CEFactura objF)
        {
            int resultado;

            SqlCommand cmd = new SqlCommand("Sp_EliminarFactura", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdFactura", SqlDbType.Int).Value = objF.IdFactura;     
            try
            {
                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de Eliminar el registro", ex);
            }
            finally
            {
                DesconectarBD();
                cmd.Dispose();
            }
            return resultado;
        }
        public int MaxFactura()
        {
            int resultado;
            SqlCommand cmd = new SqlCommand("Sp_MaxFactura", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                ConectarBD();
                resultado = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch(Exception ex)
            {
                throw new Exception("Error al tratar de consultar el valor de la factura ingresada", ex);
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
