using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using capaDatos;

namespace RestauranteXYZ.Formularios
{
    public partial class ModFactura : Form
    {


        DataSet ds = new DataSet();
        SqlDataAdapter da;

        public ModFactura()
        {
            InitializeComponent();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void rdbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFecha.Checked)
            {
                chkAntes.Enabled = true;
                chkEn.Enabled = true;
                chkDespues.Enabled = true;
                txtBuscar.Mask = "0000-00-00";
            }
            else
            {
                chkAntes.Enabled = false;
                chkEn.Enabled = false;
                chkDespues.Enabled = false;
                chkAntes.Checked = false;
                chkEn.Checked = false;
                chkDespues.Checked = false;
                txtBuscar.Mask = "";
            }

        }

        private void buscar()
        {
            Conexion con = new Conexion();
            SqlConnection cnn = con.cnn;
            ds.Clear();
            int i;
            DateTime fecha;


            if (rdbEmpleado.Checked)
            {
                if (txtBuscar.Text != "")
                {
                    da = new SqlDataAdapter("SELECT * From V_Factura Where [Mesero] like '" + txtBuscar.Text + "%'", cnn);
                    da.Fill(ds);
                    dgvFactura.DataSource = ds.Tables[0];
                }

            }
            else if (rdbFactura.Checked)
            {
                if (txtBuscar.Text != "" && Int32.TryParse(txtBuscar.Text, out i))
                {
                    da = new SqlDataAdapter("SELECT * From V_Factura Where idFactura ='" + txtBuscar.Text + "'", cnn);
                    da.Fill(ds);
                    dgvFactura.DataSource = ds.Tables[0];
                }

            }
            else if (rdbFecha.Checked && txtBuscar.MaskCompleted && DateTime.TryParse(txtBuscar.Text, out fecha))
            {
                if (chkAntes.Checked && chkEn.Checked && chkDespues.Checked)
                {
                    da = new SqlDataAdapter("SELECT * From V_Factura", cnn);
                    da.Fill(ds);

                }
                else if (chkEn.Checked && chkAntes.Checked)
                {
                    da = new SqlDataAdapter("SELECT * From V_Factura Where [Fecha] <= '" + txtBuscar.Text + "'", cnn);
                    da.Fill(ds);
                }
                else if (chkEn.Checked && chkDespues.Checked)
                {
                    da = new SqlDataAdapter("SELECT * From V_Factura Where [Fecha] >= '" + txtBuscar.Text + "'", cnn);
                    da.Fill(ds);
                }
                else if (chkAntes.Checked && chkDespues.Checked)
                {
                    da = new SqlDataAdapter("SELECT * From V_Factura Where [Fecha] > '" + txtBuscar.Text + "' OR [Fecha] <'" + txtBuscar.Text + "'", cnn);
                    da.Fill(ds);
                }

                else if (chkAntes.Checked)
                {
                    da = new SqlDataAdapter("SELECT * From V_Factura Where [Fecha] < '" + txtBuscar.Text + "'", cnn);
                    da.Fill(ds);
                }

                else if (chkDespues.Checked)
                {
                    da = new SqlDataAdapter("SELECT * From V_Factura Where [Fecha] > '" + txtBuscar.Text + "'", cnn);
                    da.Fill(ds);
                }
                else if (chkEn.Checked)
                {
                    da = new SqlDataAdapter("SELECT * From V_Factura Where [Fecha] = '" + txtBuscar.Text + "'", cnn);
                    da.Fill(ds);
                }
                if (ds.Tables.Count > 0)
                {
                    dgvFactura.DataSource = ds.Tables[0];
                }
            }
        }

        private void chkAntes_CheckedChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void chkEn_CheckedChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void chkDespues_CheckedChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }    
}
