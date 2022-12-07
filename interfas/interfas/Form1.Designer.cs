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
            this.panelConexion = new System.Windows.Forms.Panel();
            this.labelConexion = new System.Windows.Forms.Label();
            this.lablelConfiguracion = new System.Windows.Forms.Label();
            this.cmBxParrillas = new System.Windows.Forms.ComboBox();
            this.lablelParrilla = new System.Windows.Forms.Label();
            this.labelPredeterminados = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelTemperatura = new System.Windows.Forms.Label();
            this.labelHoras = new System.Windows.Forms.Label();
            this.configuracion = new System.Windows.Forms.Panel();
            this.numericTemperatura = new System.Windows.Forms.NumericUpDown();
            this.labelResistencia = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelPotencia = new System.Windows.Forms.Label();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.numericHoras = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericSegundos = new System.Windows.Forms.NumericUpDown();
            this.lablelMinutos = new System.Windows.Forms.Label();
            this.labelSegundos = new System.Windows.Forms.Label();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelConexion.SuspendLayout();
            this.configuracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTemperatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSegundos)).BeginInit();
            this.SuspendLayout();
            // 
            // CmBxPuertos
            // 
            this.CmBxPuertos.FormattingEnabled = true;
            this.CmBxPuertos.Location = new System.Drawing.Point(84, 36);
            this.CmBxPuertos.Name = "CmBxPuertos";
            this.CmBxPuertos.Size = new System.Drawing.Size(121, 21);
            this.CmBxPuertos.TabIndex = 0;
            this.CmBxPuertos.SelectedIndexChanged += new System.EventHandler(this.CmBxPuertos_SelectedIndexChanged);
            // 
            // bConectar
            // 
            this.bConectar.Location = new System.Drawing.Point(228, 36);
            this.bConectar.Name = "bConectar";
            this.bConectar.Size = new System.Drawing.Size(94, 23);
            this.bConectar.TabIndex = 1;
            this.bConectar.Text = "Conectar";
            this.bConectar.UseVisualStyleBackColor = true;
            this.bConectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDesconectar
            // 
            this.bDesconectar.Location = new System.Drawing.Point(343, 36);
            this.bDesconectar.Name = "bDesconectar";
            this.bDesconectar.Size = new System.Drawing.Size(89, 23);
            this.bDesconectar.TabIndex = 2;
            this.bDesconectar.Text = "Desconectar";
            this.bDesconectar.UseVisualStyleBackColor = true;
            this.bDesconectar.Click += new System.EventHandler(this.bDesconectar_Click);
            // 
            // bRecargarPuertos
            // 
            this.bRecargarPuertos.Location = new System.Drawing.Point(3, 34);
            this.bRecargarPuertos.Name = "bRecargarPuertos";
            this.bRecargarPuertos.Size = new System.Drawing.Size(75, 23);
            this.bRecargarPuertos.TabIndex = 3;
            this.bRecargarPuertos.Text = "Recargar";
            this.bRecargarPuertos.UseVisualStyleBackColor = true;
            this.bRecargarPuertos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelConexion
            // 
            this.panelConexion.BackColor = System.Drawing.Color.Transparent;
            this.panelConexion.Controls.Add(this.labelConexion);
            this.panelConexion.Controls.Add(this.bRecargarPuertos);
            this.panelConexion.Controls.Add(this.bDesconectar);
            this.panelConexion.Controls.Add(this.CmBxPuertos);
            this.panelConexion.Controls.Add(this.bConectar);
            this.panelConexion.Location = new System.Drawing.Point(38, 15);
            this.panelConexion.Name = "panelConexion";
            this.panelConexion.Size = new System.Drawing.Size(482, 71);
            this.panelConexion.TabIndex = 4;
            this.panelConexion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelConexion
            // 
            this.labelConexion.AutoSize = true;
            this.labelConexion.Location = new System.Drawing.Point(-3, 0);
            this.labelConexion.Name = "labelConexion";
            this.labelConexion.Size = new System.Drawing.Size(143, 13);
            this.labelConexion.TabIndex = 4;
            this.labelConexion.Text = "Conexion con el puerto serial";
            this.labelConexion.Click += new System.EventHandler(this.label1_Click);
            // 
            // lablelConfiguracion
            // 
            this.lablelConfiguracion.AutoSize = true;
            this.lablelConfiguracion.Location = new System.Drawing.Point(0, 0);
            this.lablelConfiguracion.Name = "lablelConfiguracion";
            this.lablelConfiguracion.Size = new System.Drawing.Size(72, 13);
            this.lablelConfiguracion.TabIndex = 0;
            this.lablelConfiguracion.Text = "Configuracion";
            this.lablelConfiguracion.Click += new System.EventHandler(this.lableConfiguracion_Click);
            // 
            // cmBxParrillas
            // 
            this.cmBxParrillas.FormattingEnabled = true;
            this.cmBxParrillas.Location = new System.Drawing.Point(81, 30);
            this.cmBxParrillas.Name = "cmBxParrillas";
            this.cmBxParrillas.Size = new System.Drawing.Size(121, 21);
            this.cmBxParrillas.TabIndex = 1;
            this.cmBxParrillas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lablelParrilla
            // 
            this.lablelParrilla.AutoSize = true;
            this.lablelParrilla.Location = new System.Drawing.Point(37, 30);
            this.lablelParrilla.Name = "lablelParrilla";
            this.lablelParrilla.Size = new System.Drawing.Size(38, 13);
            this.lablelParrilla.TabIndex = 2;
            this.lablelParrilla.Text = "Parrilla";
            this.lablelParrilla.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelPredeterminados
            // 
            this.labelPredeterminados.AutoSize = true;
            this.labelPredeterminados.Location = new System.Drawing.Point(225, 30);
            this.labelPredeterminados.Name = "labelPredeterminados";
            this.labelPredeterminados.Size = new System.Drawing.Size(86, 13);
            this.labelPredeterminados.TabIndex = 3;
            this.labelPredeterminados.Text = "Predeterminados";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(317, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // labelTemperatura
            // 
            this.labelTemperatura.AutoSize = true;
            this.labelTemperatura.Location = new System.Drawing.Point(17, 91);
            this.labelTemperatura.Name = "labelTemperatura";
            this.labelTemperatura.Size = new System.Drawing.Size(114, 13);
            this.labelTemperatura.TabIndex = 5;
            this.labelTemperatura.Text = "Temperatura deseada ";
            // 
            // labelHoras
            // 
            this.labelHoras.AutoSize = true;
            this.labelHoras.Location = new System.Drawing.Point(20, 145);
            this.labelHoras.Name = "labelHoras";
            this.labelHoras.Size = new System.Drawing.Size(35, 13);
            this.labelHoras.TabIndex = 6;
            this.labelHoras.Text = "Horas";
            this.labelHoras.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // configuracion
            // 
            this.configuracion.BackColor = System.Drawing.Color.Transparent;
            this.configuracion.Controls.Add(this.button1);
            this.configuracion.Controls.Add(this.buttonIniciar);
            this.configuracion.Controls.Add(this.labelSegundos);
            this.configuracion.Controls.Add(this.lablelMinutos);
            this.configuracion.Controls.Add(this.numericSegundos);
            this.configuracion.Controls.Add(this.numericUpDown2);
            this.configuracion.Controls.Add(this.numericHoras);
            this.configuracion.Controls.Add(this.labelHoras);
            this.configuracion.Controls.Add(this.labelTiempo);
            this.configuracion.Controls.Add(this.numericUpDown1);
            this.configuracion.Controls.Add(this.numericTemperatura);
            this.configuracion.Controls.Add(this.labelPotencia);
            this.configuracion.Controls.Add(this.labelResistencia);
            this.configuracion.Controls.Add(this.comboBox1);
            this.configuracion.Controls.Add(this.labelTemperatura);
            this.configuracion.Controls.Add(this.labelPredeterminados);
            this.configuracion.Controls.Add(this.lablelParrilla);
            this.configuracion.Controls.Add(this.cmBxParrillas);
            this.configuracion.Controls.Add(this.lablelConfiguracion);
            this.configuracion.Location = new System.Drawing.Point(38, 107);
            this.configuracion.Name = "configuracion";
            this.configuracion.Size = new System.Drawing.Size(482, 203);
            this.configuracion.TabIndex = 5;
            // 
            // numericTemperatura
            // 
            this.numericTemperatura.Location = new System.Drawing.Point(207, 91);
            this.numericTemperatura.Name = "numericTemperatura";
            this.numericTemperatura.Size = new System.Drawing.Size(41, 20);
            this.numericTemperatura.TabIndex = 7;
            // 
            // labelResistencia
            // 
            this.labelResistencia.AutoSize = true;
            this.labelResistencia.Location = new System.Drawing.Point(17, 59);
            this.labelResistencia.Name = "labelResistencia";
            this.labelResistencia.Size = new System.Drawing.Size(151, 13);
            this.labelResistencia.TabIndex = 5;
            this.labelResistencia.Text = "Configuracion de la resistencia";
            this.labelResistencia.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(397, 89);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // labelPotencia
            // 
            this.labelPotencia.AutoSize = true;
            this.labelPotencia.Location = new System.Drawing.Point(270, 93);
            this.labelPotencia.Name = "labelPotencia";
            this.labelPotencia.Size = new System.Drawing.Size(121, 13);
            this.labelPotencia.TabIndex = 6;
            this.labelPotencia.Text = "Porcentaje de Potencia ";
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Location = new System.Drawing.Point(20, 122);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(171, 13);
            this.labelTiempo.TabIndex = 9;
            this.labelTiempo.Text = "Tiempo en la temperatura deseada";
            // 
            // numericHoras
            // 
            this.numericHoras.Location = new System.Drawing.Point(75, 143);
            this.numericHoras.Name = "numericHoras";
            this.numericHoras.Size = new System.Drawing.Size(65, 20);
            this.numericHoras.TabIndex = 10;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(206, 145);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown2.TabIndex = 11;
            // 
            // numericSegundos
            // 
            this.numericSegundos.Location = new System.Drawing.Point(357, 143);
            this.numericSegundos.Name = "numericSegundos";
            this.numericSegundos.Size = new System.Drawing.Size(65, 20);
            this.numericSegundos.TabIndex = 12;
            // 
            // lablelMinutos
            // 
            this.lablelMinutos.AutoSize = true;
            this.lablelMinutos.Location = new System.Drawing.Point(156, 145);
            this.lablelMinutos.Name = "lablelMinutos";
            this.lablelMinutos.Size = new System.Drawing.Size(44, 13);
            this.lablelMinutos.TabIndex = 13;
            this.lablelMinutos.Text = "Minutos";
            // 
            // labelSegundos
            // 
            this.labelSegundos.AutoSize = true;
            this.labelSegundos.Location = new System.Drawing.Point(286, 145);
            this.labelSegundos.Name = "labelSegundos";
            this.labelSegundos.Size = new System.Drawing.Size(55, 13);
            this.labelSegundos.TabIndex = 14;
            this.labelSegundos.Text = "Segundos";
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(407, 180);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(75, 23);
            this.buttonIniciar.TabIndex = 15;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Agregar a Predeterminados";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // calentador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.configuracion);
            this.Controls.Add(this.panelConexion);
            this.Name = "calentador";
            this.Text = "calentador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelConexion.ResumeLayout(false);
            this.panelConexion.PerformLayout();
            this.configuracion.ResumeLayout(false);
            this.configuracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTemperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSegundos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort PuertoSerie;
        private System.Windows.Forms.ComboBox CmBxPuertos;
        private System.Windows.Forms.Button bConectar;
        private System.Windows.Forms.Button bDesconectar;
        private System.Windows.Forms.Button bRecargarPuertos;
        private System.Windows.Forms.Panel panelConexion;
        private System.Windows.Forms.Label labelConexion;
        private System.Windows.Forms.Label lablelConfiguracion;
        private System.Windows.Forms.Label lablelParrilla;
        private System.Windows.Forms.ComboBox cmBxParrillas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelPredeterminados;
        private System.Windows.Forms.Label labelHoras;
        private System.Windows.Forms.Label labelTemperatura;
        private System.Windows.Forms.Panel configuracion;
        private System.Windows.Forms.NumericUpDown numericTemperatura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Label labelSegundos;
        private System.Windows.Forms.Label lablelMinutos;
        private System.Windows.Forms.NumericUpDown numericSegundos;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericHoras;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelPotencia;
        private System.Windows.Forms.Label labelResistencia;
    }
}

