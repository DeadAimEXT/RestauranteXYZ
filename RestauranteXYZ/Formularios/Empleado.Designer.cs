namespace RestauranteXYZ.Formularios
{
    partial class Empleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbcEmpleado = new System.Windows.Forms.TabControl();
            this.tbpGestion = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTipo = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
            this.cmsEmpleado = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcEmpleado.SuspendLayout();
            this.tbpGestion.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.cmsEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcEmpleado
            // 
            this.tbcEmpleado.Controls.Add(this.tbpGestion);
            this.tbcEmpleado.Controls.Add(this.tbpBuscar);
            this.tbcEmpleado.Location = new System.Drawing.Point(-4, 0);
            this.tbcEmpleado.Name = "tbcEmpleado";
            this.tbcEmpleado.SelectedIndex = 0;
            this.tbcEmpleado.Size = new System.Drawing.Size(761, 465);
            this.tbcEmpleado.TabIndex = 0;
            // 
            // tbpGestion
            // 
            this.tbpGestion.BackColor = System.Drawing.Color.White;
            this.tbpGestion.Controls.Add(this.groupBox3);
            this.tbpGestion.Controls.Add(this.groupBox2);
            this.tbpGestion.Location = new System.Drawing.Point(4, 22);
            this.tbpGestion.Name = "tbpGestion";
            this.tbpGestion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGestion.Size = new System.Drawing.Size(753, 439);
            this.tbpGestion.TabIndex = 0;
            this.tbpGestion.Text = "Gestión Empleado";
            this.tbpGestion.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Controls.Add(this.btnNuevo);
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Location = new System.Drawing.Point(12, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(733, 65);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(375, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 27);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(258, 21);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 27);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(145, 21);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 27);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(490, 21);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 27);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir ";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboTipoEmpleado);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cboSexo);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCorreo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtApellidos);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIdEmpleado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(11, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 339);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Empleado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(404, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tipo Empleado:";
            // 
            // cboTipoEmpleado
            // 
            this.cboTipoEmpleado.FormattingEnabled = true;
            this.cboTipoEmpleado.Location = new System.Drawing.Point(491, 60);
            this.cboTipoEmpleado.Name = "cboTipoEmpleado";
            this.cboTipoEmpleado.Size = new System.Drawing.Size(165, 21);
            this.cboTipoEmpleado.TabIndex = 14;
            this.cboTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cboTipoEmpleado_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(451, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sexo:";
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(491, 97);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(127, 21);
            this.cboSexo.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(123, 236);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(545, 85);
            this.txtDireccion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(60, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dirección:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(123, 154);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(217, 20);
            this.txtCorreo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(74, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Correo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(124, 190);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(217, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(64, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Teléfono:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(123, 119);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(217, 20);
            this.txtApellidos.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(218, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(62, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(60, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres:";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(123, 45);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(109, 20);
            this.txtIdEmpleado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(48, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "IdEmpleado:";
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Controls.Add(this.btnBuscar);
            this.tbpBuscar.Controls.Add(this.dataGridView1);
            this.tbpBuscar.Controls.Add(this.txtBuscar);
            this.tbpBuscar.Controls.Add(this.groupBox1);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscar.Size = new System.Drawing.Size(753, 439);
            this.tbpBuscar.TabIndex = 1;
            this.tbpBuscar.Text = "Buscar Empleado";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(455, 87);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(61, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 277);
            this.dataGridView1.TabIndex = 9;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(236, 89);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(213, 20);
            this.txtBuscar.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTipo);
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.rbEmpleado);
            this.groupBox1.Location = new System.Drawing.Point(184, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 64);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bucar:";
            // 
            // rbTipo
            // 
            this.rbTipo.AutoSize = true;
            this.rbTipo.Location = new System.Drawing.Point(264, 29);
            this.rbTipo.Name = "rbTipo";
            this.rbTipo.Size = new System.Drawing.Size(96, 17);
            this.rbTipo.TabIndex = 2;
            this.rbTipo.TabStop = true;
            this.rbTipo.Text = "Tipo Empleado";
            this.rbTipo.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(128, 29);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(112, 17);
            this.rbNombre.TabIndex = 1;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre Empleado";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbEmpleado
            // 
            this.rbEmpleado.AutoSize = true;
            this.rbEmpleado.Location = new System.Drawing.Point(20, 29);
            this.rbEmpleado.Name = "rbEmpleado";
            this.rbEmpleado.Size = new System.Drawing.Size(81, 17);
            this.rbEmpleado.TabIndex = 0;
            this.rbEmpleado.TabStop = true;
            this.rbEmpleado.Text = "IdEmpleado";
            this.rbEmpleado.UseVisualStyleBackColor = true;
            // 
            // cmsEmpleado
            // 
            this.cmsEmpleado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.cmsEmpleado.Name = "cmsEmpleado";
            this.cmsEmpleado.Size = new System.Drawing.Size(118, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 462);
            this.Controls.Add(this.tbcEmpleado);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.tbcEmpleado.ResumeLayout(false);
            this.tbpGestion.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbpBuscar.ResumeLayout(false);
            this.tbpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmsEmpleado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcEmpleado;
        private System.Windows.Forms.TabPage tbpGestion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboTipoEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbEmpleado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbTipo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ContextMenuStrip cmsEmpleado;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}