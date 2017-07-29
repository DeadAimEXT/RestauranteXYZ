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
            this.pbOrden = new System.Windows.Forms.PictureBox();
            this.pbEmpleado = new System.Windows.Forms.PictureBox();
            this.pbAudit = new System.Windows.Forms.PictureBox();
            this.pbFactura = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAudit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.42159F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.57841F));
            this.tableLayoutPanel1.Controls.Add(this.pbOrden, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbEmpleado, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbAudit, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbFactura, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 552);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pbOrden
            // 
            this.pbOrden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbOrden.Image = global::RestauranteXYZ.Properties.Resources.menu;
            this.pbOrden.Location = new System.Drawing.Point(333, 43);
            this.pbOrden.Name = "pbOrden";
            this.pbOrden.Size = new System.Drawing.Size(225, 214);
            this.pbOrden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOrden.TabIndex = 1;
            this.pbOrden.TabStop = false;
            this.pbOrden.Click += new System.EventHandler(this.pbOrden_Click);
            this.pbOrden.MouseEnter += new System.EventHandler(this.pbOrden_MouseEnter);
            this.pbOrden.MouseLeave += new System.EventHandler(this.pbOrden_MouseLeave);
            // 
            // pbEmpleado
            // 
            this.pbEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbEmpleado.Image = global::RestauranteXYZ.Properties.Resources.waiter;
            this.pbEmpleado.Location = new System.Drawing.Point(36, 43);
            this.pbEmpleado.Name = "pbEmpleado";
            this.pbEmpleado.Size = new System.Drawing.Size(226, 214);
            this.pbEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmpleado.TabIndex = 0;
            this.pbEmpleado.TabStop = false;
            this.pbEmpleado.Click += new System.EventHandler(this.pbEmpleado_Click);
            this.pbEmpleado.MouseEnter += new System.EventHandler(this.pbEmpleado_MouseEnter);
            this.pbEmpleado.MouseLeave += new System.EventHandler(this.pbEmpleado_MouseLeave);
            // 
            // pbAudit
            // 
            this.pbAudit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAudit.Image = global::RestauranteXYZ.Properties.Resources.restaurant;
            this.pbAudit.Location = new System.Drawing.Point(36, 317);
            this.pbAudit.Name = "pbAudit";
            this.pbAudit.Size = new System.Drawing.Size(226, 214);
            this.pbAudit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAudit.TabIndex = 2;
            this.pbAudit.TabStop = false;
            this.pbAudit.Click += new System.EventHandler(this.pbAudit_Click);
            this.pbAudit.MouseEnter += new System.EventHandler(this.pbAudit_MouseEnter);
            this.pbAudit.MouseLeave += new System.EventHandler(this.pbAudit_MouseLeave);
            // 
            // pbFactura
            // 
            this.pbFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFactura.Image = global::RestauranteXYZ.Properties.Resources.invoice;
            this.pbFactura.Location = new System.Drawing.Point(333, 317);
            this.pbFactura.Name = "pbFactura";
            this.pbFactura.Size = new System.Drawing.Size(226, 214);
            this.pbFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFactura.TabIndex = 3;
            this.pbFactura.TabStop = false;
            this.pbFactura.Click += new System.EventHandler(this.pbFactura_Click);
            this.pbFactura.MouseEnter += new System.EventHandler(this.pbFactura_MouseEnter);
            this.pbFactura.MouseLeave += new System.EventHandler(this.pbFactura_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empleados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Orden";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Auditoria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Facturas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(593, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}