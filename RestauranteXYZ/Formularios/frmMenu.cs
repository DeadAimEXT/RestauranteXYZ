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
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pbEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Show();
        }

        private void pbOrden_Click(object sender, EventArgs e)
        {
            Orden orden = new Orden();
            orden.Show();
        }

        private void pbAudit_Click(object sender, EventArgs e)
        {
            AuditLog audit = new AuditLog();
            audit.Show();
        }

        private void pbFactura_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.Show();
        }
    }
}
