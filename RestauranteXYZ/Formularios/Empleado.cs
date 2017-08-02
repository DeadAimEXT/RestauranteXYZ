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


        #region CargarCombobox
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
        #endregion


        private void CargarEmpleados()
        {
            CNEmpleado objE = new CNEmpleado();
            dgvEmpleados.DataSource = objE.ListarEmpleado().Tables["MostrarEmpleados"];     
        }


        #region InsertarEliminarModificar
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


        private void EliminarEmpleado(int IdEmpleado)
        {
            CNEmpleado eliminarE = new CNEmpleado();
            CEEmpleado objEmpleado = new CEEmpleado();
            objEmpleado.IdEmpleado = IdEmpleado;

            if (eliminarE.EliminarEmpleado(objEmpleado) > 0)
            {
                MessageBox.Show(null, "Registr eliminado satisfactoriamente.", "Restaurante XYZ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(null, "Error al eliminar el registro.", "Restaurante XYZ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void FilaSeleccionada()
        {

            txtIdEmpleado.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString(); 
            txtNombre.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            cboSexo.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
            cboTipoEmpleado.Text = dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
        }


        #region TodosLosBotones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            HabilitarTexbox(false, false);
            HabilitarBotones(true, false, false, false, true);
     
            InsertarEmpleado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarTexbox(false, true);
            HabilitarBotones(false, true, false, true, false);
  
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            HabilitarTexbox(false, false);
            HabilitarBotones(true, false, false, false, true);
      
            ModificarEmpleado();
            CargarEmpleados();
            Limpiar();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarBotones(true, false, false, false, true);
            HabilitarTexbox(false, false);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rdbNombre.Checked == true)
            {
                BuscarPorNombre(txtBuscar.Text);
            }
            else if (rdbIdEmpleado.Checked == true)
            {
                BuscarPorId(int.Parse(txtBuscar.Text));
            }
            else
            {
                CargarEmpleados();
            }
        }
        #endregion

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HabilitarTexbox(false, true);
            HabilitarBotones(false, false, true, true, false);
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
            cboSexo.SelectedValue = - 1;
            cboTipoEmpleado.SelectedValue = -1;
        }

        private void HabilitarBotones (bool Nuevo, bool Guardar, bool Modificar,  bool Cancelar, bool Salir)
        {
            btnNuevo.Enabled = Nuevo;
            btnGuardar.Enabled = Guardar;
            btnModificar.Enabled = Modificar;
            btnCancelar.Enabled = Cancelar;
            btnSalir.Enabled = Salir;
        }

        private void HabilitarTexbox(bool Id, bool valor)
        {
            txtIdEmpleado.Enabled = Id;
            txtNombre.Enabled = valor;
            txtApellidos.Enabled = valor;
            txtTelefono.Enabled = valor;
            txtCorreo.Enabled = valor;
            txtDireccion.Enabled = valor;
            cboSexo.Enabled = valor;
            cboTipoEmpleado.Enabled = valor;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i;
            i = int.Parse(dgvEmpleados.CurrentRow.Cells[0].Value.ToString());
            EliminarEmpleado(i);
            CargarEmpleados();
        }

        private void BuscarPorNombre(string Nombre)
        {
            CNEmpleado BuscarE = new CNEmpleado();
            CEEmpleado objEmpleado = new CEEmpleado();
            objEmpleado.Nombre = Nombre;
            dgvEmpleados.DataSource = BuscarE.MostrarPorNombre(objEmpleado).Tables["MostrarNombre"];
        }

        private void BuscarPorId(int IdEmpleado)
        {
            CNEmpleado BuscarE = new CNEmpleado();
            CEEmpleado objEmpleado = new CEEmpleado();
            objEmpleado.IdEmpleado = IdEmpleado;
            dgvEmpleados.DataSource = BuscarE.MostrarPorId (objEmpleado).Tables["MostrarId"];
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}
