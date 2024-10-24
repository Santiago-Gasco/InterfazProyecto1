﻿
namespace InterfazProyecto1
{
    partial class FormCargarFixture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargarFixture));
            this.panelSuperiorVentana = new System.Windows.Forms.Panel();
            this.panelAmarilloVentana = new System.Windows.Forms.Panel();
            this.panelAzulVentana = new System.Windows.Forms.Panel();
            this.lblNombreVentana = new System.Windows.Forms.Label();
            this.btnBajaAtleta = new System.Windows.Forms.Button();
            this.panelAzulBtnBajaAtleta = new System.Windows.Forms.Panel();
            this.panelAmarilloCbBusqueda = new System.Windows.Forms.Panel();
            this.cbTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.lblTipoValorBusqueda = new System.Windows.Forms.Label();
            this.btnMinimizarVentana = new System.Windows.Forms.Button();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.panelSuperiorVentana.SuspendLayout();
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
            this.panelSuperiorVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperiorVentana_MouseMove);
            this.panelSuperiorVentana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSuperiorVentana_MouseMove);
            // 
            // panelAmarilloVentana
            // 
            this.panelAmarilloVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloVentana.Location = new System.Drawing.Point(-6, 33);
            this.panelAmarilloVentana.Name = "panelAmarilloVentana";
            this.panelAmarilloVentana.Size = new System.Drawing.Size(191, 10);
            this.panelAmarilloVentana.TabIndex = 11;
            // 
            // panelAzulVentana
            // 
            this.panelAzulVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panelAzulVentana.Location = new System.Drawing.Point(184, 33);
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
            this.lblNombreVentana.Size = new System.Drawing.Size(109, 20);
            this.lblNombreVentana.TabIndex = 1;
            this.lblNombreVentana.Text = "Cargar Fixture";
            // 
            // btnBajaAtleta
            // 
            this.btnBajaAtleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBajaAtleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBajaAtleta.FlatAppearance.BorderSize = 0;
            this.btnBajaAtleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaAtleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaAtleta.ForeColor = System.Drawing.Color.White;
            this.btnBajaAtleta.Location = new System.Drawing.Point(50, 125);
            this.btnBajaAtleta.Name = "btnBajaAtleta";
            this.btnBajaAtleta.Size = new System.Drawing.Size(177, 33);
            this.btnBajaAtleta.TabIndex = 25;
            this.btnBajaAtleta.Text = "Borrar Atleta";
            this.btnBajaAtleta.UseVisualStyleBackColor = false;
            this.btnBajaAtleta.Click += new System.EventHandler(this.btnBajaAtleta_Click);
            // 
            // panelAzulBtnBajaAtleta
            // 
            this.panelAzulBtnBajaAtleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panelAzulBtnBajaAtleta.Location = new System.Drawing.Point(50, 155);
            this.panelAzulBtnBajaAtleta.Name = "panelAzulBtnBajaAtleta";
            this.panelAzulBtnBajaAtleta.Size = new System.Drawing.Size(177, 3);
            this.panelAzulBtnBajaAtleta.TabIndex = 26;
            // 
            // panelAmarilloCbBusqueda
            // 
            this.panelAmarilloCbBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloCbBusqueda.Location = new System.Drawing.Point(70, 101);
            this.panelAmarilloCbBusqueda.Name = "panelAmarilloCbBusqueda";
            this.panelAmarilloCbBusqueda.Size = new System.Drawing.Size(134, 3);
            this.panelAmarilloCbBusqueda.TabIndex = 17;
            // 
            // cbTipoBusqueda
            // 
            this.cbTipoBusqueda.AutoCompleteCustomSource.AddRange(new string[] {
            "Hombre",
            "Mujer"});
            this.cbTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoBusqueda.FormattingEnabled = true;
            this.cbTipoBusqueda.Items.AddRange(new object[] {
            "ID",
            "Cedula",
            "Numero Federado"});
            this.cbTipoBusqueda.Location = new System.Drawing.Point(70, 77);
            this.cbTipoBusqueda.Name = "cbTipoBusqueda";
            this.cbTipoBusqueda.Size = new System.Drawing.Size(134, 26);
            this.cbTipoBusqueda.TabIndex = 16;
            this.cbTipoBusqueda.DropDown += new System.EventHandler(this.cbTipoBusqueda_DropDown);
            // 
            // lblTipoValorBusqueda
            // 
            this.lblTipoValorBusqueda.AutoSize = true;
            this.lblTipoValorBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoValorBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTipoValorBusqueda.Location = new System.Drawing.Point(108, 54);
            this.lblTipoValorBusqueda.Name = "lblTipoValorBusqueda";
            this.lblTipoValorBusqueda.Size = new System.Drawing.Size(57, 20);
            this.lblTipoValorBusqueda.TabIndex = 15;
            this.lblTipoValorBusqueda.Text = "Fixture";
            // 
            // btnMinimizarVentana
            // 
            this.btnMinimizarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizarVentana.FlatAppearance.BorderSize = 0;
            this.btnMinimizarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarVentana.Image")));
            this.btnMinimizarVentana.Location = new System.Drawing.Point(203, 3);
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
            this.btnCerrarVentana.Location = new System.Drawing.Point(233, 3);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(31, 31);
            this.btnCerrarVentana.TabIndex = 13;
            this.btnCerrarVentana.UseVisualStyleBackColor = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // FormCargarFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 182);
            this.Controls.Add(this.lblTipoValorBusqueda);
            this.Controls.Add(this.panelAmarilloCbBusqueda);
            this.Controls.Add(this.cbTipoBusqueda);
            this.Controls.Add(this.panelAzulBtnBajaAtleta);
            this.Controls.Add(this.btnBajaAtleta);
            this.Controls.Add(this.panelSuperiorVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCargarFixture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAltaAtleta";
            this.panelSuperiorVentana.ResumeLayout(false);
            this.panelSuperiorVentana.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperiorVentana;
        private System.Windows.Forms.Panel panelAmarilloVentana;
        private System.Windows.Forms.Panel panelAzulVentana;
        private System.Windows.Forms.Label lblNombreVentana;
        private System.Windows.Forms.Button btnBajaAtleta;
        private System.Windows.Forms.Panel panelAzulBtnBajaAtleta;
        private System.Windows.Forms.Panel panelAmarilloCbBusqueda;
        private System.Windows.Forms.ComboBox cbTipoBusqueda;
        private System.Windows.Forms.Label lblTipoValorBusqueda;
        private System.Windows.Forms.Button btnMinimizarVentana;
        private System.Windows.Forms.Button btnCerrarVentana;
    }
}