namespace RestauranteXYZ.Formularios
{
    partial class Reportes
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
            this.cboTipoReporte = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboTipoReporte
            // 
            this.cboTipoReporte.FormattingEnabled = true;
            this.cboTipoReporte.Items.AddRange(new object[] {
            "Facturas por fecha",
            "Ingreso por producto",
            "Atencion por Empleado"});
            this.cboTipoReporte.Location = new System.Drawing.Point(13, 13);
            this.cboTipoReporte.Name = "cboTipoReporte";
            this.cboTipoReporte.Size = new System.Drawing.Size(121, 21);
            this.cboTipoReporte.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(140, 13);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 49);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cboTipoReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reportes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoReporte;
        private System.Windows.Forms.Button btnGenerar;
    }
}