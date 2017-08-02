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
    public partial class AuditLog : Form
    {
        public AuditLog()
        {
            InitializeComponent();
        }

        private void AuditLog_Load(object sender, EventArgs e)
        {
            CargarDgvAuditoriaLog();
        }
        private void CargarDgvAuditoriaLog()
        {
            CNAuditoriaLog objA = new CNAuditoriaLog();
            dgvAuditoriaLog.DataSource = objA.MostrarAuditoriaLog().Tables["MostrarAuditoriaLog"];
        }  
        
        private void BuscarPorIdLog(int IdAuditLog)
        {
            CNAuditoriaLog BuscarA = new CNAuditoriaLog();
            CEAuditoriaLog objAuditoriaLog = new CEAuditoriaLog();
            objAuditoriaLog.IdAuditoriaLog = IdAuditLog;
            dgvAuditoriaLog.DataSource = BuscarA.MostrarPorIdAuditLog(objAuditoriaLog).Tables["MostrarPorIdAuditLog"];
        }

        private void BuscarPorIdUsuario(int IdUsuario)
        {
            CNAuditoriaLog BuscarA = new CNAuditoriaLog();
            CEAuditoriaLog objAuditoriaLog = new CEAuditoriaLog();
            objAuditoriaLog.IdUsuario = IdUsuario;
            dgvAuditoriaLog.DataSource = BuscarA.MostrarPorIdUsuario(objAuditoriaLog).Tables["MostrarPorIdUsuario"];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(rdbIdAuditoria.Checked == true)
            {
                BuscarPorIdLog(Convert.ToInt32(txtBuscar.Text));
            }
            else if (rdbIdUsuario.Checked == true)
            {
                BuscarPorIdUsuario(Convert.ToInt32(txtBuscar.Text));
            }

        }
    }
}
