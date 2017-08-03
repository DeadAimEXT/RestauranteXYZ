namespace RestauranteXYZ.Formularios
{
    partial class ModFactura
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
            this.rdbEmpleado = new System.Windows.Forms.RadioButton();
            this.rdbFactura = new System.Windows.Forms.RadioButton();
            this.rdbFecha = new System.Windows.Forms.RadioButton();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDespues = new System.Windows.Forms.CheckBox();
            this.chkEn = new System.Windows.Forms.CheckBox();
            this.chkAntes = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbEmpleado
            // 
            this.rdbEmpleado.AutoSize = true;
            this.rdbEmpleado.Location = new System.Drawing.Point(18, 24);
            this.rdbEmpleado.Name = "rdbEmpleado";
            this.rdbEmpleado.Size = new System.Drawing.Size(76, 17);
            this.rdbEmpleado.TabIndex = 0;
            this.rdbEmpleado.TabStop = true;
            this.rdbEmpleado.Text = "Empleado";
            this.rdbEmpleado.UseVisualStyleBackColor = true;
            // 
            // rdbFactura
            // 
            this.rdbFactura.AutoSize = true;
            this.rdbFactura.Location = new System.Drawing.Point(18, 45);
            this.rdbFactura.Name = "rdbFactura";
            this.rdbFactura.Size = new System.Drawing.Size(76, 17);
            this.rdbFactura.TabIndex = 0;
            this.rdbFactura.TabStop = true;
            this.rdbFactura.Text = "Id Factura";
            this.rdbFactura.UseVisualStyleBackColor = true;
            // 
            // rdbFecha
            // 
            this.rdbFecha.AutoSize = true;
            this.rdbFecha.Location = new System.Drawing.Point(18, 68);
            this.rdbFecha.Name = "rdbFecha";
            this.rdbFecha.Size = new System.Drawing.Size(55, 17);
            this.rdbFecha.TabIndex = 0;
            this.rdbFecha.TabStop = true;
            this.rdbFecha.Text = "Fecha";
            this.rdbFecha.UseVisualStyleBackColor = true;
            this.rdbFecha.CheckedChanged += new System.EventHandler(this.rdbFecha_CheckedChanged);
            // 
            // dgvFactura
            // 
            this.dgvFactura.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(12, 12);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.Size = new System.Drawing.Size(849, 296);
            this.dgvFactura.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDespues);
            this.groupBox1.Controls.Add(this.chkEn);
            this.groupBox1.Controls.Add(this.chkAntes);
            this.groupBox1.Controls.Add(this.rdbFactura);
            this.groupBox1.Controls.Add(this.rdbEmpleado);
            this.groupBox1.Controls.Add(this.rdbFecha);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(867, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // chkDespues
            // 
            this.chkDespues.AutoSize = true;
            this.chkDespues.Enabled = false;
            this.chkDespues.Location = new System.Drawing.Point(34, 137);
            this.chkDespues.Name = "chkDespues";
            this.chkDespues.Size = new System.Drawing.Size(70, 17);
            this.chkDespues.TabIndex = 3;
            this.chkDespues.Text = "Despues";
            this.chkDespues.UseVisualStyleBackColor = true;
            this.chkDespues.CheckedChanged += new System.EventHandler(this.chkDespues_CheckedChanged);
            // 
            // chkEn
            // 
            this.chkEn.AutoSize = true;
            this.chkEn.Enabled = false;
            this.chkEn.Location = new System.Drawing.Point(34, 114);
            this.chkEn.Name = "chkEn";
            this.chkEn.Size = new System.Drawing.Size(39, 17);
            this.chkEn.TabIndex = 2;
            this.chkEn.Text = "En";
            this.chkEn.UseVisualStyleBackColor = true;
            this.chkEn.CheckedChanged += new System.EventHandler(this.chkEn_CheckedChanged);
            // 
            // chkAntes
            // 
            this.chkAntes.AutoSize = true;
            this.chkAntes.Enabled = false;
            this.chkAntes.Location = new System.Drawing.Point(34, 91);
            this.chkAntes.Name = "chkAntes";
            this.chkAntes.Size = new System.Drawing.Size(55, 17);
            this.chkAntes.TabIndex = 1;
            this.chkAntes.Text = "Antes";
            this.chkAntes.UseVisualStyleBackColor = true;
            this.chkAntes.CheckedChanged += new System.EventHandler(this.chkAntes_CheckedChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(867, 198);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(109, 20);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(868, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Busqueda";
            // 
            // lblSalir
            // 
            this.lblSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalir.AutoSize = true;
            this.lblSalir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalir.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.Location = new System.Drawing.Point(867, 273);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(109, 35);
            this.lblSalir.TabIndex = 6;
            this.lblSalir.Text = "   Salir   ";
            this.lblSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // ModFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(990, 320);
            this.ControlBox = false;
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModFactura";
            this.Text = "ModFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbEmpleado;
        private System.Windows.Forms.RadioButton rdbFactura;
        private System.Windows.Forms.RadioButton rdbFecha;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDespues;
        private System.Windows.Forms.CheckBox chkEn;
        private System.Windows.Forms.CheckBox chkAntes;
        private System.Windows.Forms.MaskedTextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalir;
    }
}