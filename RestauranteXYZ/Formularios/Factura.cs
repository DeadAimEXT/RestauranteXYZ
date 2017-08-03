using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using capaNegocio;
using System.Windows.Forms;

namespace RestauranteXYZ.Formularios
{
    
    public partial class Factura : Form
    {
        CNAuditoriaLog audit = new CNAuditoriaLog();
        CNEmpleado cnEmpleado = new CNEmpleado();
        CNFactura cnFactura = new CNFactura();
        CEFactura fact = new CEFactura();
        public Factura()
        {
            InitializeComponent();
        }
        public Factura(CEFactura factura)
        {
            InitializeComponent();
            fact = factura;
            
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            int suma = 0;
            lblFecha.Text = fact.Fecha.ToShortDateString();
            lblTiempo.Text = fact.Fecha.ToShortDateString();
            txtIdFactura.Text = fact.IdFactura.ToString();
            txtEmpleado.Text = cnEmpleado.UsuarioNombreEmpleado(fact.IdEmpleado);
            dgvDetalles.DataSource = cnFactura.MostrarDFacturaId(fact).Tables["Detalles"];
            for (int i = 0; i < dgvDetalles.Rows.Count; i++)
            {
                suma += Convert.ToInt32(dgvDetalles.Rows[i].Cells[3].Value);
            }
            txtTotal.Text = suma.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cnFactura.EliminarFactura(fact);
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            fact.NombreCliente = txtNombreCliente.Text;
            fact.RTN = txtRtn.Text;
            cnFactura.ActualizarFactura(fact);
            audit.InsertarAuditLog("Se genero factura con Id = " + fact.IdFactura, cnEmpleado.IdUsuarioXIdEmpleado(fact.IdEmpleado), DateTime.Now);
            this.DialogResult = DialogResult.OK;
        }
    }
}
