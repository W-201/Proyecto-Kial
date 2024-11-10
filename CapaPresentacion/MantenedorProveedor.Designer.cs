namespace CapaPresentacion
{
    partial class MantenedorProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorProveedor));
            this.pcbxFondoMadera = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDniProveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnRegresarProveedor = new System.Windows.Forms.Button();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.btnListoProveedor = new System.Windows.Forms.Button();
            this.btnCancelarProveedor = new System.Windows.Forms.Button();
            this.pcbcBotonCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcBotonCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxFondoMadera
            // 
            this.pcbxFondoMadera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbxFondoMadera.Image = ((System.Drawing.Image)(resources.GetObject("pcbxFondoMadera.Image")));
            this.pcbxFondoMadera.Location = new System.Drawing.Point(-5, -2);
            this.pcbxFondoMadera.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.pcbxFondoMadera.Name = "pcbxFondoMadera";
            this.pcbxFondoMadera.Size = new System.Drawing.Size(1224, 674);
            this.pcbxFondoMadera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxFondoMadera.TabIndex = 30;
            this.pcbxFondoMadera.TabStop = false;
            this.pcbxFondoMadera.Click += new System.EventHandler(this.pcbxFondoMadera_Click);
            this.pcbxFondoMadera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbxFondoMadera_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDniProveedor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDireccionProveedor);
            this.groupBox1.Controls.Add(this.txtTelefonoProveedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreProveedor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 104);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(461, 253);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos:";
            // 
            // txtDniProveedor
            // 
            this.txtDniProveedor.Location = new System.Drawing.Point(153, 153);
            this.txtDniProveedor.Name = "txtDniProveedor";
            this.txtDniProveedor.Size = new System.Drawing.Size(255, 28);
            this.txtDniProveedor.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "RUC:";
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(153, 198);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(255, 28);
            this.txtDireccionProveedor.TabIndex = 10;
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(153, 107);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(255, 28);
            this.txtTelefonoProveedor.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Direccion:";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(153, 58);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(255, 28);
            this.txtNombreProveedor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "Proveedores";
            // 
            // dtgvProveedores
            // 
            this.dtgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProveedores.Location = new System.Drawing.Point(564, 104);
            this.dtgvProveedores.Name = "dtgvProveedores";
            this.dtgvProveedores.RowHeadersWidth = 51;
            this.dtgvProveedores.RowTemplate.Height = 24;
            this.dtgvProveedores.Size = new System.Drawing.Size(618, 362);
            this.dtgvProveedores.TabIndex = 35;
            // 
            // btnRegresarProveedor
            // 
            this.btnRegresarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnRegresarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarProveedor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresarProveedor.Location = new System.Drawing.Point(31, 599);
            this.btnRegresarProveedor.Name = "btnRegresarProveedor";
            this.btnRegresarProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnRegresarProveedor.TabIndex = 46;
            this.btnRegresarProveedor.Text = "Regresar";
            this.btnRegresarProveedor.UseVisualStyleBackColor = false;
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(61)))), ((int)(((byte)(20)))));
            this.btnModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProveedor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarProveedor.Location = new System.Drawing.Point(207, 473);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnModificarProveedor.TabIndex = 45;
            this.btnModificarProveedor.Text = "Modificar";
            this.btnModificarProveedor.UseVisualStyleBackColor = false;
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(61)))), ((int)(((byte)(20)))));
            this.btnEditarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProveedor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarProveedor.Location = new System.Drawing.Point(365, 473);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnEditarProveedor.TabIndex = 44;
            this.btnEditarProveedor.Text = "Inhabilita";
            this.btnEditarProveedor.UseVisualStyleBackColor = false;
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnNuevoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProveedor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoProveedor.Location = new System.Drawing.Point(54, 473);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnNuevoProveedor.TabIndex = 43;
            this.btnNuevoProveedor.Text = "Nuevo";
            this.btnNuevoProveedor.UseVisualStyleBackColor = false;
            // 
            // btnListoProveedor
            // 
            this.btnListoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnListoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListoProveedor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListoProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListoProveedor.Location = new System.Drawing.Point(1058, 599);
            this.btnListoProveedor.Name = "btnListoProveedor";
            this.btnListoProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnListoProveedor.TabIndex = 48;
            this.btnListoProveedor.Text = "Listo";
            this.btnListoProveedor.UseVisualStyleBackColor = false;
            // 
            // btnCancelarProveedor
            // 
            this.btnCancelarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.btnCancelarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarProveedor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarProveedor.Location = new System.Drawing.Point(848, 599);
            this.btnCancelarProveedor.Name = "btnCancelarProveedor";
            this.btnCancelarProveedor.Size = new System.Drawing.Size(124, 46);
            this.btnCancelarProveedor.TabIndex = 47;
            this.btnCancelarProveedor.Text = "Cancelar";
            this.btnCancelarProveedor.UseVisualStyleBackColor = false;
            // 
            // pcbcBotonCerrar
            // 
            this.pcbcBotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pcbcBotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbcBotonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pcbcBotonCerrar.Image")));
            this.pcbcBotonCerrar.Location = new System.Drawing.Point(1194, -2);
            this.pcbcBotonCerrar.Name = "pcbcBotonCerrar";
            this.pcbcBotonCerrar.Size = new System.Drawing.Size(25, 25);
            this.pcbcBotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbcBotonCerrar.TabIndex = 49;
            this.pcbcBotonCerrar.TabStop = false;
            this.pcbcBotonCerrar.Click += new System.EventHandler(this.pcbcBotonCerrar_Click);
            // 
            // MantenedorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 670);
            this.Controls.Add(this.pcbcBotonCerrar);
            this.Controls.Add(this.btnListoProveedor);
            this.Controls.Add(this.btnCancelarProveedor);
            this.Controls.Add(this.btnRegresarProveedor);
            this.Controls.Add(this.btnModificarProveedor);
            this.Controls.Add(this.btnEditarProveedor);
            this.Controls.Add(this.btnNuevoProveedor);
            this.Controls.Add(this.dtgvProveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pcbxFondoMadera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenedorProveedor";
            this.Text = "MantenedorProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxFondoMadera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcBotonCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbxFondoMadera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDniProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvProveedores;
        private System.Windows.Forms.Button btnRegresarProveedor;
        private System.Windows.Forms.Button btnModificarProveedor;
        private System.Windows.Forms.Button btnEditarProveedor;
        private System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.Button btnListoProveedor;
        private System.Windows.Forms.Button btnCancelarProveedor;
        private System.Windows.Forms.PictureBox pcbcBotonCerrar;
    }
}