
namespace InterfazProyecto1
{
    partial class FormCarga
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarga));
            this.imgKarate = new System.Windows.Forms.PictureBox();
            this.panelCarga = new System.Windows.Forms.Panel();
            this.timerCarga = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgKarate)).BeginInit();
            this.SuspendLayout();
            // 
            // imgKarate
            // 
            this.imgKarate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.imgKarate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgKarate.BackgroundImage")));
            this.imgKarate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgKarate.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgKarate.Location = new System.Drawing.Point(-2, 0);
            this.imgKarate.Name = "imgKarate";
            this.imgKarate.Size = new System.Drawing.Size(803, 422);
            this.imgKarate.TabIndex = 1;
            this.imgKarate.TabStop = false;
            // 
            // panelCarga
            // 
            this.panelCarga.BackColor = System.Drawing.Color.ForestGreen;
            this.panelCarga.Location = new System.Drawing.Point(-2, 419);
            this.panelCarga.Name = "panelCarga";
            this.panelCarga.Size = new System.Drawing.Size(77, 34);
            this.panelCarga.TabIndex = 2;
            // 
            // timerCarga
            // 
            this.timerCarga.Enabled = true;
            this.timerCarga.Interval = 15;
            this.timerCarga.Tick += new System.EventHandler(this.TimerCarga_Tick);
            // 
            // FormCarga
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCarga);
            this.Controls.Add(this.imgKarate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgKarate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgKarate;
        private System.Windows.Forms.Panel panelCarga;
        private System.Windows.Forms.Timer timerCarga;
    }
}

