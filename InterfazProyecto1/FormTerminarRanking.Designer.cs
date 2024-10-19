
namespace InterfazProyecto1
{
    partial class FormTerminarRanking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTerminarRanking));
            this.panelSuperiorVentana = new System.Windows.Forms.Panel();
            this.btnMinimizarVentana = new System.Windows.Forms.Button();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.panelAzulVentana = new System.Windows.Forms.Panel();
            this.panelAmarilloVentana = new System.Windows.Forms.Panel();
            this.lblNombreVentana = new System.Windows.Forms.Label();
            this.btnTerminarRanking = new System.Windows.Forms.Button();
            this.panelAzulBtnBajaAtleta = new System.Windows.Forms.Panel();
            this.lblValorBusqueda = new System.Windows.Forms.Label();
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
            this.panelSuperiorVentana.Size = new System.Drawing.Size(376, 37);
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
            this.btnMinimizarVentana.Location = new System.Drawing.Point(310, 3);
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
            this.btnCerrarVentana.Location = new System.Drawing.Point(340, 3);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(31, 31);
            this.btnCerrarVentana.TabIndex = 13;
            this.btnCerrarVentana.UseVisualStyleBackColor = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // panelAzulVentana
            // 
            this.panelAzulVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panelAzulVentana.Location = new System.Drawing.Point(293, 33);
            this.panelAzulVentana.Name = "panelAzulVentana";
            this.panelAzulVentana.Size = new System.Drawing.Size(83, 10);
            this.panelAzulVentana.TabIndex = 12;
            // 
            // panelAmarilloVentana
            // 
            this.panelAmarilloVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panelAmarilloVentana.Location = new System.Drawing.Point(-6, 33);
            this.panelAmarilloVentana.Name = "panelAmarilloVentana";
            this.panelAmarilloVentana.Size = new System.Drawing.Size(303, 10);
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
            this.lblNombreVentana.Size = new System.Drawing.Size(134, 20);
            this.lblNombreVentana.TabIndex = 1;
            this.lblNombreVentana.Text = "Terminar Ranking";
            // 
            // btnTerminarRanking
            // 
            this.btnTerminarRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnTerminarRanking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTerminarRanking.FlatAppearance.BorderSize = 0;
            this.btnTerminarRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminarRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarRanking.ForeColor = System.Drawing.Color.White;
            this.btnTerminarRanking.Location = new System.Drawing.Point(103, 153);
            this.btnTerminarRanking.Name = "btnTerminarRanking";
            this.btnTerminarRanking.Size = new System.Drawing.Size(177, 33);
            this.btnTerminarRanking.TabIndex = 25;
            this.btnTerminarRanking.Text = "Terminar Ranking";
            this.btnTerminarRanking.UseVisualStyleBackColor = false;
            this.btnTerminarRanking.Click += new System.EventHandler(this.btnTerminarRanking_Click);
            // 
            // panelAzulBtnBajaAtleta
            // 
            this.panelAzulBtnBajaAtleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panelAzulBtnBajaAtleta.Location = new System.Drawing.Point(103, 183);
            this.panelAzulBtnBajaAtleta.Name = "panelAzulBtnBajaAtleta";
            this.panelAzulBtnBajaAtleta.Size = new System.Drawing.Size(177, 3);
            this.panelAzulBtnBajaAtleta.TabIndex = 26;
            // 
            // lblValorBusqueda
            // 
            this.lblValorBusqueda.AutoSize = true;
            this.lblValorBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblValorBusqueda.Location = new System.Drawing.Point(10, 65);
            this.lblValorBusqueda.Name = "lblValorBusqueda";
            this.lblValorBusqueda.Size = new System.Drawing.Size(355, 60);
            this.lblValorBusqueda.TabIndex = 29;
            this.lblValorBusqueda.Text = "¿Estas seguro/a que quieres terminar el ranking?\r\n\r\nEsto dejara en 0 todos los pu" +
    "ntos de los atletas";
            // 
            // FormTerminarRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 204);
            this.Controls.Add(this.lblValorBusqueda);
            this.Controls.Add(this.panelAzulBtnBajaAtleta);
            this.Controls.Add(this.btnTerminarRanking);
            this.Controls.Add(this.panelSuperiorVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTerminarRanking";
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
        private System.Windows.Forms.Button btnTerminarRanking;
        private System.Windows.Forms.Panel panelAzulBtnBajaAtleta;
        private System.Windows.Forms.Button btnMinimizarVentana;
        private System.Windows.Forms.Button btnCerrarVentana;
        private System.Windows.Forms.Label lblValorBusqueda;
    }
}