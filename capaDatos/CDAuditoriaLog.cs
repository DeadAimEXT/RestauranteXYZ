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
    public class CDAuditoriaLog : Conexion
    {
        #region Busquedas

        public DataSet MostrarAuditoria()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                da = new SqlDataAdapter("Sp_MostrarAuditoriaLog", cnn);
                ConectarBD();
                da.Fill(ds, "MostrarAuditoriaLog");
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show(null, "No se pudo mostrar los datos de la base de datos", "Restaurante XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                DesconectarBD();
                ds.Dispose();
            }
        }
        #endregion

        public DataSet BuscarAuditLogId(CEAuditoriaLog objA)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarAuditoriaLogId", cnn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdAuditLog", SqlDbType.Int).Value = objA;
                da.Fill(ds, "MostrarPorIdAuditLog");
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


        public DataSet BuscarAuditLogIdUsuario(CEAuditoriaLog objA)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarBD();
                da = new SqlDataAdapter("Sp_MostrarAuditoriaLogIdUsuario", cnn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = objA;
                da.Fill(ds, "MostrarPorIdUsuario");
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
    }
}
