namespace interfas
{
    partial class calentador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calentador));
            this.PuertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.CmBxPuertos = new System.Windows.Forms.ComboBox();
            this.bConectar = new System.Windows.Forms.Button();
            this.bDesconectar = new System.Windows.Forms.Button();
            this.bRecargarPuertos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmBxPuertos
            // 
            this.CmBxPuertos.FormattingEnabled = true;
            this.CmBxPuertos.Location = new System.Drawing.Point(104, 12);
            this.CmBxPuertos.Name = "CmBxPuertos";
            this.CmBxPuertos.Size = new System.Drawing.Size(121, 21);
            this.CmBxPuertos.TabIndex = 0;
            // 
            // bConectar
            // 
            this.bConectar.Location = new System.Drawing.Point(254, 10);
            this.bConectar.Name = "bConectar";
            this.bConectar.Size = new System.Drawing.Size(75, 23);
            this.bConectar.TabIndex = 1;
            this.bConectar.Text = "Conectar";
            this.bConectar.UseVisualStyleBackColor = true;
            this.bConectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDesconectar
            // 
            this.bDesconectar.Location = new System.Drawing.Point(366, 10);
            this.bDesconectar.Name = "bDesconectar";
            this.bDesconectar.Size = new System.Drawing.Size(75, 23);
            this.bDesconectar.TabIndex = 2;
            this.bDesconectar.Text = "Desconectar";
            this.bDesconectar.UseVisualStyleBackColor = true;
            this.bDesconectar.Click += new System.EventHandler(this.bDesconectar_Click);
            // 
            // bRecargarPuertos
            // 
            this.bRecargarPuertos.Location = new System.Drawing.Point(12, 12);
            this.bRecargarPuertos.Name = "bRecargarPuertos";
            this.bRecargarPuertos.Size = new System.Drawing.Size(75, 23);
            this.bRecargarPuertos.TabIndex = 3;
            this.bRecargarPuertos.Text = "Recargar";
            this.bRecargarPuertos.UseVisualStyleBackColor = true;
            this.bRecargarPuertos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // calentador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bRecargarPuertos);
            this.Controls.Add(this.bDesconectar);
            this.Controls.Add(this.bConectar);
            this.Controls.Add(this.CmBxPuertos);
            this.Name = "calentador";
            this.Text = "calentador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort PuertoSerie;
        private System.Windows.Forms.ComboBox CmBxPuertos;
        private System.Windows.Forms.Button bConectar;
        private System.Windows.Forms.Button bDesconectar;
        private System.Windows.Forms.Button bRecargarPuertos;
    }
}

