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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            switch(cboTipoReporte.SelectedIndex)
            {
                case 0:
                    ReporteFactura rf = new ReporteFactura();
                    rf.Show();
                    break;
                case 1:
                    ReporteProducto rp = new ReporteProducto();
                    rp.Show();
                    break;
                case 2:
                    ReporteEmpleado re = new ReporteEmpleado();
                    re.Show();
                    break;
                default:
                    break;

            }
            
            
        }
    }
}
