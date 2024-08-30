
namespace InterfazProyecto1
{
    partial class FormBajaAtleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBajaAtleta));
            this.panelSuperiorVentana = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMinimizarVentana = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.btnBajaAtleta = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.cbTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbValorBusqueda = new System.Windows.Forms.TextBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panelSuperiorVentana.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperiorVentana
            // 
            this.panelSuperiorVentana.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelSuperiorVentana.Controls.Add(this.panel1);
            this.panelSuperiorVentana.Controls.Add(this.panel4);
            this.panelSuperiorVentana.Controls.Add(this.btnMinimizarVentana);
            this.panelSuperiorVentana.Controls.Add(this.label1);
            this.panelSuperiorVentana.Controls.Add(this.btnCerrarVentana);
            this.panelSuperiorVentana.Location = new System.Drawing.Point(0, 0);
            this.panelSuperiorVentana.Name = "panelSuperiorVentana";
            this.panelSuperiorVentana.Size = new System.Drawing.Size(342, 37);
            this.panelSuperiorVentana.TabIndex = 7;
            this.panelSuperiorVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperiorVentana_MouseDown);
            this.panelSuperiorVentana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSuperiorVentana_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panel1.Location = new System.Drawing.Point(-6, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 10);
            this.panel1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panel4.Location = new System.Drawing.Point(265, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(83, 10);
            this.panel4.TabIndex = 12;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Baja Atleta";
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
            // btnBajaAtleta
            // 
            this.btnBajaAtleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnBajaAtleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBajaAtleta.FlatAppearance.BorderSize = 0;
            this.btnBajaAtleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaAtleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaAtleta.ForeColor = System.Drawing.Color.White;
            this.btnBajaAtleta.Location = new System.Drawing.Point(80, 142);
            this.btnBajaAtleta.Name = "btnBajaAtleta";
            this.btnBajaAtleta.Size = new System.Drawing.Size(177, 33);
            this.btnBajaAtleta.TabIndex = 25;
            this.btnBajaAtleta.Text = "Borrar Atleta";
            this.btnBajaAtleta.UseVisualStyleBackColor = false;
            this.btnBajaAtleta.Click += new System.EventHandler(this.btnBajaAtleta_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panel13.Location = new System.Drawing.Point(80, 172);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(177, 3);
            this.panel13.TabIndex = 26;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panel16.Location = new System.Drawing.Point(21, 104);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(134, 3);
            this.panel16.TabIndex = 17;
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
            this.cbTipoBusqueda.Location = new System.Drawing.Point(21, 80);
            this.cbTipoBusqueda.Name = "cbTipoBusqueda";
            this.cbTipoBusqueda.Size = new System.Drawing.Size(134, 26);
            this.cbTipoBusqueda.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label9.Location = new System.Drawing.Point(12, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Valor de busqueda";
            // 
            // tbValorBusqueda
            // 
            this.tbValorBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorBusqueda.Location = new System.Drawing.Point(186, 80);
            this.tbValorBusqueda.Name = "tbValorBusqueda";
            this.tbValorBusqueda.Size = new System.Drawing.Size(127, 24);
            this.tbValorBusqueda.TabIndex = 21;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panel17.Location = new System.Drawing.Point(186, 104);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(127, 3);
            this.panel17.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label10.Location = new System.Drawing.Point(230, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Valor";
            // 
            // FormBajaAtleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 204);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbValorBusqueda);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.cbTipoBusqueda);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.btnBajaAtleta);
            this.Controls.Add(this.panelSuperiorVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBajaAtleta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAltaAtleta";
            this.panelSuperiorVentana.ResumeLayout(false);
            this.panelSuperiorVentana.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperiorVentana;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMinimizarVentana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarVentana;
        private System.Windows.Forms.Button btnBajaAtleta;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.ComboBox cbTipoBusqueda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbValorBusqueda;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label10;
    }
}