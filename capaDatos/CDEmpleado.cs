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

     public class CDEmpleado : Conexion
    {
        public int InsertarEmpleado(CEEmpleado objA)        
        {
            int resultado;
            SqlCommand cmd = new SqlCommand("Sp_InsertarEmpleado", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", SqlDbType.NVarChar).Value = objA.Nombre;
            cmd.Parameters.AddWithValue("@Apellido", SqlDbType.NVarChar).Value = objA.Apellido;
            cmd.Parameters.AddWithValue("@Telefono", SqlDbType.VarChar).Value = objA.Telefono;
            cmd.Parameters.AddWithValue("@Correo", SqlDbType.NVarChar).Value = objA.Correo;
            cmd.Parameters.AddWithValue("@Direccion", SqlDbType.NVarChar).Value = objA.Direccion;
            cmd.Parameters.AddWithValue("@IdSexo", SqlDbType.Int).Value = objA.IdSexo;
            cmd.Parameters.AddWithValue("@IdTipoEmpleado", SqlDbType.Int).Value = objA.IdTipoEmpleado;
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

        public int ModificarEmpleado(CEEmpleado objA)
        {
            int resultado;
            SqlCommand cmd = new SqlCommand("Sp_ModificarEmpleado", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdEmpleado", SqlDbType.Int).Value = objA.IdEmpleado;
            cmd.Parameters.AddWithValue("@Nombre", SqlDbType.NVarChar).Value = objA.Nombre;
            cmd.Parameters.AddWithValue("@Apellidos", SqlDbType.NVarChar).Value = objA.Apellido;
            cmd.Parameters.AddWithValue("@Telefono", SqlDbType.VarChar).Value = objA.Apellido;
            cmd.Parameters.AddWithValue("@Correo", SqlDbType.NVarChar).Value = objA.Correo;
            cmd.Parameters.AddWithValue("@Direccion", SqlDbType.NVarChar).Value = objA.Direccion;
            cmd.Parameters.AddWithValue("@IdSexo", SqlDbType.Int).Value = objA.IdSexo;
            cmd.Parameters.AddWithValue("@IdTipoEmpleado", SqlDbType.Int).Value = objA.IdTipoEmpleado;

            try
            {
                ConectarBD();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de Modificar el registro", ex);
            }
            finally
            {
                DesconectarBD();
                cmd.Dispose();
            }

            return resultado;
        }
        public int EliminarEmpleado(CEEmpleado objA)
        {
            int resultado;
            SqlCommand cmd = new SqlCommand("Sp_EliminarEmpleado", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", SqlDbType.Int).Value = objA.IdEmpleado;
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


        public DataSet ListarSexo()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_ListarSexo", cnn);
                da.Fill(ds, "Sexo");
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

        public DataSet ListarTipoEmpleado()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();            
            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_ListarTipoEmpleado", cnn);
                da.Fill(ds, "TipoEmpleados");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos del empleado", ex);
            }
            finally
            {
                //DesconectarBD();
                ds.Dispose();
            }
        }


        public DataSet ListarEmpleados()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            try
            {
                da = new SqlDataAdapter("Sp_MostrarEmpleados", cnn);
                ConectarBD();
                da.Fill(ds, "MostrarEmpleados");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar la consulta", ex);
            }
            finally
            {
                //Cerrar coneccion?   
                DesconectarBD();         
                ds.Dispose();
            }
        }
    }
}
