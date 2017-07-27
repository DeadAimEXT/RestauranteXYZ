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
    class CDMesa : Conexion
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

        public DataSet ListarEmpleados()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarEmpleados", cnn);
                da.Fill(ds, "Empleados");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos del empleado", ex);
            }
            finally
            {
                DesconectarBD();
                ds.Dispose();
            }
        }
    }
}
