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
    public partial class ReporteProducto : Form
    {
        public ReporteProducto()
        {
            InitializeComponent();
        }

        private void ReporteProducto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.V_Factura' table. You can move, or remove it, as needed.
            this.V_FacturaTableAdapter.Fill(this.DataSet1.V_Factura);

            this.reportViewer1.RefreshReport();
        }
    }
}
