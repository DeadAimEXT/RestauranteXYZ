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
        string userName;
        public Mesa()
        {
            InitializeComponent();
        }
        public Mesa(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void pbMesa1_Click(object sender, EventArgs e)
        {
            mostrarOrden(0);
            
        }

        private void pbMesa2_Click(object sender, EventArgs e)
        {
            mostrarOrden(1);
        }

        private void pbMesa3_Click(object sender, EventArgs e)
        {
            mostrarOrden(2);
        }

        private void pbMesa4_Click(object sender, EventArgs e)
        {
            mostrarOrden(3);
        }

        private void pbMesa5_Click(object sender, EventArgs e)
        {
            mostrarOrden(4);
        }

        private void pbMesa6_Click(object sender, EventArgs e)
        {
            mostrarOrden(5);
        }

        private void pbMesa7_Click(object sender, EventArgs e)
        {
            mostrarOrden(6);
        }

        private void pbMesa8_Click(object sender, EventArgs e)
        {
            mostrarOrden(7);
        }

        private void pbMesa9_Click(object sender, EventArgs e)
        {
            mostrarOrden(8);
        }

        private void mostrarOrden(int i)
        {
            if (orden[i].IsDisposed)
            {
                orden[i] = new Orden();
                orden[i].idMesa = i + 1;
                orden[i].userName = this.userName;
                orden[i].Show();
            }
            else
            {
                orden[i].idMesa = i + 1;
                orden[i].userName = this.userName;
                orden[i].Show();
            }
        }
    }
}
