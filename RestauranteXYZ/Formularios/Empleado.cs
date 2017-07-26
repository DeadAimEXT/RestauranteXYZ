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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void CargarComboboxSexo()
        {
            CNEmpleado objE = new CNEmpleado();
            cboSexo.DataSource = objE.ListarSexo().Tables["Sexo"];
            cboSexo.DisplayMember = "Sexo";
            cboSexo.ValueMember = "IdSexo";
        }

        private void CargarComboboxTipoEmpleado()
        {
            CNEmpleado objE = new CNEmpleado();
            cboTipoEmpleado.DataSource = objE.ListarTipoEmpleado().Tables["TipoEmpleados"];
            cboTipoEmpleado.DisplayMember = "TipoEmpleado";
            cboTipoEmpleado.ValueMember = "IdTipoEmpleado";
        }

        private void CargarEmpleados()
        {
            CNEmpleado objA = new CNEmpleado();
            dgvEmpleados.DataSource = objA.ListarEmpleado().Tables["MostrarEmpleados"];     
        }


        private void InsertarEmpleado()
        {
            CNEmpleado insertar = new CNEmpleado();
            CEEmpleado objEmpleado = new CEEmpleado();
            objEmpleado.Nombre = txtNombre.Text;
            objEmpleado.Apellido = txtApellidos.Text;
            objEmpleado.Telefono = txtTelefono.Text;
            objEmpleado.Correo = txtCorreo.Text;
            objEmpleado.Direccion = txtDireccion.Text;
            objEmpleado.IdSexo = Convert.ToInt32(cboSexo.SelectedValue);
            objEmpleado.IdTipoEmpleado = Convert.ToInt32(cboTipoEmpleado.SelectedValue);
            

            if (insertar.NuevoEmpleado(objEmpleado) > 0)
            {
                MessageBox.Show(null, "Registro almacenado satisfactoriamente", "Restaurante XYZ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al almacenar el registro.", "Restaurante XYZ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FilaSeleccionada()
        {
            txtIdEmpleado.Text = dgvEmpleados.SelectedRows[0].Cells[0].Value.ToString();
            txtNombre.Text = dgvEmpleados.SelectedRows[0].Cells[1].Value.ToString();
            txtApellidos.Text = dgvEmpleados.SelectedRows[0].Cells[2].Value.ToString();
            txtTelefono.Text = dgvEmpleados.SelectedRows[0].Cells[3].Value.ToString();
            txtCorreo.Text = dgvEmpleados.SelectedRows[0].Cells[4].Value.ToString();
            txtDireccion.Text = dgvEmpleados.SelectedRows[0].Cells[5].Value.ToString();
            CargarComboboxSexo();
            cboSexo.Text = dgvEmpleados.SelectedRows[0].Cells[6].Value.ToString();
            CargarComboboxTipoEmpleado();
            cboTipoEmpleado.Text = dgvEmpleados.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {
              
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarEmpleado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void cboTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            CargarComboboxSexo();
            CargarComboboxTipoEmpleado();
            CargarEmpleados();
        }
    }
}
