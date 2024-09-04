
namespace InterfazProyecto1
{
    partial class FormEleccionLoginRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEleccionLoginRegistro));
            this.panelAzulVentana = new System.Windows.Forms.Panel();
            this.panelAmarilloVentana = new System.Windows.Forms.Panel();
            this.panelSuperiorVentana = new System.Windows.Forms.Panel();
            this.btnMinimizarVentana = new System.Windows.Forms.Button();
            this.lblNombreVentana = new System.Windows.Forms.Label();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.imgKarate = new System.Windows.Forms.PictureBox();
            this.panelAzulBtnIniciarSesion = new System.Windows.Forms.Panel();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.panelAzulBtnRegistrarse = new System.Windows.Forms.Panel();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.panelSuperiorVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKarate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAzulVentana
            // 
            this.panelAzulVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panelAzulVentana.Location = new System.Drawing.Point(455, 33);
            this.panelAzulVentana.Name = "panelAzulVentana";
            this.panelAzulVentana.Size = new System.Drawing.Size(74, 10);
            this.panelAzulVentana.TabIndex = 6;
            // 
            // panelAmarilloVentana
            // 
            this.panelAmarilloVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloVentana.Location = new System.Drawing.Point(-6, 33);
            this.panelAmarilloVentana.Name = "panelAmarilloVentana";
            this.panelAmarilloVentana.Size = new System.Drawing.Size(463, 10);
            this.panelAmarilloVentana.TabIndex = 5;
            // 
            // panelSuperiorVentana
            // 
            this.panelSuperiorVentana.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelSuperiorVentana.Controls.Add(this.panelAzulVentana);
            this.panelSuperiorVentana.Controls.Add(this.panelAmarilloVentana);
            this.panelSuperiorVentana.Controls.Add(this.btnMinimizarVentana);
            this.panelSuperiorVentana.Controls.Add(this.lblNombreVentana);
            this.panelSuperiorVentana.Controls.Add(this.btnCerrarVentana);
            this.panelSuperiorVentana.Location = new System.Drawing.Point(0, 0);
            this.panelSuperiorVentana.Name = "panelSuperiorVentana";
            this.panelSuperiorVentana.Size = new System.Drawing.Size(529, 37);
            this.panelSuperiorVentana.TabIndex = 8;
            this.panelSuperiorVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperiorVentana_MouseDown);
            this.panelSuperiorVentana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSuperiorVentana_MouseMove);
            // 
            // btnMinimizarVentana
            // 
            this.btnMinimizarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizarVentana.FlatAppearance.BorderSize = 0;
            this.btnMinimizarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarVentana.Image")));
            this.btnMinimizarVentana.Location = new System.Drawing.Point(465, 3);
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
            this.lblNombreVentana.Size = new System.Drawing.Size(93, 20);
            this.lblNombreVentana.TabIndex = 1;
            this.lblNombreVentana.Text = "Menu Inicial";
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarVentana.FlatAppearance.BorderSize = 0;
            this.btnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
            this.btnCerrarVentana.Location = new System.Drawing.Point(495, 3);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(31, 31);
            this.btnCerrarVentana.TabIndex = 0;
            this.btnCerrarVentana.UseVisualStyleBackColor = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // imgKarate
            // 
            this.imgKarate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgKarate.BackgroundImage")));
            this.imgKarate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgKarate.Location = new System.Drawing.Point(131, 73);
            this.imgKarate.Name = "imgKarate";
            this.imgKarate.Size = new System.Drawing.Size(274, 209);
            this.imgKarate.TabIndex = 9;
            this.imgKarate.TabStop = false;
            // 
            // panelAzulBtnIniciarSesion
            // 
            this.panelAzulBtnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panelAzulBtnIniciarSesion.Location = new System.Drawing.Point(131, 353);
            this.panelAzulBtnIniciarSesion.Name = "panelAzulBtnIniciarSesion";
            this.panelAzulBtnIniciarSesion.Size = new System.Drawing.Size(274, 3);
            this.panelAzulBtnIniciarSesion.TabIndex = 11;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(131, 315);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(274, 39);
            this.btnIniciarSesion.TabIndex = 10;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // panelAzulBtnRegistrarse
            // 
            this.panelAzulBtnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panelAzulBtnRegistrarse.Location = new System.Drawing.Point(131, 400);
            this.panelAzulBtnRegistrarse.Name = "panelAzulBtnRegistrarse";
            this.panelAzulBtnRegistrarse.Size = new System.Drawing.Size(274, 3);
            this.panelAzulBtnRegistrarse.TabIndex = 13;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarse.Location = new System.Drawing.Point(131, 362);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(274, 39);
            this.btnRegistrarse.TabIndex = 12;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // FormEleccionLoginRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 436);
            this.Controls.Add(this.panelAzulBtnRegistrarse);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.panelAzulBtnIniciarSesion);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.imgKarate);
            this.Controls.Add(this.panelSuperiorVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEleccionLoginRegistro";
            this.Text = "5";
            this.panelSuperiorVentana.ResumeLayout(false);
            this.panelSuperiorVentana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKarate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAzulVentana;
        private System.Windows.Forms.Panel panelAmarilloVentana;
        private System.Windows.Forms.Panel panelSuperiorVentana;
        private System.Windows.Forms.Button btnMinimizarVentana;
        private System.Windows.Forms.Label lblNombreVentana;
        private System.Windows.Forms.Button btnCerrarVentana;
        private System.Windows.Forms.PictureBox imgKarate;
        private System.Windows.Forms.Panel panelAzulBtnIniciarSesion;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Panel panelAzulBtnRegistrarse;
        private System.Windows.Forms.Button btnRegistrarse;
    }
}