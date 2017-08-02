using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capaEntidades;
using System.Windows.Forms;

namespace capaDatos
{
    public class CDEmpleado : Conexion
    {
        public int InsertarEmpleado(CEEmpleado objE)        
        {
            int resultado;
            SqlCommand cmd = new SqlCommand("Sp_InsertarEmpleado", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", SqlDbType.NVarChar).Value = objE.Nombre;
            cmd.Parameters.AddWithValue("@Apellido", SqlDbType.NVarChar).Value = objE.Apellido;
            cmd.Parameters.AddWithValue("@Telefono", SqlDbType.VarChar).Value = objE.Telefono;
            cmd.Parameters.AddWithValue("@Correo", SqlDbType.NVarChar).Value = objE.Correo;
            cmd.Parameters.AddWithValue("@Direccion", SqlDbType.NVarChar).Value = objE.Direccion;
            cmd.Parameters.AddWithValue("@IdSexo", SqlDbType.Int).Value = objE.IdSexo;
            cmd.Parameters.AddWithValue("@IdTipoEmpleado", SqlDbType.Int).Value = objE.IdTipoEmpleado;
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


        public int ModificarEmpleado(CEEmpleado objE)
        {
            int resultado;
            SqlCommand cmd = new SqlCommand("Sp_ModificarEmpleado", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", SqlDbType.Int).Value = objE.IdEmpleado;
            cmd.Parameters.AddWithValue("@Nombre", SqlDbType.NVarChar).Value = objE.Nombre;
            cmd.Parameters.AddWithValue("@Apellido", SqlDbType.NVarChar).Value = objE.Apellido;
            cmd.Parameters.AddWithValue("@Telefono", SqlDbType.VarChar).Value = objE.Telefono;
            cmd.Parameters.AddWithValue("@Correo", SqlDbType.NVarChar).Value = objE.Correo;
            cmd.Parameters.AddWithValue("@Direccion", SqlDbType.NVarChar).Value = objE.Direccion;
            cmd.Parameters.AddWithValue("@IdSexo", SqlDbType.Int).Value = objE.IdSexo;
            cmd.Parameters.AddWithValue("@IdTipoEmpleado", SqlDbType.Int).Value = objE.IdTipoEmpleado;
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


        public int EliminarEmpleado(CEEmpleado objE)
        {
            int resultado;
            SqlCommand cmd = new SqlCommand("Sp_EliminarEmpleado", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", SqlDbType.Int).Value = objE.IdEmpleado;
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

        public string UsuarioNombreEmpleado(int idEmpleado)
        {
            string resultado;
            SqlCommand cmd = new SqlCommand("Sp_UsuarioNombreEmpleado", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idUsuario", SqlDbType.Int).Value = idEmpleado;
            try
            {
                ConectarBD();
                resultado = cmd.ExecuteScalar().ToString();
                return resultado;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al recuperar nombre del usuario", ex);
            }
            finally
            {
                DesconectarBD();
                cmd.Dispose();
            }
        }

        #region Busquedas 
        public DataSet BuscarPorNombre(CEEmpleado objE)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_BuscarEmpleadoNombre", cnn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = objE.Nombre;
                da.Fill(ds, "MostrarNombre");
                return ds;

            }
            catch (Exception)
            {
                MessageBox.Show(null, "No se pudo realizar la consulta", "Restaurante XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                DesconectarBD();
                ds.Dispose();
            }
        }

        public DataSet BuscarPorId(CEEmpleado objE)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_BuscarEmpleadoId", cnn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = objE.IdEmpleado;
                da.Fill(ds, "MostrarId");
                return ds;

            }
            catch (Exception)
            {
                MessageBox.Show(null, "No se pudo realizar la consulta", "Restaurante XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                DesconectarBD();
                ds.Dispose();
            }
        }

        #endregion
    }
}
