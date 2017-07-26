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

        private void cboTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            CargarComboboxSexo();
            
        }

        private void CargarComboboxSexo()
        {
            CNEmpleado objE = new CNEmpleado();
            cboSexo.DataSource = objE.ListarSexo().Tables["Sexo"];
            cboSexo.DisplayMember = "Sexo";
            cboSexo.ValueMember = "IdSexo";
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
            objEmpleado.IdTipoEmpleado = Convert.ToInt32(cboTipoEmpleado.SelectedValue);
            objEmpleado.IdSexo = Convert.ToInt32(cboSexo.SelectedValue);

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarEmpleado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CargarComboboxSexo();
        }
    }
}
