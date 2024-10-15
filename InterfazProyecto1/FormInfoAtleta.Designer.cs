
namespace InterfazProyecto1
{
    partial class FormInfoAtleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoAtleta));
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.imagenUsuario = new System.Windows.Forms.PictureBox();
            this.panelAmarilloTbNombre = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imgKarate = new System.Windows.Forms.PictureBox();
            this.panelSuperiorVentana = new System.Windows.Forms.Panel();
            this.panelAmarilloVentana = new System.Windows.Forms.Panel();
            this.btnMinimizarVentana = new System.Windows.Forms.Button();
            this.lblNombreVentana = new System.Windows.Forms.Label();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.panelAzulVentana = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKarate)).BeginInit();
            this.panelSuperiorVentana.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(20, 335);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(274, 39);
            this.btnIniciarSesion.TabIndex = 11;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // tbCedula
            // 
            this.tbCedula.BackColor = System.Drawing.Color.White;
            this.tbCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCedula.ForeColor = System.Drawing.Color.Gray;
            this.tbCedula.Location = new System.Drawing.Point(51, 277);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCedula.Size = new System.Drawing.Size(243, 19);
            this.tbCedula.TabIndex = 22;
            this.tbCedula.Text = "Cedula";
            // 
            // imagenUsuario
            // 
            this.imagenUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenUsuario.Image = ((System.Drawing.Image)(resources.GetObject("imagenUsuario.Image")));
            this.imagenUsuario.Location = new System.Drawing.Point(21, 276);
            this.imagenUsuario.Name = "imagenUsuario";
            this.imagenUsuario.Size = new System.Drawing.Size(24, 24);
            this.imagenUsuario.TabIndex = 20;
            this.imagenUsuario.TabStop = false;
            // 
            // panelAmarilloTbNombre
            // 
            this.panelAmarilloTbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloTbNombre.Location = new System.Drawing.Point(20, 305);
            this.panelAmarilloTbNombre.Name = "panelAmarilloTbNombre";
            this.panelAmarilloTbNombre.Size = new System.Drawing.Size(275, 3);
            this.panelAmarilloTbNombre.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(364, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 326);
            this.dataGridView1.TabIndex = 24;
            // 
            // imgKarate
            // 
            this.imgKarate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgKarate.BackgroundImage")));
            this.imgKarate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgKarate.Location = new System.Drawing.Point(21, 55);
            this.imgKarate.Name = "imgKarate";
            this.imgKarate.Size = new System.Drawing.Size(274, 209);
            this.imgKarate.TabIndex = 25;
            this.imgKarate.TabStop = false;
            // 
            // panelSuperiorVentana
            // 
            this.panelSuperiorVentana.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelSuperiorVentana.Controls.Add(this.panelAzulVentana);
            this.panelSuperiorVentana.Controls.Add(this.panelAmarilloVentana);
            this.panelSuperiorVentana.Controls.Add(this.btnMinimizarVentana);
            this.panelSuperiorVentana.Controls.Add(this.lblNombreVentana);
            this.panelSuperiorVentana.Controls.Add(this.btnCerrarVentana);
            this.panelSuperiorVentana.Location = new System.Drawing.Point(-1, 0);
            this.panelSuperiorVentana.Name = "panelSuperiorVentana";
            this.panelSuperiorVentana.Size = new System.Drawing.Size(924, 37);
            this.panelSuperiorVentana.TabIndex = 26;
            this.panelSuperiorVentana.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSuperiorVentana_Paint_1);
            // 
            // panelAmarilloVentana
            // 
            this.panelAmarilloVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloVentana.Location = new System.Drawing.Point(-6, 33);
            this.panelAmarilloVentana.Name = "panelAmarilloVentana";
            this.panelAmarilloVentana.Size = new System.Drawing.Size(857, 10);
            this.panelAmarilloVentana.TabIndex = 5;
            // 
            // btnMinimizarVentana
            // 
            this.btnMinimizarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizarVentana.FlatAppearance.BorderSize = 0;
            this.btnMinimizarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarVentana.Image")));
            this.btnMinimizarVentana.Location = new System.Drawing.Point(858, 3);
            this.btnMinimizarVentana.Name = "btnMinimizarVentana";
            this.btnMinimizarVentana.Size = new System.Drawing.Size(24, 31);
            this.btnMinimizarVentana.TabIndex = 2;
            this.btnMinimizarVentana.UseVisualStyleBackColor = false;
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
            this.btnCerrarVentana.Location = new System.Drawing.Point(888, 3);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(31, 31);
            this.btnCerrarVentana.TabIndex = 0;
            this.btnCerrarVentana.UseVisualStyleBackColor = false;
            // 
            // panelAzulVentana
            // 
            this.panelAzulVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panelAzulVentana.Location = new System.Drawing.Point(848, 33);
            this.panelAzulVentana.Name = "panelAzulVentana";
            this.panelAzulVentana.Size = new System.Drawing.Size(74, 10);
            this.panelAzulVentana.TabIndex = 6;
            // 
            // FormInfoAtleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 397);
            this.Controls.Add(this.panelSuperiorVentana);
            this.Controls.Add(this.imgKarate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.imagenUsuario);
            this.Controls.Add(this.panelAmarilloTbNombre);
            this.Controls.Add(this.btnIniciarSesion);
            this.Name = "FormInfoAtleta";
            this.Text = "FormInfoAtleta";
            this.Load += new System.EventHandler(this.FormInfoAtleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgKarate)).EndInit();
            this.panelSuperiorVentana.ResumeLayout(false);
            this.panelSuperiorVentana.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.PictureBox imagenUsuario;
        private System.Windows.Forms.Panel panelAmarilloTbNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox imgKarate;
        private System.Windows.Forms.Panel panelSuperiorVentana;
        private System.Windows.Forms.Panel panelAmarilloVentana;
        private System.Windows.Forms.Button btnMinimizarVentana;
        private System.Windows.Forms.Label lblNombreVentana;
        private System.Windows.Forms.Button btnCerrarVentana;
        private System.Windows.Forms.Panel panelAzulVentana;
    }
}