namespace RestauranteXYZ.Formularios
{
    partial class AuditLog
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
            this.dgvAuditoriaLog = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rdbIdUsuario = new System.Windows.Forms.RadioButton();
            this.rdbIdAuditoria = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoriaLog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAuditoriaLog
            // 
            this.dgvAuditoriaLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvAuditoriaLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoriaLog.Location = new System.Drawing.Point(30, 153);
            this.dgvAuditoriaLog.Name = "dgvAuditoriaLog";
            this.dgvAuditoriaLog.Size = new System.Drawing.Size(529, 300);
            this.dgvAuditoriaLog.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNombre);
            this.groupBox1.Controls.Add(this.rdbIdUsuario);
            this.groupBox1.Controls.Add(this.rdbIdAuditoria);
            this.groupBox1.Location = new System.Drawing.Point(119, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bucar:";
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(269, 29);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(109, 17);
            this.rdbNombre.TabIndex = 1;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre Usuario";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // rdbIdUsuario
            // 
            this.rdbIdUsuario.AutoSize = true;
            this.rdbIdUsuario.Location = new System.Drawing.Point(160, 29);
            this.rdbIdUsuario.Name = "rdbIdUsuario";
            this.rdbIdUsuario.Size = new System.Drawing.Size(75, 17);
            this.rdbIdUsuario.TabIndex = 1;
            this.rdbIdUsuario.TabStop = true;
            this.rdbIdUsuario.Text = "IdUsuario";
            this.rdbIdUsuario.UseVisualStyleBackColor = true;
            // 
            // rdbIdAuditoria
            // 
            this.rdbIdAuditoria.AutoSize = true;
            this.rdbIdAuditoria.Location = new System.Drawing.Point(20, 29);
            this.rdbIdAuditoria.Name = "rdbIdAuditoria";
            this.rdbIdAuditoria.Size = new System.Drawing.Size(102, 17);
            this.rdbIdAuditoria.TabIndex = 0;
            this.rdbIdAuditoria.TabStop = true;
            this.rdbIdAuditoria.Text = "IdAuditoriaLog";
            this.rdbIdAuditoria.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(381, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(61, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(162, 109);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(213, 22);
            this.txtBuscar.TabIndex = 11;
            // 
            // AuditLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(600, 475);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvAuditoriaLog);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "AuditLog";
            this.Load += new System.EventHandler(this.AuditLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoriaLog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAuditoriaLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbIdUsuario;
        private System.Windows.Forms.RadioButton rdbIdAuditoria;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}