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
    public class CDMesa : Conexion
    {
        public int InsertarMesa(CEMesa objM)
        {
            int resultado;
            SqlCommand cmd = new SqlCommand("Sp_InsertarMesa", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Estado", SqlDbType.Bit).Value = objM.Estado;
            cmd.Parameters.AddWithValue("Capacidad", SqlDbType.Int).Value = objM.Capacidad;
            cmd.Parameters.AddWithValue("IdEmpleado", SqlDbType.Int).Value = objM.Estado;

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


        public int ActualizarMesa(CEMesa objM)
        {
            int resultado;
            SqlCommand cmd = new SqlCommand("Sp_ActualizarMesa", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdMesa", SqlDbType.Int).Value = objM.IdMesa;
            cmd.Parameters.AddWithValue("Estado", SqlDbType.Bit).Value = objM.Estado;
            cmd.Parameters.AddWithValue("Capacidad", SqlDbType.Int).Value = objM.Capacidad;
            cmd.Parameters.AddWithValue("IdEmpleado", SqlDbType.Int).Value = objM.Estado;
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

        public int EliminarMesa(CEMesa objM)
        {
            int resultado;
            SqlCommand cmd = new SqlCommand("Sp_EliminarMesa", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdMesa", SqlDbType.Int).Value = objM.IdMesa;
            try
            {
                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de eliminar el registro", ex);
            }
            finally
            {
                DesconectarBD();
                cmd.Dispose();
            }
            return resultado;
        }

        public int ActualizarEstadoMesa(CEMesa objM, int estado)
        {
            int resultado;
            SqlCommand cmd = new SqlCommand("Sp_ModEstadoMesa", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdMesa", SqlDbType.Int).Value = objM.IdMesa;
            cmd.Parameters.AddWithValue("@Estado", SqlDbType.Bit).Value = estado;
            try
            {
                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el estado de la mesa", ex);
            }
            finally
            {
                DesconectarBD();
                cmd.Dispose();
            }
            return resultado;
        }
        public int EstadoMesa(CEMesa objM)
        {
            int resultado;
            SqlCommand cmd = new SqlCommand("Sp_EstadoMesa", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdMesa", SqlDbType.Int).Value = objM.IdMesa;
            
            try
            {
                ConectarBD();
                resultado = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el estado de la mesa", ex);
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
