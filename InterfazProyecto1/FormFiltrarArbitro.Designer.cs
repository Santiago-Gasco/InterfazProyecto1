
namespace InterfazProyecto1
{
    partial class FormFiltrarArbitro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiltrarArbitro));
            this.panelSuperiorVentana = new System.Windows.Forms.Panel();
            this.btnMinimizarVentana = new System.Windows.Forms.Button();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.panelAzulVentana = new System.Windows.Forms.Panel();
            this.panelAmarilloVentana = new System.Windows.Forms.Panel();
            this.lblNombreVentana = new System.Windows.Forms.Label();
            this.btnFiltroArbitro = new System.Windows.Forms.Button();
            this.panelAzulBtnBajaAtleta = new System.Windows.Forms.Panel();
            this.panelAmarilloCbBusqueda = new System.Windows.Forms.Panel();
            this.cbTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.lblTipoValorBusqueda = new System.Windows.Forms.Label();
            this.tbValorBusqueda = new System.Windows.Forms.TextBox();
            this.panelAmarilloTbBusqueda = new System.Windows.Forms.Panel();
            this.lblValorBusqueda = new System.Windows.Forms.Label();
            this.cbValor = new System.Windows.Forms.ComboBox();
            this.dateFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.panelSuperiorVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperiorVentana
            // 
            this.panelSuperiorVentana.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelSuperiorVentana.Controls.Add(this.btnMinimizarVentana);
            this.panelSuperiorVentana.Controls.Add(this.btnCerrarVentana);
            this.panelSuperiorVentana.Controls.Add(this.panelAzulVentana);
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
            // panelAzulVentana
            // 
            this.panelAzulVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panelAzulVentana.Location = new System.Drawing.Point(265, 33);
            this.panelAzulVentana.Name = "panelAzulVentana";
            this.panelAzulVentana.Size = new System.Drawing.Size(83, 10);
            this.panelAzulVentana.TabIndex = 12;
            // 
            // panelAmarilloVentana
            // 
            this.panelAmarilloVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloVentana.Location = new System.Drawing.Point(-6, 33);
            this.panelAmarilloVentana.Name = "panelAmarilloVentana";
            this.panelAmarilloVentana.Size = new System.Drawing.Size(272, 10);
            this.panelAmarilloVentana.TabIndex = 11;
            // 
            // lblNombreVentana
            // 
            this.lblNombreVentana.AutoSize = true;
            this.lblNombreVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVentana.ForeColor = System.Drawing.Color.White;
            this.lblNombreVentana.Location = new System.Drawing.Point(3, 10);
            this.lblNombreVentana.Name = "lblNombreVentana";
            this.lblNombreVentana.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNombreVentana.Size = new System.Drawing.Size(95, 20);
            this.lblNombreVentana.TabIndex = 1;
            this.lblNombreVentana.Text = "Filtro Arbitro";
            // 
            // btnFiltroArbitro
            // 
            this.btnFiltroArbitro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnFiltroArbitro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFiltroArbitro.FlatAppearance.BorderSize = 0;
            this.btnFiltroArbitro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroArbitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroArbitro.ForeColor = System.Drawing.Color.White;
            this.btnFiltroArbitro.Location = new System.Drawing.Point(80, 142);
            this.btnFiltroArbitro.Name = "btnFiltroArbitro";
            this.btnFiltroArbitro.Size = new System.Drawing.Size(177, 33);
            this.btnFiltroArbitro.TabIndex = 25;
            this.btnFiltroArbitro.Text = "Filtrar Arbitro";
            this.btnFiltroArbitro.UseVisualStyleBackColor = false;
            this.btnFiltroArbitro.Click += new System.EventHandler(this.btnFiltroAtleta_Click);
            // 
            // panelAzulBtnBajaAtleta
            // 
            this.panelAzulBtnBajaAtleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panelAzulBtnBajaAtleta.Location = new System.Drawing.Point(80, 172);
            this.panelAzulBtnBajaAtleta.Name = "panelAzulBtnBajaAtleta";
            this.panelAzulBtnBajaAtleta.Size = new System.Drawing.Size(177, 3);
            this.panelAzulBtnBajaAtleta.TabIndex = 26;
            // 
            // panelAmarilloCbBusqueda
            // 
            this.panelAmarilloCbBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloCbBusqueda.Location = new System.Drawing.Point(21, 104);
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
            "Nombre",
            "Apellido",
            "Edad",
            "Sexo",
            "Fecha de Nacimiento",
            "Rango",
            "Categoria"});
            this.cbTipoBusqueda.Location = new System.Drawing.Point(21, 80);
            this.cbTipoBusqueda.Name = "cbTipoBusqueda";
            this.cbTipoBusqueda.Size = new System.Drawing.Size(134, 26);
            this.cbTipoBusqueda.TabIndex = 16;
            this.cbTipoBusqueda.SelectedIndexChanged += new System.EventHandler(this.cbTipoBusqueda_SelectedIndexChanged);
            // 
            // lblTipoValorBusqueda
            // 
            this.lblTipoValorBusqueda.AutoSize = true;
            this.lblTipoValorBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoValorBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTipoValorBusqueda.Location = new System.Drawing.Point(17, 57);
            this.lblTipoValorBusqueda.Name = "lblTipoValorBusqueda";
            this.lblTipoValorBusqueda.Size = new System.Drawing.Size(143, 20);
            this.lblTipoValorBusqueda.TabIndex = 15;
            this.lblTipoValorBusqueda.Text = "Valor de busqueda";
            // 
            // tbValorBusqueda
            // 
            this.tbValorBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorBusqueda.Location = new System.Drawing.Point(186, 80);
            this.tbValorBusqueda.Name = "tbValorBusqueda";
            this.tbValorBusqueda.Size = new System.Drawing.Size(127, 24);
            this.tbValorBusqueda.TabIndex = 21;
            // 
            // panelAmarilloTbBusqueda
            // 
            this.panelAmarilloTbBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloTbBusqueda.Location = new System.Drawing.Point(186, 104);
            this.panelAmarilloTbBusqueda.Name = "panelAmarilloTbBusqueda";
            this.panelAmarilloTbBusqueda.Size = new System.Drawing.Size(127, 3);
            this.panelAmarilloTbBusqueda.TabIndex = 20;
            // 
            // lblValorBusqueda
            // 
            this.lblValorBusqueda.AutoSize = true;
            this.lblValorBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblValorBusqueda.Location = new System.Drawing.Point(229, 57);
            this.lblValorBusqueda.Name = "lblValorBusqueda";
            this.lblValorBusqueda.Size = new System.Drawing.Size(46, 20);
            this.lblValorBusqueda.TabIndex = 29;
            this.lblValorBusqueda.Text = "Valor";
            // 
            // cbValor
            // 
            this.cbValor.AutoCompleteCustomSource.AddRange(new string[] {
            "Hombre",
            "Mujer"});
            this.cbValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValor.FormattingEnabled = true;
            this.cbValor.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbValor.Location = new System.Drawing.Point(186, 78);
            this.cbValor.Name = "cbValor";
            this.cbValor.Size = new System.Drawing.Size(127, 26);
            this.cbValor.TabIndex = 30;
            this.cbValor.Visible = false;
            // 
            // dateFechaNacimiento
            // 
            this.dateFechaNacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaNacimiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaNacimiento.Location = new System.Drawing.Point(186, 78);
            this.dateFechaNacimiento.Name = "dateFechaNacimiento";
            this.dateFechaNacimiento.Size = new System.Drawing.Size(127, 24);
            this.dateFechaNacimiento.TabIndex = 31;
            this.dateFechaNacimiento.Visible = false;
            // 
            // num
            // 
            this.num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(186, 79);
            this.num.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(127, 24);
            this.num.TabIndex = 32;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num.Visible = false;
            // 
            // FormFiltrarArbitro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 204);
            this.Controls.Add(this.dateFechaNacimiento);
            this.Controls.Add(this.num);
            this.Controls.Add(this.cbValor);
            this.Controls.Add(this.lblValorBusqueda);
            this.Controls.Add(this.tbValorBusqueda);
            this.Controls.Add(this.panelAmarilloTbBusqueda);
            this.Controls.Add(this.lblTipoValorBusqueda);
            this.Controls.Add(this.panelAmarilloCbBusqueda);
            this.Controls.Add(this.cbTipoBusqueda);
            this.Controls.Add(this.panelAzulBtnBajaAtleta);
            this.Controls.Add(this.btnFiltroArbitro);
            this.Controls.Add(this.panelSuperiorVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFiltrarArbitro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAltaAtleta";
            this.panelSuperiorVentana.ResumeLayout(false);
            this.panelSuperiorVentana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperiorVentana;
        private System.Windows.Forms.Panel panelAmarilloVentana;
        private System.Windows.Forms.Panel panelAzulVentana;
        private System.Windows.Forms.Label lblNombreVentana;
        private System.Windows.Forms.Button btnFiltroArbitro;
        private System.Windows.Forms.Panel panelAzulBtnBajaAtleta;
        private System.Windows.Forms.Panel panelAmarilloCbBusqueda;
        private System.Windows.Forms.ComboBox cbTipoBusqueda;
        private System.Windows.Forms.Label lblTipoValorBusqueda;
        private System.Windows.Forms.TextBox tbValorBusqueda;
        private System.Windows.Forms.Panel panelAmarilloTbBusqueda;
        private System.Windows.Forms.Label lblValorBusqueda;
        private System.Windows.Forms.ComboBox cbValor;
        private System.Windows.Forms.DateTimePicker dateFechaNacimiento;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Button btnMinimizarVentana;
        private System.Windows.Forms.Button btnCerrarVentana;
    }
}