using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace capaDatos
{
    
    public class Conexion
    {
        public SqlConnection cnn;

        public Conexion()
        {
            cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);

        }

        //Conexion a la base de datos
        public void ConectarBD()
        {
            try
            {
                if (cnn.State == ConnectionState.Broken || cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al abrir la conexion", e);
            }
        }

        // Desconectar la base de datos
        public void DesconectarBD()
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexion", e);
            }
        }

    }
}
