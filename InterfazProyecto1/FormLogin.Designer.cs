
namespace InterfazProyecto1
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelFondoVentana = new System.Windows.Forms.Panel();
            this.imgKarate = new System.Windows.Forms.PictureBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.imagenUsuario = new System.Windows.Forms.PictureBox();
            this.imagenContraseña = new System.Windows.Forms.PictureBox();
            this.panelAmarilloTbContraseña = new System.Windows.Forms.Panel();
            this.panelAmarilloTbNombre = new System.Windows.Forms.Panel();
            this.panelAzulBtnLogin = new System.Windows.Forms.Panel();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.panelSuperiorVentana = new System.Windows.Forms.Panel();
            this.panelAmarilloVentana = new System.Windows.Forms.Panel();
            this.panelAzulVentana = new System.Windows.Forms.Panel();
            this.btnMinimizarVentana = new System.Windows.Forms.Button();
            this.lblNombreVentana = new System.Windows.Forms.Label();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.panelFondoVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKarate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenContraseña)).BeginInit();
            this.panelSuperiorVentana.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondoVentana
            // 
            this.panelFondoVentana.BackColor = System.Drawing.Color.White;
            this.panelFondoVentana.Controls.Add(this.imgKarate);
            this.panelFondoVentana.Controls.Add(this.tbNombre);
            this.panelFondoVentana.Controls.Add(this.tbContraseña);
            this.panelFondoVentana.Controls.Add(this.imagenUsuario);
            this.panelFondoVentana.Controls.Add(this.imagenContraseña);
            this.panelFondoVentana.Controls.Add(this.panelAmarilloTbContraseña);
            this.panelFondoVentana.Controls.Add(this.panelAmarilloTbNombre);
            this.panelFondoVentana.Controls.Add(this.panelAzulBtnLogin);
            this.panelFondoVentana.Controls.Add(this.btnIniciarSesion);
            this.panelFondoVentana.Location = new System.Drawing.Point(-1, 32);
            this.panelFondoVentana.Name = "panelFondoVentana";
            this.panelFondoVentana.Size = new System.Drawing.Size(339, 332);
            this.panelFondoVentana.TabIndex = 3;
            // 
            // imgKarate
            // 
            this.imgKarate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgKarate.Image = ((System.Drawing.Image)(resources.GetObject("imgKarate.Image")));
            this.imgKarate.Location = new System.Drawing.Point(114, 21);
            this.imgKarate.Name = "imgKarate";
            this.imgKarate.Size = new System.Drawing.Size(115, 115);
            this.imgKarate.TabIndex = 7;
            this.imgKarate.TabStop = false;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.White;
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.ForeColor = System.Drawing.Color.Gray;
            this.tbNombre.Location = new System.Drawing.Point(62, 158);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNombre.Size = new System.Drawing.Size(204, 19);
            this.tbNombre.TabIndex = 19;
            this.tbNombre.Text = "Nombre";
            this.tbNombre.Enter += new System.EventHandler(this.tbNombre_Enter);
            this.tbNombre.Leave += new System.EventHandler(this.tbNombre_Leave);
            // 
            // tbContraseña
            // 
            this.tbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.ForeColor = System.Drawing.Color.Gray;
            this.tbContraseña.Location = new System.Drawing.Point(62, 201);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(204, 19);
            this.tbContraseña.TabIndex = 0;
            this.tbContraseña.Text = "Contraseña";
            this.tbContraseña.Enter += new System.EventHandler(this.tbContraseña_Enter);
            this.tbContraseña.Leave += new System.EventHandler(this.tbContraseña_Leave);
            // 
            // imagenUsuario
            // 
            this.imagenUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenUsuario.Image = ((System.Drawing.Image)(resources.GetObject("imagenUsuario.Image")));
            this.imagenUsuario.Location = new System.Drawing.Point(32, 153);
            this.imagenUsuario.Name = "imagenUsuario";
            this.imagenUsuario.Size = new System.Drawing.Size(24, 24);
            this.imagenUsuario.TabIndex = 0;
            this.imagenUsuario.TabStop = false;
            // 
            // imagenContraseña
            // 
            this.imagenContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenContraseña.Image = ((System.Drawing.Image)(resources.GetObject("imagenContraseña.Image")));
            this.imagenContraseña.Location = new System.Drawing.Point(32, 196);
            this.imagenContraseña.Name = "imagenContraseña";
            this.imagenContraseña.Size = new System.Drawing.Size(24, 24);
            this.imagenContraseña.TabIndex = 1;
            this.imagenContraseña.TabStop = false;
            // 
            // panelAmarilloTbContraseña
            // 
            this.panelAmarilloTbContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloTbContraseña.Location = new System.Drawing.Point(32, 222);
            this.panelAmarilloTbContraseña.Name = "panelAmarilloTbContraseña";
            this.panelAmarilloTbContraseña.Size = new System.Drawing.Size(275, 3);
            this.panelAmarilloTbContraseña.TabIndex = 10;
            // 
            // panelAmarilloTbNombre
            // 
            this.panelAmarilloTbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloTbNombre.Location = new System.Drawing.Point(32, 179);
            this.panelAmarilloTbNombre.Name = "panelAmarilloTbNombre";
            this.panelAmarilloTbNombre.Size = new System.Drawing.Size(275, 3);
            this.panelAmarilloTbNombre.TabIndex = 9;
            // 
            // panelAzulBtnLogin
            // 
            this.panelAzulBtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panelAzulBtnLogin.Location = new System.Drawing.Point(31, 304);
            this.panelAzulBtnLogin.Name = "panelAzulBtnLogin";
            this.panelAzulBtnLogin.Size = new System.Drawing.Size(274, 3);
            this.panelAzulBtnLogin.TabIndex = 8;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(31, 266);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(274, 39);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // panelSuperiorVentana
            // 
            this.panelSuperiorVentana.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelSuperiorVentana.Controls.Add(this.panelAmarilloVentana);
            this.panelSuperiorVentana.Controls.Add(this.panelAzulVentana);
            this.panelSuperiorVentana.Controls.Add(this.btnMinimizarVentana);
            this.panelSuperiorVentana.Controls.Add(this.lblNombreVentana);
            this.panelSuperiorVentana.Controls.Add(this.btnCerrarVentana);
            this.panelSuperiorVentana.Location = new System.Drawing.Point(-1, -1);
            this.panelSuperiorVentana.Name = "panelSuperiorVentana";
            this.panelSuperiorVentana.Size = new System.Drawing.Size(342, 37);
            this.panelSuperiorVentana.TabIndex = 6;
            this.panelSuperiorVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperiorVentana_MouseDown);
            this.panelSuperiorVentana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSuperiorVentana_MouseMove);
            // 
            // panelAmarilloVentana
            // 
            this.panelAmarilloVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloVentana.Location = new System.Drawing.Point(1, 33);
            this.panelAmarilloVentana.Name = "panelAmarilloVentana";
            this.panelAmarilloVentana.Size = new System.Drawing.Size(265, 10);
            this.panelAmarilloVentana.TabIndex = 11;
            // 
            // panelAzulVentana
            // 
            this.panelAzulVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panelAzulVentana.Location = new System.Drawing.Point(265, 33);
            this.panelAzulVentana.Name = "panelAzulVentana";
            this.panelAzulVentana.Size = new System.Drawing.Size(74, 10);
            this.panelAzulVentana.TabIndex = 12;
            // 
            // btnMinimizarVentana
            // 
            this.btnMinimizarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizarVentana.FlatAppearance.BorderSize = 0;
            this.btnMinimizarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarVentana.Image")));
            this.btnMinimizarVentana.Location = new System.Drawing.Point(269, 3);
            this.btnMinimizarVentana.Name = "btnMinimizarVentana";
            this.btnMinimizarVentana.Size = new System.Drawing.Size(24, 31);
            this.btnMinimizarVentana.TabIndex = 2;
            this.btnMinimizarVentana.UseVisualStyleBackColor = false;
            this.btnMinimizarVentana.Click += new System.EventHandler(this.btnMinimizarVentana_Click);
            // 
            // lblNombreVentana
            // 
            this.lblNombreVentana.AutoSize = true;
            this.lblNombreVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVentana.ForeColor = System.Drawing.Color.White;
            this.lblNombreVentana.Location = new System.Drawing.Point(3, 10);
            this.lblNombreVentana.Name = "lblNombreVentana";
            this.lblNombreVentana.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNombreVentana.Size = new System.Drawing.Size(48, 20);
            this.lblNombreVentana.TabIndex = 1;
            this.lblNombreVentana.Text = "Login";
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarVentana.FlatAppearance.BorderSize = 0;
            this.btnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
            this.btnCerrarVentana.Location = new System.Drawing.Point(299, 3);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(31, 31);
            this.btnCerrarVentana.TabIndex = 0;
            this.btnCerrarVentana.UseVisualStyleBackColor = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(336, 363);
            this.Controls.Add(this.panelSuperiorVentana);
            this.Controls.Add(this.panelFondoVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Form3";
            this.panelFondoVentana.ResumeLayout(false);
            this.panelFondoVentana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKarate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenContraseña)).EndInit();
            this.panelSuperiorVentana.ResumeLayout(false);
            this.panelSuperiorVentana.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFondoVentana;
        private System.Windows.Forms.PictureBox imagenContraseña;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Panel panelSuperiorVentana;
        private System.Windows.Forms.Panel panelAzulBtnLogin;
        private System.Windows.Forms.Panel panelAmarilloTbContraseña;
        private System.Windows.Forms.Panel panelAmarilloTbNombre;
        private System.Windows.Forms.PictureBox imagenUsuario;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label lblNombreVentana;
        private System.Windows.Forms.PictureBox imgKarate;
        private System.Windows.Forms.Button btnMinimizarVentana;
        private System.Windows.Forms.Button btnCerrarVentana;
        private System.Windows.Forms.Panel panelAzulVentana;
        private System.Windows.Forms.Panel panelAmarilloVentana;
    }
}