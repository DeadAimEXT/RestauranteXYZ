using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteXYZ.Formularios
{
    public partial class frmMenu : Form
    {
        string userName;

        public frmMenu()
        {
            InitializeComponent();
        }
        public frmMenu(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void pbEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado(userName);
            empleado.Show();
        }

        private void pbOrden_Click(object sender, EventArgs e)
        {
            Mesa mesa = new Mesa(userName);
            mesa.Show();
        }

        private void pbAudit_Click(object sender, EventArgs e)
        {
            AuditLog audit = new AuditLog();
            audit.Show();
        }

        private void pbFactura_Click(object sender, EventArgs e)
        {
            ModFactura factura = new ModFactura();
            factura.Show();
        }

        private void pbReportes_Click(object sender, EventArgs e)
        {
            Reportes reporte = new Reportes();
            reporte.Show();
        }
    }
}
