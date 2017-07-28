using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidades;
using capaNegocio;

namespace RestauranteXYZ.Formularios
{
    public partial class Mesa : Form
    {
        public Orden[] orden = new Orden[] { new Orden(), new Orden(), new Orden(), new Orden(), new Orden(), new Orden(), new Orden(), new Orden(), new Orden() };
        
        public Mesa()
        {
            InitializeComponent();
        }

        private void pbMesa1_Click(object sender, EventArgs e)
        {
            if(!orden[0].IsDisposed)
            {
                orden[0].Show();
            }
            else
            {
                orden[0] = new Orden();
                orden[0].Show();
            }
            
            
        }

        private void pbMesa2_Click(object sender, EventArgs e)
        {
            orden[1].Show();
        }

        private void pbMesa3_Click(object sender, EventArgs e)
        {
            orden[2].Show();
        }

        private void pbMesa4_Click(object sender, EventArgs e)
        {
            orden[3].Show();
        }

        private void pbMesa5_Click(object sender, EventArgs e)
        {
            orden[4].Show();
        }

        private void pbMesa6_Click(object sender, EventArgs e)
        {
            orden[5].Show();
        }

        private void pbMesa7_Click(object sender, EventArgs e)
        {
            orden[6].Show();
        }

        private void pbMesa8_Click(object sender, EventArgs e)
        {
            orden[7].Show();
        }

        private void pbMesa9_Click(object sender, EventArgs e)
        {
            orden[8].Show();
        }
    }
}
