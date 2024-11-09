namespace KialChikenApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcboxPortada = new System.Windows.Forms.PictureBox();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.pcbxUsuario = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pcbxContraseña = new System.Windows.Forms.PictureBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.pcbcBotonCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcBotonCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnIniciarSesion);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.pcbxContraseña);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.pcbxUsuario);
            this.panel1.Controls.Add(this.lblIniciarSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 450);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pcboxPortada
            // 
            this.pcboxPortada.Dock = System.Windows.Forms.DockStyle.Right;
            this.pcboxPortada.Image = ((System.Drawing.Image)(resources.GetObject("pcboxPortada.Image")));
            this.pcboxPortada.Location = new System.Drawing.Point(291, 0);
            this.pcboxPortada.Name = "pcboxPortada";
            this.pcboxPortada.Size = new System.Drawing.Size(509, 450);
            this.pcboxPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxPortada.TabIndex = 1;
            this.pcboxPortada.TabStop = false;
            this.pcboxPortada.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcboxPortada_MouseDown);
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.lblIniciarSesion.Location = new System.Drawing.Point(30, 88);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(230, 40);
            this.lblIniciarSesion.TabIndex = 0;
            this.lblIniciarSesion.Text = "Iniciar sesión";
            this.lblIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbxUsuario
            // 
            this.pcbxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pcbxUsuario.Image")));
            this.pcbxUsuario.Location = new System.Drawing.Point(24, 188);
            this.pcbxUsuario.Name = "pcbxUsuario";
            this.pcbxUsuario.Size = new System.Drawing.Size(25, 25);
            this.pcbxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxUsuario.TabIndex = 1;
            this.pcbxUsuario.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(65, 188);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(167, 28);
            this.txtUsuario.TabIndex = 2;
            // 
            // pcbxContraseña
            // 
            this.pcbxContraseña.BackColor = System.Drawing.Color.Transparent;
            this.pcbxContraseña.Image = ((System.Drawing.Image)(resources.GetObject("pcbxContraseña.Image")));
            this.pcbxContraseña.Location = new System.Drawing.Point(24, 242);
            this.pcbxContraseña.Name = "pcbxContraseña";
            this.pcbxContraseña.Size = new System.Drawing.Size(25, 25);
            this.pcbxContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxContraseña.TabIndex = 3;
            this.pcbxContraseña.TabStop = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(65, 242);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(167, 28);
            this.txtContraseña.TabIndex = 4;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(54)))));
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciarSesion.Location = new System.Drawing.Point(65, 314);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnIniciarSesion.Size = new System.Drawing.Size(167, 39);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            // 
            // pcbcBotonCerrar
            // 
            this.pcbcBotonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pcbcBotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbcBotonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pcbcBotonCerrar.Image")));
            this.pcbcBotonCerrar.Location = new System.Drawing.Point(775, 0);
            this.pcbcBotonCerrar.Name = "pcbcBotonCerrar";
            this.pcbcBotonCerrar.Size = new System.Drawing.Size(25, 25);
            this.pcbcBotonCerrar.TabIndex = 2;
            this.pcbcBotonCerrar.TabStop = false;
            this.pcbcBotonCerrar.Click += new System.EventHandler(this.pcbcBotonCerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcbcBotonCerrar);
            this.Controls.Add(this.pcboxPortada);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxPortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbcBotonCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcboxPortada;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.PictureBox pcbxContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pcbxUsuario;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.PictureBox pcbcBotonCerrar;
    }
}