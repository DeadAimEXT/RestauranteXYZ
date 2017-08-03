using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using capaDatos;

namespace RestauranteXYZ.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string userName;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                SqlConnection cnn = con.cnn;
                
                SqlDataAdapter sql = new SqlDataAdapter("Select Count(*) From Usuario where Usuario = '" + txtUser.Text + "' and Contrasena = '" + txtContrasena.Text + "'", cnn);

                DataTable ver = new DataTable();
                sql.Fill(ver);

                if (ver.Rows[0][0].ToString() == "1")
                {
                    userName = txtUser.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();


                }
                else
                {
                    lblError.Text = "Datos Erroneos";
                }
            }
            catch (Exception ex)
            {
                
                lblError.Text = "Datos Erroneos";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
