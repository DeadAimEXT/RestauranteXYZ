namespace RestauranteXYZ
{
    partial class Form1
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
            this.pbMesa = new System.Windows.Forms.PictureBox();
            this.pbAudit = new System.Windows.Forms.PictureBox();
            this.pbFacutra = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAudit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacutra)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pbEmpleado, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbMesa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbAudit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbFacutra, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(697, 577);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pbEmpleado
            // 
            this.pbEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEmpleado.Image = global::RestauranteXYZ.Properties.Resources.approval_128;
            this.pbEmpleado.Location = new System.Drawing.Point(3, 3);
            this.pbEmpleado.Name = "pbEmpleado";
            this.pbEmpleado.Size = new System.Drawing.Size(342, 282);
            this.pbEmpleado.TabIndex = 0;
            this.pbEmpleado.TabStop = false;
            // 
            // pbMesa
            // 
            this.pbMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMesa.Image = global::RestauranteXYZ.Properties.Resources.graduation_cap_128;
            this.pbMesa.Location = new System.Drawing.Point(3, 291);
            this.pbMesa.Name = "pbMesa";
            this.pbMesa.Size = new System.Drawing.Size(342, 283);
            this.pbMesa.TabIndex = 1;
            this.pbMesa.TabStop = false;
            // 
            // pbAudit
            // 
            this.pbAudit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAudit.Location = new System.Drawing.Point(351, 291);
            this.pbAudit.Name = "pbAudit";
            this.pbAudit.Size = new System.Drawing.Size(343, 283);
            this.pbAudit.TabIndex = 3;
            this.pbAudit.TabStop = false;
            // 
            // pbFacutra
            // 
            this.pbFacutra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFacutra.Image = global::RestauranteXYZ.Properties.Resources.diploma2_128;
            this.pbFacutra.Location = new System.Drawing.Point(351, 3);
            this.pbFacutra.Name = "pbFacutra";
            this.pbFacutra.Size = new System.Drawing.Size(343, 282);
            this.pbFacutra.TabIndex = 2;
            this.pbFacutra.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 601);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAudit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFacutra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbEmpleado;
        private System.Windows.Forms.PictureBox pbMesa;
        private System.Windows.Forms.PictureBox pbAudit;
        private System.Windows.Forms.PictureBox pbFacutra;
    }
}

