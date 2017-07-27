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
    public partial class Mesa : Form
    {
        public Mesa()
        {
            InitializeComponent();
        }

        private void pbMesa1_Click(object sender, EventArgs e)
        {
            Orden orden = new Orden();
            orden.Show();

        }
    }
}
