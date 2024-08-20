
namespace InterfazProyecto1
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnListarAtleta = new System.Windows.Forms.Button();
            this.btnEditarAtleta = new System.Windows.Forms.Button();
            this.btnBorarAtleta = new System.Windows.Forms.Button();
            this.btnAgregarAtleta = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimizarVentana = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarVentana = new System.Windows.Forms.Button();
            this.timerDataGridView = new System.Windows.Forms.Timer(this.components);
            this.Ventana = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.dataGridViewAtletas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.Ventana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnListarAtleta);
            this.panel3.Location = new System.Drawing.Point(3, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 361);
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
            this.btnListarAtleta.Location = new System.Drawing.Point(9, 13);
            this.btnListarAtleta.Name = "btnListarAtleta";
            this.btnListarAtleta.Size = new System.Drawing.Size(161, 46);
            this.btnListarAtleta.TabIndex = 4;
            this.btnListarAtleta.Text = "           Listar Atleta";
            this.btnListarAtleta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarAtleta.UseVisualStyleBackColor = false;
            this.btnListarAtleta.Click += new System.EventHandler(this.btnListarAtleta_Click);
            // 
            // btnEditarAtleta
            // 
            this.btnEditarAtleta.BackColor = System.Drawing.Color.DimGray;
            this.btnEditarAtleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditarAtleta.FlatAppearance.BorderSize = 0;
            this.btnEditarAtleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAtleta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAtleta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditarAtleta.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAtleta.Image")));
            this.btnEditarAtleta.Location = new System.Drawing.Point(133, 411);
            this.btnEditarAtleta.Name = "btnEditarAtleta";
            this.btnEditarAtleta.Size = new System.Drawing.Size(37, 43);
            this.btnEditarAtleta.TabIndex = 3;
            this.btnEditarAtleta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAtleta.UseVisualStyleBackColor = false;
            this.btnEditarAtleta.Click += new System.EventHandler(this.btnEditarAtleta_Click);
            // 
            // btnBorarAtleta
            // 
            this.btnBorarAtleta.BackColor = System.Drawing.Color.DimGray;
            this.btnBorarAtleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBorarAtleta.FlatAppearance.BorderSize = 0;
            this.btnBorarAtleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorarAtleta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorarAtleta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBorarAtleta.Image = ((System.Drawing.Image)(resources.GetObject("btnBorarAtleta.Image")));
            this.btnBorarAtleta.Location = new System.Drawing.Point(90, 411);
            this.btnBorarAtleta.Name = "btnBorarAtleta";
            this.btnBorarAtleta.Size = new System.Drawing.Size(37, 43);
            this.btnBorarAtleta.TabIndex = 2;
            this.btnBorarAtleta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorarAtleta.UseVisualStyleBackColor = false;
            this.btnBorarAtleta.Click += new System.EventHandler(this.btnBorarAtleta_Click);
            // 
            // btnAgregarAtleta
            // 
            this.btnAgregarAtleta.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregarAtleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarAtleta.FlatAppearance.BorderSize = 0;
            this.btnAgregarAtleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAtleta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAtleta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarAtleta.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarAtleta.Image")));
            this.btnAgregarAtleta.Location = new System.Drawing.Point(47, 411);
            this.btnAgregarAtleta.Name = "btnAgregarAtleta";
            this.btnAgregarAtleta.Size = new System.Drawing.Size(37, 43);
            this.btnAgregarAtleta.TabIndex = 1;
            this.btnAgregarAtleta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAtleta.UseVisualStyleBackColor = false;
            this.btnAgregarAtleta.Click += new System.EventHandler(this.btnAgregarAtleta_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(192, 470);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(63, 470);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(192, 470);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 100);
            this.panel1.TabIndex = 0;
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
            this.btnMenu.Size = new System.Drawing.Size(161, 46);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "           Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 10;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.btnMinimizarVentana);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.btnCerrarVentana);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1054, 40);
            this.panel7.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panel4.Location = new System.Drawing.Point(977, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(74, 10);
            this.panel4.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(210)))), ((int)(((byte)(15)))));
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 10);
            this.panel2.TabIndex = 3;
            // 
            // btnMinimizarVentana
            // 
            this.btnMinimizarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizarVentana.FlatAppearance.BorderSize = 0;
            this.btnMinimizarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarVentana.Image")));
            this.btnMinimizarVentana.Location = new System.Drawing.Point(983, 3);
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
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarVentana.FlatAppearance.BorderSize = 0;
            this.btnCerrarVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
            this.btnCerrarVentana.Location = new System.Drawing.Point(1013, 3);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(31, 31);
            this.btnCerrarVentana.TabIndex = 0;
            this.btnCerrarVentana.UseVisualStyleBackColor = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // timerDataGridView
            // 
            this.timerDataGridView.Interval = 10;
            this.timerDataGridView.Tick += new System.EventHandler(this.timerDataGridView_Tick);
            // 
            // Ventana
            // 
            this.Ventana.BackColor = System.Drawing.Color.White;
            this.Ventana.Controls.Add(this.panel9);
            this.Ventana.Controls.Add(this.panel8);
            this.Ventana.Controls.Add(this.panel6);
            this.Ventana.Controls.Add(this.panel5);
            this.Ventana.Controls.Add(this.btnRefrescar);
            this.Ventana.Controls.Add(this.btnEditarAtleta);
            this.Ventana.Controls.Add(this.btnAgregarAtleta);
            this.Ventana.Controls.Add(this.btnBorarAtleta);
            this.Ventana.Controls.Add(this.dataGridViewAtletas);
            this.Ventana.Location = new System.Drawing.Point(195, 46);
            this.Ventana.MaximumSize = new System.Drawing.Size(992, 460);
            this.Ventana.MinimumSize = new System.Drawing.Size(847, 460);
            this.Ventana.Name = "Ventana";
            this.Ventana.Size = new System.Drawing.Size(849, 460);
            this.Ventana.TabIndex = 1;
            this.Ventana.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panel9.Location = new System.Drawing.Point(133, 451);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(37, 3);
            this.panel9.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panel8.Location = new System.Drawing.Point(90, 451);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(37, 3);
            this.panel8.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panel6.Location = new System.Drawing.Point(47, 451);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(37, 3);
            this.panel6.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(169)))));
            this.panel5.Location = new System.Drawing.Point(4, 451);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(37, 3);
            this.panel5.TabIndex = 5;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.DimGray;
            this.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(4, 411);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(37, 43);
            this.btnRefrescar.TabIndex = 4;
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // dataGridViewAtletas
            // 
            this.dataGridViewAtletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAtletas.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAtletas.Name = "dataGridViewAtletas";
            this.dataGridViewAtletas.Size = new System.Drawing.Size(843, 402);
            this.dataGridViewAtletas.TabIndex = 0;
            this.dataGridViewAtletas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAtletas_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(908, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 96);
            this.label2.TabIndex = 10;
            this.label2.Text = "           Creado por:\r\n\r\n       Santiago Gasco\r\n         Lucas Mujica\r\n         " +
    " Tomas Peña\r\n      Nahuel Rodriguez";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(921, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 118);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 510);
            this.Controls.Add(this.Ventana);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.Ventana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtletas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnListarAtleta;
        private System.Windows.Forms.Button btnEditarAtleta;
        private System.Windows.Forms.Button btnBorarAtleta;
        private System.Windows.Forms.Button btnAgregarAtleta;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnMinimizarVentana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarVentana;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timerDataGridView;
        private System.Windows.Forms.Panel Ventana;
        private System.Windows.Forms.DataGridView dataGridViewAtletas;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}