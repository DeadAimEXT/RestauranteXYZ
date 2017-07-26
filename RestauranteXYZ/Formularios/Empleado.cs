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

        private void Empleado_Load(object sender, EventArgs e)
        {
            CargarComboboxSexo();
            CargarComboboxTipoEmpleado();
            CargarEmpleados();
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
            CNEmpleado objE = new CNEmpleado();
            dgvEmpleados.DataSource = objE.ListarEmpleado().Tables["MostrarEmpleados"];     
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


        private void ModificarEmpleado()
        {
            CNEmpleado modificarE = new CNEmpleado();
            CEEmpleado objEmpleado = new CEEmpleado();
            objEmpleado.IdEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
            objEmpleado.Nombre = txtNombre.Text;
            objEmpleado.Apellido = txtApellidos.Text;
            objEmpleado.Telefono = txtTelefono.Text;
            objEmpleado.Correo = txtCorreo.Text;
            objEmpleado.Direccion = txtDireccion.Text;
            objEmpleado.IdSexo = Convert.ToInt32(cboSexo.SelectedValue);
            objEmpleado.IdTipoEmpleado = Convert.ToInt32(cboTipoEmpleado.SelectedValue);

            if (modificarE.ModificarEmpleado(objEmpleado) > 0)
            {
                MessageBox.Show(null, "Registro modificado satisfactoriamente.", "Restaurante XYZ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al modificar el registro.", "Restaurante XYZ",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FilaSeleccionada()
        {

            txtIdEmpleado.Text   =  dgvEmpleados.CurrentRow.Cells[0].Value.ToString(); 
            txtNombre.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtTelefono.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtCorreo.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtDireccion.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            cboSexo.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            cboTipoEmpleado.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarEmpleado();
            CargarEmpleados();
            Limpiar();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilaSeleccionada();
            grpDatos.Enabled = true; //El group box

            //Seleccionar tab page
            tbcEmpleado.SelectedTab = tbpGestion;
        }

        private void Limpiar()
        {
            txtIdEmpleado.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            cboSexo.Text = "";
            cboTipoEmpleado.Text = "";
        }
    }
}
