﻿
namespace InterfazProyecto1
{
    partial class FormAltaProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaProfesor));
            this.panelSuperiorVentana = new System.Windows.Forms.Panel();
            this.btnMinimizarVentana = new System.Windows.Forms.Button();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.panelAmarilloVentana = new System.Windows.Forms.Panel();
            this.panelAzulVentana = new System.Windows.Forms.Panel();
            this.lblNombreVentana = new System.Windows.Forms.Label();
            this.panelAmarilloTbNombre = new System.Windows.Forms.Panel();
            this.panelAmarilloTbApellido = new System.Windows.Forms.Panel();
            this.panelAmarilloCbGenero = new System.Windows.Forms.Panel();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.panelAmarilloDateFechaNacimiento = new System.Windows.Forms.Panel();
            this.panelAmarilloTbEscuela = new System.Windows.Forms.Panel();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblEscuela = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.lblEdad = new System.Windows.Forms.Label();
            this.panelDivisor = new System.Windows.Forms.Panel();
            this.panelAmarilloNumCedula = new System.Windows.Forms.Panel();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.dateFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tbEscuela = new System.Windows.Forms.TextBox();
            this.btnAltaProfesor = new System.Windows.Forms.Button();
            this.panelAzulBtnAltaAtleta = new System.Windows.Forms.Panel();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.panelAmarilloNumEdad = new System.Windows.Forms.Panel();
            this.numCedula = new System.Windows.Forms.NumericUpDown();
            this.panelSuperiorVentana.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCedula)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperiorVentana
            // 
            this.panelSuperiorVentana.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelSuperiorVentana.Controls.Add(this.panelAzulVentana);
            this.panelSuperiorVentana.Controls.Add(this.btnMinimizarVentana);
            this.panelSuperiorVentana.Controls.Add(this.btnCerrarVentana);
            this.panelSuperiorVentana.Controls.Add(this.panelAmarilloVentana);
            this.panelSuperiorVentana.Controls.Add(this.lblNombreVentana);
            this.panelSuperiorVentana.Location = new System.Drawing.Point(0, 0);
            this.panelSuperiorVentana.Name = "panelSuperiorVentana";
            this.panelSuperiorVentana.Size = new System.Drawing.Size(342, 37);
            this.panelSuperiorVentana.TabIndex = 7;
            this.panelSuperiorVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperiorVentana_MouseDown);
            this.panelSuperiorVentana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSuperiorVentana_MouseMove);
            // 
            // btnMinimizarVentana
            // 
            this.btnMinimizarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizarVentana.FlatAppearance.BorderSize = 0;
            this.btnMinimizarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarVentana.Image")));
            this.btnMinimizarVentana.Location = new System.Drawing.Point(278, 3);
            this.btnMinimizarVentana.Name = "btnMinimizarVentana";
            this.btnMinimizarVentana.Size = new System.Drawing.Size(24, 31);
            this.btnMinimizarVentana.TabIndex = 14;
            this.btnMinimizarVentana.UseVisualStyleBackColor = false;
            this.btnMinimizarVentana.Click += new System.EventHandler(this.btnMinimizarVentana_Click);
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarVentana.FlatAppearance.BorderSize = 0;
            this.btnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
            this.btnCerrarVentana.Location = new System.Drawing.Point(308, 3);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(31, 31);
            this.btnCerrarVentana.TabIndex = 13;
            this.btnCerrarVentana.UseVisualStyleBackColor = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // panelAmarilloVentana
            // 
            this.panelAmarilloVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloVentana.Location = new System.Drawing.Point(-6, 33);
            this.panelAmarilloVentana.Name = "panelAmarilloVentana";
            this.panelAmarilloVentana.Size = new System.Drawing.Size(272, 10);
            this.panelAmarilloVentana.TabIndex = 11;
            // 
            // panelAzulVentana
            // 
            this.panelAzulVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panelAzulVentana.Location = new System.Drawing.Point(265, 33);
            this.panelAzulVentana.Name = "panelAzulVentana";
            this.panelAzulVentana.Size = new System.Drawing.Size(83, 10);
            this.panelAzulVentana.TabIndex = 12;
            // 
            // lblNombreVentana
            // 
            this.lblNombreVentana.AutoSize = true;
            this.lblNombreVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVentana.ForeColor = System.Drawing.Color.White;
            this.lblNombreVentana.Location = new System.Drawing.Point(3, 10);
            this.lblNombreVentana.Name = "lblNombreVentana";
            this.lblNombreVentana.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNombreVentana.Size = new System.Drawing.Size(101, 20);
            this.lblNombreVentana.TabIndex = 1;
            this.lblNombreVentana.Text = "Alta Profesor";
            // 
            // panelAmarilloTbNombre
            // 
            this.panelAmarilloTbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloTbNombre.Location = new System.Drawing.Point(186, 121);
            this.panelAmarilloTbNombre.Name = "panelAmarilloTbNombre";
            this.panelAmarilloTbNombre.Size = new System.Drawing.Size(127, 3);
            this.panelAmarilloTbNombre.TabIndex = 15;
            // 
            // panelAmarilloTbApellido
            // 
            this.panelAmarilloTbApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloTbApellido.Location = new System.Drawing.Point(186, 155);
            this.panelAmarilloTbApellido.Name = "panelAmarilloTbApellido";
            this.panelAmarilloTbApellido.Size = new System.Drawing.Size(127, 3);
            this.panelAmarilloTbApellido.TabIndex = 15;
            // 
            // panelAmarilloCbGenero
            // 
            this.panelAmarilloCbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloCbGenero.Location = new System.Drawing.Point(186, 221);
            this.panelAmarilloCbGenero.Name = "panelAmarilloCbGenero";
            this.panelAmarilloCbGenero.Size = new System.Drawing.Size(127, 3);
            this.panelAmarilloCbGenero.TabIndex = 15;
            // 
            // cbGenero
            // 
            this.cbGenero.AutoCompleteCustomSource.AddRange(new string[] {
            "Hombre",
            "Mujer"});
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbGenero.Location = new System.Drawing.Point(186, 195);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(127, 26);
            this.cbGenero.TabIndex = 14;
            // 
            // panelAmarilloDateFechaNacimiento
            // 
            this.panelAmarilloDateFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloDateFechaNacimiento.Location = new System.Drawing.Point(186, 256);
            this.panelAmarilloDateFechaNacimiento.Name = "panelAmarilloDateFechaNacimiento";
            this.panelAmarilloDateFechaNacimiento.Size = new System.Drawing.Size(127, 3);
            this.panelAmarilloDateFechaNacimiento.TabIndex = 15;
            // 
            // panelAmarilloTbEscuela
            // 
            this.panelAmarilloTbEscuela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloTbEscuela.Location = new System.Drawing.Point(186, 290);
            this.panelAmarilloTbEscuela.Name = "panelAmarilloTbEscuela";
            this.panelAmarilloTbEscuela.Size = new System.Drawing.Size(127, 3);
            this.panelAmarilloTbEscuela.TabIndex = 15;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblGenero.Location = new System.Drawing.Point(14, 152);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(63, 20);
            this.lblGenero.TabIndex = 13;
            this.lblGenero.Text = "Genero";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblApellido.Location = new System.Drawing.Point(14, 84);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblNombre.Location = new System.Drawing.Point(14, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblCedula.Location = new System.Drawing.Point(14, 13);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(59, 20);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cedula";
            // 
            // lblEscuela
            // 
            this.lblEscuela.AutoSize = true;
            this.lblEscuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscuela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblEscuela.Location = new System.Drawing.Point(14, 221);
            this.lblEscuela.Name = "lblEscuela";
            this.lblEscuela.Size = new System.Drawing.Size(66, 20);
            this.lblEscuela.TabIndex = 13;
            this.lblEscuela.Text = "Escuela";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(14, 187);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(157, 20);
            this.lblFechaNacimiento.TabIndex = 13;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.lblEdad);
            this.panelOpciones.Controls.Add(this.lblFechaNacimiento);
            this.panelOpciones.Controls.Add(this.lblEscuela);
            this.panelOpciones.Controls.Add(this.lblCedula);
            this.panelOpciones.Controls.Add(this.lblNombre);
            this.panelOpciones.Controls.Add(this.lblApellido);
            this.panelOpciones.Controls.Add(this.lblGenero);
            this.panelOpciones.Location = new System.Drawing.Point(3, 49);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(171, 244);
            this.panelOpciones.TabIndex = 16;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblEdad.Location = new System.Drawing.Point(14, 119);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(47, 20);
            this.lblEdad.TabIndex = 14;
            this.lblEdad.Text = "Edad";
            this.lblEdad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelDivisor
            // 
            this.panelDivisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panelDivisor.Location = new System.Drawing.Point(176, 49);
            this.panelDivisor.Name = "panelDivisor";
            this.panelDivisor.Size = new System.Drawing.Size(4, 250);
            this.panelDivisor.TabIndex = 17;
            // 
            // panelAmarilloNumCedula
            // 
            this.panelAmarilloNumCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloNumCedula.Location = new System.Drawing.Point(186, 82);
            this.panelAmarilloNumCedula.Name = "panelAmarilloNumCedula";
            this.panelAmarilloNumCedula.Size = new System.Drawing.Size(127, 3);
            this.panelAmarilloNumCedula.TabIndex = 12;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(186, 97);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(127, 24);
            this.tbNombre.TabIndex = 20;
            // 
            // tbApellido
            // 
            this.tbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellido.Location = new System.Drawing.Point(186, 131);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(127, 24);
            this.tbApellido.TabIndex = 21;
            // 
            // dateFechaNacimiento
            // 
            this.dateFechaNacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaNacimiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaNacimiento.Location = new System.Drawing.Point(186, 232);
            this.dateFechaNacimiento.Name = "dateFechaNacimiento";
            this.dateFechaNacimiento.Size = new System.Drawing.Size(127, 24);
            this.dateFechaNacimiento.TabIndex = 22;
            // 
            // tbEscuela
            // 
            this.tbEscuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEscuela.Location = new System.Drawing.Point(186, 266);
            this.tbEscuela.Name = "tbEscuela";
            this.tbEscuela.Size = new System.Drawing.Size(127, 24);
            this.tbEscuela.TabIndex = 24;
            // 
            // btnAltaProfesor
            // 
            this.btnAltaProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAltaProfesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAltaProfesor.FlatAppearance.BorderSize = 0;
            this.btnAltaProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProfesor.ForeColor = System.Drawing.Color.White;
            this.btnAltaProfesor.Location = new System.Drawing.Point(104, 317);
            this.btnAltaProfesor.Name = "btnAltaProfesor";
            this.btnAltaProfesor.Size = new System.Drawing.Size(147, 33);
            this.btnAltaProfesor.TabIndex = 25;
            this.btnAltaProfesor.Text = "Crear Profesor";
            this.btnAltaProfesor.UseVisualStyleBackColor = false;
            this.btnAltaProfesor.Click += new System.EventHandler(this.btnAltaProfesor_Click);
            // 
            // panelAzulBtnAltaAtleta
            // 
            this.panelAzulBtnAltaAtleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panelAzulBtnAltaAtleta.Location = new System.Drawing.Point(104, 350);
            this.panelAzulBtnAltaAtleta.Name = "panelAzulBtnAltaAtleta";
            this.panelAzulBtnAltaAtleta.Size = new System.Drawing.Size(147, 3);
            this.panelAzulBtnAltaAtleta.TabIndex = 26;
            // 
            // numEdad
            // 
            this.numEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEdad.Location = new System.Drawing.Point(186, 164);
            this.numEdad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(127, 24);
            this.numEdad.TabIndex = 27;
            this.numEdad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelAmarilloNumEdad
            // 
            this.panelAmarilloNumEdad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloNumEdad.Location = new System.Drawing.Point(186, 186);
            this.panelAmarilloNumEdad.Name = "panelAmarilloNumEdad";
            this.panelAmarilloNumEdad.Size = new System.Drawing.Size(127, 3);
            this.panelAmarilloNumEdad.TabIndex = 16;
            // 
            // numCedula
            // 
            this.numCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCedula.Location = new System.Drawing.Point(186, 58);
            this.numCedula.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numCedula.Name = "numCedula";
            this.numCedula.Size = new System.Drawing.Size(127, 24);
            this.numCedula.TabIndex = 29;
            this.numCedula.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormAltaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(342, 375);
            this.Controls.Add(this.panelDivisor);
            this.Controls.Add(this.numCedula);
            this.Controls.Add(this.panelAmarilloNumEdad);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.panelAzulBtnAltaAtleta);
            this.Controls.Add(this.btnAltaProfesor);
            this.Controls.Add(this.tbEscuela);
            this.Controls.Add(this.dateFechaNacimiento);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelAmarilloTbEscuela);
            this.Controls.Add(this.panelAmarilloDateFechaNacimiento);
            this.Controls.Add(this.panelAmarilloCbGenero);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.panelAmarilloTbApellido);
            this.Controls.Add(this.panelAmarilloTbNombre);
            this.Controls.Add(this.panelAmarilloNumCedula);
            this.Controls.Add(this.panelSuperiorVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAltaProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAltaAtleta";
            this.panelSuperiorVentana.ResumeLayout(false);
            this.panelSuperiorVentana.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCedula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperiorVentana;
        private System.Windows.Forms.Panel panelAmarilloVentana;
        private System.Windows.Forms.Panel panelAzulVentana;
        private System.Windows.Forms.Label lblNombreVentana;
        private System.Windows.Forms.Panel panelAmarilloTbNombre;
        private System.Windows.Forms.Panel panelAmarilloTbApellido;
        private System.Windows.Forms.Panel panelAmarilloCbGenero;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Panel panelAmarilloDateFechaNacimiento;
        private System.Windows.Forms.Panel panelAmarilloTbEscuela;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblEscuela;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Panel panelDivisor;
        private System.Windows.Forms.Panel panelAmarilloNumCedula;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.DateTimePicker dateFechaNacimiento;
        private System.Windows.Forms.TextBox tbEscuela;
        private System.Windows.Forms.Button btnAltaProfesor;
        private System.Windows.Forms.Panel panelAzulBtnAltaAtleta;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.Panel panelAmarilloNumEdad;
        private System.Windows.Forms.NumericUpDown numCedula;
        private System.Windows.Forms.Button btnMinimizarVentana;
        private System.Windows.Forms.Button btnCerrarVentana;
    }
}