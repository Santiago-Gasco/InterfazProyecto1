
namespace InterfazProyecto1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnListarAtleta = new System.Windows.Forms.Button();
            this.btnEditarAtleta = new System.Windows.Forms.Button();
            this.btnBorrarAtleta = new System.Windows.Forms.Button();
            this.btnAltaAtleta = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnMinimizarVentana = new System.Windows.Forms.Button();
            this.lblPestaña = new System.Windows.Forms.Label();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.txtAtletaNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numAtletaCedula = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAtletaApellido = new System.Windows.Forms.TextBox();
            this.cbAtletaGenero = new System.Windows.Forms.ComboBox();
            this.dateAtletaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.numAtletaFederado = new System.Windows.Forms.NumericUpDown();
            this.txtAtletaEscuela = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAtletaCedula)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAtletaFederado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnListarAtleta);
            this.panel3.Controls.Add(this.btnEditarAtleta);
            this.panel3.Controls.Add(this.btnBorrarAtleta);
            this.panel3.Controls.Add(this.btnAltaAtleta);
            this.panel3.Location = new System.Drawing.Point(3, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 436);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnListarAtleta
            // 
            this.btnListarAtleta.BackColor = System.Drawing.Color.Transparent;
            this.btnListarAtleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnListarAtleta.FlatAppearance.BorderSize = 0;
            this.btnListarAtleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarAtleta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarAtleta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListarAtleta.Image = ((System.Drawing.Image)(resources.GetObject("btnListarAtleta.Image")));
            this.btnListarAtleta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarAtleta.Location = new System.Drawing.Point(9, 159);
            this.btnListarAtleta.Name = "btnListarAtleta";
            this.btnListarAtleta.Size = new System.Drawing.Size(177, 46);
            this.btnListarAtleta.TabIndex = 4;
            this.btnListarAtleta.Text = "           Listar Atleta";
            this.btnListarAtleta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarAtleta.UseVisualStyleBackColor = false;
            this.btnListarAtleta.Click += new System.EventHandler(this.btnListarAtleta_Click);
            // 
            // btnEditarAtleta
            // 
            this.btnEditarAtleta.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarAtleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditarAtleta.FlatAppearance.BorderSize = 0;
            this.btnEditarAtleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAtleta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAtleta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditarAtleta.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAtleta.Image")));
            this.btnEditarAtleta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAtleta.Location = new System.Drawing.Point(9, 107);
            this.btnEditarAtleta.Name = "btnEditarAtleta";
            this.btnEditarAtleta.Size = new System.Drawing.Size(180, 46);
            this.btnEditarAtleta.TabIndex = 3;
            this.btnEditarAtleta.Text = "           Editar Atleta";
            this.btnEditarAtleta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAtleta.UseVisualStyleBackColor = false;
            this.btnEditarAtleta.Click += new System.EventHandler(this.btnEditarAtleta_Click);
            // 
            // btnBorrarAtleta
            // 
            this.btnBorrarAtleta.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarAtleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBorrarAtleta.FlatAppearance.BorderSize = 0;
            this.btnBorrarAtleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarAtleta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarAtleta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBorrarAtleta.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrarAtleta.Image")));
            this.btnBorrarAtleta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarAtleta.Location = new System.Drawing.Point(9, 55);
            this.btnBorrarAtleta.Name = "btnBorrarAtleta";
            this.btnBorrarAtleta.Size = new System.Drawing.Size(177, 46);
            this.btnBorrarAtleta.TabIndex = 2;
            this.btnBorrarAtleta.Text = "           Borrar Atleta";
            this.btnBorrarAtleta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarAtleta.UseVisualStyleBackColor = false;
            this.btnBorrarAtleta.Click += new System.EventHandler(this.btnBorrarAtleta_Click);
            // 
            // btnAltaAtleta
            // 
            this.btnAltaAtleta.BackColor = System.Drawing.Color.Transparent;
            this.btnAltaAtleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAltaAtleta.FlatAppearance.BorderSize = 0;
            this.btnAltaAtleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaAtleta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaAtleta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAltaAtleta.Image = ((System.Drawing.Image)(resources.GetObject("btnAltaAtleta.Image")));
            this.btnAltaAtleta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaAtleta.Location = new System.Drawing.Point(9, 3);
            this.btnAltaAtleta.Name = "btnAltaAtleta";
            this.btnAltaAtleta.Size = new System.Drawing.Size(177, 46);
            this.btnAltaAtleta.TabIndex = 1;
            this.btnAltaAtleta.Text = "           Agregar Atleta";
            this.btnAltaAtleta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaAtleta.UseVisualStyleBackColor = false;
            this.btnAltaAtleta.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(192, 550);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(58, 550);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(192, 550);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(12, 22);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(177, 46);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "           Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel7.Controls.Add(this.btnMinimizarVentana);
            this.panel7.Controls.Add(this.lblPestaña);
            this.panel7.Controls.Add(this.btnCerrarVentana);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(702, 40);
            this.panel7.TabIndex = 9;
            // 
            // btnMinimizarVentana
            // 
            this.btnMinimizarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizarVentana.FlatAppearance.BorderSize = 0;
            this.btnMinimizarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarVentana.Image")));
            this.btnMinimizarVentana.Location = new System.Drawing.Point(638, 3);
            this.btnMinimizarVentana.Name = "btnMinimizarVentana";
            this.btnMinimizarVentana.Size = new System.Drawing.Size(24, 31);
            this.btnMinimizarVentana.TabIndex = 2;
            this.btnMinimizarVentana.UseVisualStyleBackColor = false;
            this.btnMinimizarVentana.Click += new System.EventHandler(this.btnMinimizarVentana_Click);
            // 
            // lblPestaña
            // 
            this.lblPestaña.AutoSize = true;
            this.lblPestaña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPestaña.ForeColor = System.Drawing.Color.White;
            this.lblPestaña.Location = new System.Drawing.Point(3, 10);
            this.lblPestaña.Name = "lblPestaña";
            this.lblPestaña.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPestaña.Size = new System.Drawing.Size(49, 20);
            this.lblPestaña.TabIndex = 1;
            this.lblPestaña.Text = "Menu";
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarVentana.FlatAppearance.BorderSize = 0;
            this.btnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
            this.btnCerrarVentana.Location = new System.Drawing.Point(668, 3);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(31, 31);
            this.btnCerrarVentana.TabIndex = 0;
            this.btnCerrarVentana.UseVisualStyleBackColor = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // txtAtletaNombre
            // 
            this.txtAtletaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtletaNombre.Location = new System.Drawing.Point(417, 107);
            this.txtAtletaNombre.Name = "txtAtletaNombre";
            this.txtAtletaNombre.Size = new System.Drawing.Size(109, 26);
            this.txtAtletaNombre.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cedula";
            // 
            // numAtletaCedula
            // 
            this.numAtletaCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAtletaCedula.Location = new System.Drawing.Point(417, 63);
            this.numAtletaCedula.Name = "numAtletaCedula";
            this.numAtletaCedula.Size = new System.Drawing.Size(120, 26);
            this.numAtletaCedula.TabIndex = 13;
            this.numAtletaCedula.ValueChanged += new System.EventHandler(this.numAtletaCedula_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Federado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Escuela";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(198, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 308);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtAtletaApellido
            // 
            this.txtAtletaApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtletaApellido.Location = new System.Drawing.Point(417, 150);
            this.txtAtletaApellido.Name = "txtAtletaApellido";
            this.txtAtletaApellido.Size = new System.Drawing.Size(109, 26);
            this.txtAtletaApellido.TabIndex = 21;
            // 
            // cbAtletaGenero
            // 
            this.cbAtletaGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAtletaGenero.FormattingEnabled = true;
            this.cbAtletaGenero.Location = new System.Drawing.Point(417, 190);
            this.cbAtletaGenero.Name = "cbAtletaGenero";
            this.cbAtletaGenero.Size = new System.Drawing.Size(121, 28);
            this.cbAtletaGenero.TabIndex = 22;
            // 
            // dateAtletaNacimiento
            // 
            this.dateAtletaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateAtletaNacimiento.Location = new System.Drawing.Point(417, 237);
            this.dateAtletaNacimiento.Name = "dateAtletaNacimiento";
            this.dateAtletaNacimiento.Size = new System.Drawing.Size(245, 22);
            this.dateAtletaNacimiento.TabIndex = 23;
            this.dateAtletaNacimiento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numAtletaFederado
            // 
            this.numAtletaFederado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAtletaFederado.Location = new System.Drawing.Point(418, 276);
            this.numAtletaFederado.Name = "numAtletaFederado";
            this.numAtletaFederado.Size = new System.Drawing.Size(120, 26);
            this.numAtletaFederado.TabIndex = 24;
            // 
            // txtAtletaEscuela
            // 
            this.txtAtletaEscuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtletaEscuela.Location = new System.Drawing.Point(417, 320);
            this.txtAtletaEscuela.Name = "txtAtletaEscuela";
            this.txtAtletaEscuela.Size = new System.Drawing.Size(109, 26);
            this.txtAtletaEscuela.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 474);
            this.Controls.Add(this.txtAtletaEscuela);
            this.Controls.Add(this.numAtletaFederado);
            this.Controls.Add(this.dateAtletaNacimiento);
            this.Controls.Add(this.cbAtletaGenero);
            this.Controls.Add(this.txtAtletaApellido);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numAtletaCedula);
            this.Controls.Add(this.txtAtletaNombre);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(702, 474);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAtletaCedula)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAtletaFederado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnListarAtleta;
        private System.Windows.Forms.Button btnEditarAtleta;
        private System.Windows.Forms.Button btnBorrarAtleta;
        private System.Windows.Forms.Button btnAltaAtleta;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnMinimizarVentana;
        private System.Windows.Forms.Label lblPestaña;
        private System.Windows.Forms.Button btnCerrarVentana;
        private System.Windows.Forms.TextBox txtAtletaNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAtletaCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAtletaApellido;
        private System.Windows.Forms.ComboBox cbAtletaGenero;
        private System.Windows.Forms.DateTimePicker dateAtletaNacimiento;
        private System.Windows.Forms.NumericUpDown numAtletaFederado;
        private System.Windows.Forms.TextBox txtAtletaEscuela;
    }
}