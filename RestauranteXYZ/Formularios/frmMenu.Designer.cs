namespace RestauranteXYZ.Formularios
{
    partial class frmMenu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbEmpleado = new System.Windows.Forms.PictureBox();
            this.pbOrden = new System.Windows.Forms.PictureBox();
            this.pbAudit = new System.Windows.Forms.PictureBox();
            this.pbFactura = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAudit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pbOrden, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbFactura, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbEmpleado, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbAudit, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 433);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pbEmpleado
            // 
            this.pbEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEmpleado.Location = new System.Drawing.Point(3, 3);
            this.pbEmpleado.Name = "pbEmpleado";
            this.pbEmpleado.Size = new System.Drawing.Size(254, 210);
            this.pbEmpleado.TabIndex = 0;
            this.pbEmpleado.TabStop = false;
            this.pbEmpleado.Click += new System.EventHandler(this.pbEmpleado_Click);
            // 
            // pbOrden
            // 
            this.pbOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbOrden.Location = new System.Drawing.Point(263, 3);
            this.pbOrden.Name = "pbOrden";
            this.pbOrden.Size = new System.Drawing.Size(255, 210);
            this.pbOrden.TabIndex = 1;
            this.pbOrden.TabStop = false;
            this.pbOrden.Click += new System.EventHandler(this.pbOrden_Click);
            // 
            // pbAudit
            // 
            this.pbAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAudit.Location = new System.Drawing.Point(3, 219);
            this.pbAudit.Name = "pbAudit";
            this.pbAudit.Size = new System.Drawing.Size(254, 211);
            this.pbAudit.TabIndex = 2;
            this.pbAudit.TabStop = false;
            this.pbAudit.Click += new System.EventHandler(this.pbAudit_Click);
            // 
            // pbFactura
            // 
            this.pbFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFactura.Location = new System.Drawing.Point(263, 219);
            this.pbFactura.Name = "pbFactura";
            this.pbFactura.Size = new System.Drawing.Size(255, 211);
            this.pbFactura.TabIndex = 3;
            this.pbFactura.TabStop = false;
            this.pbFactura.Click += new System.EventHandler(this.pbFactura_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main";
            this.Text = "Main";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAudit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbEmpleado;
        private System.Windows.Forms.PictureBox pbOrden;
        private System.Windows.Forms.PictureBox pbAudit;
        private System.Windows.Forms.PictureBox pbFactura;
    }
}