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
            Empleado empleado = new Empleado();
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

        private void pbEmpleado_MouseEnter(object sender, EventArgs e)
        {
            pbEmpleado.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbEmpleado_MouseLeave(object sender, EventArgs e)
        {
            pbEmpleado.BorderStyle = BorderStyle.None;
        }

        private void pbOrden_MouseEnter(object sender, EventArgs e)
        {
            pbOrden.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbOrden_MouseLeave(object sender, EventArgs e)
        {
            pbOrden.BorderStyle = BorderStyle.None;
        }

        private void pbAudit_MouseEnter(object sender, EventArgs e)
        {
            pbAudit.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbAudit_MouseLeave(object sender, EventArgs e)
        {
            pbAudit.BorderStyle = BorderStyle.None;
        }

        private void pbFactura_MouseEnter(object sender, EventArgs e)
        {
            pbFactura.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbFactura_MouseLeave(object sender, EventArgs e)
        {
            pbFactura.BorderStyle = BorderStyle.None;
        }
    }
}
