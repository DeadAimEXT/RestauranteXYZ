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
        public string userName;
        CNAuditoriaLog audit = new CNAuditoriaLog();
        CNEmpleado cnEmpleado = new CNEmpleado();
        public Empleado(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            CargarComboboxSexo();
            CargarComboboxTipoEmpleado();
            CargarEmpleados();
            HabilitarBotones(true,false,false,false,true);
            HabilitarTexbox(false, false);
            cboSexo.SelectedIndex = -1;
            cboTipoEmpleado.SelectedIndex = -1;
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
                audit.InsertarAuditLog("Se agrego un empleado nuevo", cnEmpleado.NombreUsuarioEmpleadoId(userName), DateTime.Now);
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
                audit.InsertarAuditLog("Se modifico empleado con Id = " + txtIdEmpleado.Text, cnEmpleado.NombreUsuarioEmpleadoId(userName), DateTime.Now);
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
                audit.InsertarAuditLog("Se elimino el empleado con Id = "+ txtIdEmpleado.Text, cnEmpleado.NombreUsuarioEmpleadoId(userName), DateTime.Now);
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
            #region Validaciones

            if (txtNombre.Text == "")
            {
                epMensaje.SetError(txtNombre, "Debe ingresar Nombres del empleado");
                txtNombre.Focus();
                return;
            }
            else
            {
                epMensaje.SetError(txtNombre, "");
            }

            if (txtApellidos.Text == "")
            {

                epMensaje.SetError(txtApellidos, "Debe ingresar Apellidos del empleado");
                txtApellidos.Focus();
                return;
            }
            else
            {
                epMensaje.SetError(txtApellidos, "");
            }

            if (txtTelefono.Text == "")
            {
                epMensaje.SetError(txtTelefono, "Debe ingresar el numero de telefono del empleado");
                txtTelefono.Focus();
                return;
            }
            else
            {
                epMensaje.SetError(txtTelefono, "");
            }

            if (txtDireccion.Text == "")
            {

                epMensaje.SetError(txtDireccion, "Debe ingresar la direccion del empleado");
                txtDireccion.Focus();
                return;
            }
            else
            {
                epMensaje.SetError(txtDireccion, "");
            }

            if (cboTipoEmpleado.Text == "")
            {
                epMensaje.SetError(cboTipoEmpleado, "Seleccione el tipo de empleado");
                cboTipoEmpleado.Focus();
                return;
            }
            else
            {
                epMensaje.SetError(cboTipoEmpleado, "");
            }

            if (cboSexo.Text == "")
            {
                epMensaje.SetError(cboSexo, "Seleccione el sexo");
                cboSexo.Focus();
                return;
            }
            else
            {
                epMensaje.SetError(cboTipoEmpleado, "");
            }


            #endregion
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
            #region Validaciones

            if (txtNombre.Text == "")
            {
                epMensaje.SetError(txtNombre, "Debe ingresar Nombres del empleado");
                txtNombre.Focus();
                return;
            }
            else
            {
                epMensaje.SetError(txtNombre, "");
            }

            if (txtApellidos.Text == "")
            {

                epMensaje.SetError(txtApellidos, "Debe ingresar Apellidos del empleado");
                txtApellidos.Focus();
                return;
            }
            else
            {
                epMensaje.SetError(txtApellidos, "");
            }

            if (txtTelefono.Text == "")
            {
                epMensaje.SetError(txtTelefono, "Debe ingresar el numero de telefono del empleado");
                txtTelefono.Focus();
                return;
            }
            else
            {
                epMensaje.SetError(txtTelefono, "");
            }

            if (txtDireccion.Text == "")
            {

                epMensaje.SetError(txtDireccion, "Debe ingresar la direccion del empleado");
                txtDireccion.Focus();
                return;
            }
            else
            {
                epMensaje.SetError(txtDireccion, "");
            }

            if (cboTipoEmpleado.Text == "")
            {
                epMensaje.SetError(cboTipoEmpleado, "Seleccione el tipo de empleado");
                cboTipoEmpleado.Focus();
                return;
            }
            else
            {
                epMensaje.SetError(cboTipoEmpleado, "");
            }

            if (cboSexo.Text == "")
            {
                epMensaje.SetError(cboSexo, "Seleccione el sexo");
                cboSexo.Focus();
                return;
            }
            else
            {
                epMensaje.SetError(cboTipoEmpleado, "");
            }


            #endregion
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
            Limpiar();
            epMensaje.Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            dgvEmpleados.DataSource = BuscarE.MostrarPorId(objEmpleado).Tables["MostrarId"];
        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            epMensaje.Dispose();
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            epMensaje.Dispose();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            epMensaje.Dispose();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            epMensaje.Dispose();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            epMensaje.Dispose();
        }

        private void cboTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            epMensaje.Dispose();
        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            epMensaje.Dispose();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (rdbNombre.Checked == true)
            {
                BuscarPorNombre(txtBuscar.Text);
            }

            if (rdbIdEmpleado.Checked == true)
            {
                BuscarPorId(Convert.ToInt32(txtBuscar.Text));
            }

            if (txtBuscar.Text == "")
            {
                CargarEmpleados();
            }
        }
    }
}
