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
        public CEMesa mesa = new CEMesa();
        public CNMesa cnMesa = new CNMesa();
        public CNEmpleado cnEmpleado = new CNEmpleado();
        public Orden[] orden = new Orden[] { new Orden(), new Orden(), new Orden(), new Orden(), new Orden(), new Orden(), new Orden(), new Orden(), new Orden() };
        public List<CEMesa> listMesas = new List<CEMesa>();
        public CNAuditoriaLog audit = new CNAuditoriaLog();
        
        string userName;
        public Mesa()
        {
            InitializeComponent();
        }
        public Mesa(string userName)
        {
            
            InitializeComponent();
            this.userName = userName;
            initMesas();
            
            
        }

        private void pbMesa1_Click(object sender, EventArgs e)
        {

            listMesas[0].Estado = cnMesa.EstadoMesa(listMesas[0]);
            if(listMesas[0].Estado == 0)
            {
                pbMesa1.Image = Properties.Resources.MesaActiva1;
                cnMesa.ActualizarEstadoMesa(listMesas[0], 1);
            }
            else
            {
                mostrarOrden(0);
            }
            
            
        }

        private void pbMesa2_Click(object sender, EventArgs e)
        {
            listMesas[1].Estado = cnMesa.EstadoMesa(listMesas[1]);
            if (listMesas[1].Estado == 0)
            {
                pbMesa2.Image = Properties.Resources.MesaActiva2;
                cnMesa.ActualizarEstadoMesa(listMesas[1], 1);
            }
            else
            {
                mostrarOrden(1);
            }
        }

        private void pbMesa3_Click(object sender, EventArgs e)
        {
            listMesas[2].Estado = cnMesa.EstadoMesa(listMesas[2]);
            if (listMesas[2].Estado == 0)
            {
                pbMesa3.Image = Properties.Resources.MesaActiva3;
                cnMesa.ActualizarEstadoMesa(listMesas[2], 1);
            }
            else
            {
                mostrarOrden(2);
            }
        }

        private void pbMesa4_Click(object sender, EventArgs e)
        {
            listMesas[3].Estado = cnMesa.EstadoMesa(listMesas[3]);
            if (listMesas[3].Estado == 0)
            {
                pbMesa4.Image = Properties.Resources.MesaActiva4;
                cnMesa.ActualizarEstadoMesa(listMesas[3], 1);
            }
            else
            {
                mostrarOrden(3);
            };
        }

        private void pbMesa5_Click(object sender, EventArgs e)
        {
            listMesas[4].Estado = cnMesa.EstadoMesa(listMesas[4]);
            if (listMesas[4].Estado == 0)
            {
                pbMesa5.Image = Properties.Resources.ButacaActivaIzq1;
                cnMesa.ActualizarEstadoMesa(listMesas[4], 1);
            }
            else
            {
                mostrarOrden(4);
            }
        }

        private void pbMesa6_Click(object sender, EventArgs e)
        {
            listMesas[5].Estado = cnMesa.EstadoMesa(listMesas[5]);
            if (listMesas[5].Estado == 0)
            {
                pbMesa6.Image = Properties.Resources.ButacaActivaIzq2;
                cnMesa.ActualizarEstadoMesa(listMesas[5], 1);
            }
            else
            {
                mostrarOrden(5);
            }
        }

        private void pbMesa7_Click(object sender, EventArgs e)
        {
            listMesas[6].Estado = cnMesa.EstadoMesa(listMesas[6]);
            if (listMesas[6].Estado == 0)
            {
                pbMesa7.Image = Properties.Resources.ButacaActivaIzq3;
                cnMesa.ActualizarEstadoMesa(listMesas[6], 1);
            }
            else
            {
                mostrarOrden(6);
            }
        }

        private void pbMesa8_Click(object sender, EventArgs e)
        {
            listMesas[7].Estado = cnMesa.EstadoMesa(listMesas[7]);
            if (listMesas[7].Estado == 0)
            {
                pbMesa8.Image = Properties.Resources.ButacaActivaDer1;
                cnMesa.ActualizarEstadoMesa(listMesas[7], 1);
            }
            else
            {
                mostrarOrden(7);
            }
        }

        private void pbMesa9_Click(object sender, EventArgs e)
        {
            listMesas[8].Estado = cnMesa.EstadoMesa(listMesas[8]);
            if (listMesas[8].Estado == 0)
            {
                pbMesa9.Image = Properties.Resources.ButacaActivaDer2;
                cnMesa.ActualizarEstadoMesa(listMesas[8], 1);
            }
            else
            {
                mostrarOrden(8);
            }
        }

        private void mostrarOrden(int i)
        {
            if (orden[i].IsDisposed)
            {
                orden[i] = new Orden();
                orden[i].mesa = listMesas[i];
                orden[i].idMesa = i + 1;
                orden[i].userName = this.userName;
                orden[i].Show();
                auditar(i + 1);

            }
            else
            {
                orden[i].mesa = listMesas[i];
                orden[i].idMesa = i + 1;
                orden[i].userName = this.userName;
                orden[i].Show();
                auditar(i + 1);
            }
        }

        private void revisarEstados()
        {
            for(int i = 0; i < 9; i++)
            {
                listMesas[i].Estado = cnMesa.EstadoMesa(listMesas[i]);
            }
            if(listMesas[0].Estado == 1)
            {
                pbMesa1.Image = Properties.Resources.MesaActiva1;
            }
            else
            {
                pbMesa1.Image = Properties.Resources.MesaInactiva1;
            }
            if (listMesas[1].Estado == 1)
            {
                pbMesa2.Image = Properties.Resources.MesaActiva2;
            }
            else
            {
                pbMesa2.Image = Properties.Resources.MesaInactiva2;
            }
            if (listMesas[2].Estado == 1)
            {
                pbMesa3.Image = Properties.Resources.MesaActiva3;
            }
            else
            {
                pbMesa3.Image = Properties.Resources.MesaInactiva3;
            }
            if (listMesas[3].Estado == 1)
            {
                pbMesa4.Image = Properties.Resources.MesaActiva4;
            }
            else
            {
                pbMesa4.Image = Properties.Resources.MesaInactiva4;
            }
            if (listMesas[4].Estado == 1)
            {
                pbMesa5.Image = Properties.Resources.ButacaActivaIzq1;
            }
            else
            {
                pbMesa5.Image = Properties.Resources.ButacaInactivaIzq1;
            }
            if (listMesas[5].Estado == 1)
            {
                pbMesa6.Image = Properties.Resources.ButacaActivaIzq2;
            }
            else
            {
                pbMesa6.Image = Properties.Resources.ButacaInactivaIzq2;
            }
            if (listMesas[6].Estado == 1)
            {
                pbMesa7.Image = Properties.Resources.ButacaActivaIzq3;
            }
            else
            {
                pbMesa7.Image = Properties.Resources.ButacaInactivaIzq3;
            }
            if (listMesas[7].Estado == 1)
            {
                pbMesa8.Image = Properties.Resources.ButacaActivaDer1;
            }
            else
            {
                pbMesa8.Image = Properties.Resources.ButacaInactivaDer1;
            }
            if (listMesas[8].Estado == 1)
            {
                pbMesa9.Image = Properties.Resources.ButacaActivaDer2;
            }
            else
            {
                pbMesa9.Image = Properties.Resources.ButacaInactivaDer2;
            }

        }

        private void Mesa_Load(object sender, EventArgs e)
        {
            revisarEstados();
        }
        private void initMesas()
        {
            for (int i = 0; i < 9; i++)
            {
                mesa = new CEMesa();
                mesa.IdMesa = i + 1;
                DataSet ds = new DataSet();
                ds = cnMesa.MostrarMesaId(mesa);
                mesa.IdEmpleado = cnEmpleado.NombreUsuarioEmpleadoId(userName);
                mesa.Capacidad = int.Parse(ds.Tables[0].Rows[0][2].ToString());
                mesa.Estado = cnMesa.EstadoMesa(mesa);
                listMesas.Add(mesa);
            }
        }
        private void auditar(int idMesa)
        {
            audit.InsertarAuditLog("El usuario atendio la mesa " + idMesa, cnEmpleado.IdUsuarioXIdEmpleado(cnEmpleado.NombreUsuarioEmpleadoId(userName)), DateTime.Now);
        }

        private void Mesa_Activated(object sender, EventArgs e)
        {
            revisarEstados();
        }
    }
}
