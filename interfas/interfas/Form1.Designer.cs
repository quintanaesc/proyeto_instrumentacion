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
            this.bAgregar = new System.Windows.Forms.Button();
            this.bIniciar = new System.Windows.Forms.Button();
            this.labelSegundos = new System.Windows.Forms.Label();
            this.lablelMinutos = new System.Windows.Forms.Label();
            this.numericSegundos = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericHoras = new System.Windows.Forms.NumericUpDown();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.numericTemperatura = new System.Windows.Forms.NumericUpDown();
            this.labelResistencia = new System.Windows.Forms.Label();
            this.panelFogata1 = new System.Windows.Forms.Panel();
            this.pictureBoxFogata1 = new System.Windows.Forms.PictureBox();
            this.labelParrilla1 = new System.Windows.Forms.Label();
            this.labelTemPar1 = new System.Windows.Forms.Label();
            this.labelTimePar1 = new System.Windows.Forms.Label();
            this.labelTempAc1 = new System.Windows.Forms.Label();
            this.labelTemp1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTemp2 = new System.Windows.Forms.Label();
            this.labelTempAc2 = new System.Windows.Forms.Label();
            this.labelTimePar2 = new System.Windows.Forms.Label();
            this.labelTemPar2 = new System.Windows.Forms.Label();
            this.labelParrilla2 = new System.Windows.Forms.Label();
            this.pictureBoxFogata2 = new System.Windows.Forms.PictureBox();
            this.bEncender1 = new System.Windows.Forms.Button();
            this.bApagar1 = new System.Windows.Forms.Button();
            this.bContinuar1 = new System.Windows.Forms.Button();
            this.bContinuar2 = new System.Windows.Forms.Button();
            this.bApagar2 = new System.Windows.Forms.Button();
            this.bEncender2 = new System.Windows.Forms.Button();
            this.panelConexion.SuspendLayout();
            this.configuracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSegundos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTemperatura)).BeginInit();
            this.panelFogata1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFogata1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFogata2)).BeginInit();
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
            this.configuracion.Controls.Add(this.bAgregar);
            this.configuracion.Controls.Add(this.bIniciar);
            this.configuracion.Controls.Add(this.labelSegundos);
            this.configuracion.Controls.Add(this.lablelMinutos);
            this.configuracion.Controls.Add(this.numericSegundos);
            this.configuracion.Controls.Add(this.numericUpDown2);
            this.configuracion.Controls.Add(this.numericHoras);
            this.configuracion.Controls.Add(this.labelHoras);
            this.configuracion.Controls.Add(this.labelTiempo);
            this.configuracion.Controls.Add(this.numericTemperatura);
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
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(252, 180);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(149, 23);
            this.bAgregar.TabIndex = 16;
            this.bAgregar.Text = "Agregar a Predeterminados";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // bIniciar
            // 
            this.bIniciar.Location = new System.Drawing.Point(407, 180);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(75, 23);
            this.bIniciar.TabIndex = 15;
            this.bIniciar.Text = "Iniciar";
            this.bIniciar.UseVisualStyleBackColor = true;
            this.bIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
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
            // lablelMinutos
            // 
            this.lablelMinutos.AutoSize = true;
            this.lablelMinutos.Location = new System.Drawing.Point(156, 145);
            this.lablelMinutos.Name = "lablelMinutos";
            this.lablelMinutos.Size = new System.Drawing.Size(44, 13);
            this.lablelMinutos.TabIndex = 13;
            this.lablelMinutos.Text = "Minutos";
            // 
            // numericSegundos
            // 
            this.numericSegundos.Location = new System.Drawing.Point(357, 143);
            this.numericSegundos.Name = "numericSegundos";
            this.numericSegundos.Size = new System.Drawing.Size(65, 20);
            this.numericSegundos.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(206, 145);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown2.TabIndex = 11;
            // 
            // numericHoras
            // 
            this.numericHoras.Location = new System.Drawing.Point(75, 143);
            this.numericHoras.Name = "numericHoras";
            this.numericHoras.Size = new System.Drawing.Size(65, 20);
            this.numericHoras.TabIndex = 10;
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
            // numericTemperatura
            // 
            this.numericTemperatura.Location = new System.Drawing.Point(148, 91);
            this.numericTemperatura.Name = "numericTemperatura";
            this.numericTemperatura.Size = new System.Drawing.Size(75, 20);
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
            // panelFogata1
            // 
            this.panelFogata1.BackColor = System.Drawing.Color.Transparent;
            this.panelFogata1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFogata1.Controls.Add(this.bContinuar1);
            this.panelFogata1.Controls.Add(this.bApagar1);
            this.panelFogata1.Controls.Add(this.bEncender1);
            this.panelFogata1.Controls.Add(this.labelTemp1);
            this.panelFogata1.Controls.Add(this.labelTempAc1);
            this.panelFogata1.Controls.Add(this.labelTimePar1);
            this.panelFogata1.Controls.Add(this.labelTemPar1);
            this.panelFogata1.Controls.Add(this.labelParrilla1);
            this.panelFogata1.Controls.Add(this.pictureBoxFogata1);
            this.panelFogata1.Location = new System.Drawing.Point(41, 320);
            this.panelFogata1.Name = "panelFogata1";
            this.panelFogata1.Size = new System.Drawing.Size(220, 149);
            this.panelFogata1.TabIndex = 6;
            // 
            // pictureBoxFogata1
            // 
            this.pictureBoxFogata1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFogata1.ErrorImage")));
            this.pictureBoxFogata1.InitialImage = null;
            this.pictureBoxFogata1.Location = new System.Drawing.Point(0, 17);
            this.pictureBoxFogata1.Name = "pictureBoxFogata1";
            this.pictureBoxFogata1.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFogata1.TabIndex = 0;
            this.pictureBoxFogata1.TabStop = false;
            this.pictureBoxFogata1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelParrilla1
            // 
            this.labelParrilla1.AutoSize = true;
            this.labelParrilla1.Location = new System.Drawing.Point(-3, 0);
            this.labelParrilla1.Name = "labelParrilla1";
            this.labelParrilla1.Size = new System.Drawing.Size(47, 13);
            this.labelParrilla1.TabIndex = 7;
            this.labelParrilla1.Text = "Parrilla 1";
            // 
            // labelTemPar1
            // 
            this.labelTemPar1.AutoSize = true;
            this.labelTemPar1.Location = new System.Drawing.Point(110, 11);
            this.labelTemPar1.Name = "labelTemPar1";
            this.labelTemPar1.Size = new System.Drawing.Size(105, 13);
            this.labelTemPar1.TabIndex = 8;
            this.labelTemPar1.Text = "Temperatura actual: ";
            // 
            // labelTimePar1
            // 
            this.labelTimePar1.AutoSize = true;
            this.labelTimePar1.Location = new System.Drawing.Point(116, 55);
            this.labelTimePar1.Name = "labelTimePar1";
            this.labelTimePar1.Size = new System.Drawing.Size(86, 13);
            this.labelTimePar1.TabIndex = 9;
            this.labelTimePar1.Text = "Tiempo restante:";
            this.labelTimePar1.Click += new System.EventHandler(this.labelTimePar1_Click);
            // 
            // labelTempAc1
            // 
            this.labelTempAc1.AutoSize = true;
            this.labelTempAc1.Location = new System.Drawing.Point(116, 33);
            this.labelTempAc1.Name = "labelTempAc1";
            this.labelTempAc1.Size = new System.Drawing.Size(27, 13);
            this.labelTempAc1.TabIndex = 10;
            this.labelTempAc1.Text = "0 C°";
            // 
            // labelTemp1
            // 
            this.labelTemp1.AutoSize = true;
            this.labelTemp1.Location = new System.Drawing.Point(116, 78);
            this.labelTemp1.Name = "labelTemp1";
            this.labelTemp1.Size = new System.Drawing.Size(49, 13);
            this.labelTemp1.TabIndex = 11;
            this.labelTemp1.Text = "00:00:00";
            this.labelTemp1.Click += new System.EventHandler(this.labelTemp1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bContinuar2);
            this.panel1.Controls.Add(this.bApagar2);
            this.panel1.Controls.Add(this.bEncender2);
            this.panel1.Controls.Add(this.labelTemp2);
            this.panel1.Controls.Add(this.labelTempAc2);
            this.panel1.Controls.Add(this.labelTimePar2);
            this.panel1.Controls.Add(this.labelTemPar2);
            this.panel1.Controls.Add(this.labelParrilla2);
            this.panel1.Controls.Add(this.pictureBoxFogata2);
            this.panel1.Location = new System.Drawing.Point(300, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 148);
            this.panel1.TabIndex = 12;
            // 
            // labelTemp2
            // 
            this.labelTemp2.AutoSize = true;
            this.labelTemp2.Location = new System.Drawing.Point(116, 77);
            this.labelTemp2.Name = "labelTemp2";
            this.labelTemp2.Size = new System.Drawing.Size(49, 13);
            this.labelTemp2.TabIndex = 11;
            this.labelTemp2.Text = "00:00:00";
            // 
            // labelTempAc2
            // 
            this.labelTempAc2.AutoSize = true;
            this.labelTempAc2.Location = new System.Drawing.Point(116, 32);
            this.labelTempAc2.Name = "labelTempAc2";
            this.labelTempAc2.Size = new System.Drawing.Size(27, 13);
            this.labelTempAc2.TabIndex = 10;
            this.labelTempAc2.Text = "0 C°";
            // 
            // labelTimePar2
            // 
            this.labelTimePar2.AutoSize = true;
            this.labelTimePar2.Location = new System.Drawing.Point(116, 54);
            this.labelTimePar2.Name = "labelTimePar2";
            this.labelTimePar2.Size = new System.Drawing.Size(86, 13);
            this.labelTimePar2.TabIndex = 9;
            this.labelTimePar2.Text = "Tiempo restante:";
            // 
            // labelTemPar2
            // 
            this.labelTemPar2.AutoSize = true;
            this.labelTemPar2.Location = new System.Drawing.Point(110, 10);
            this.labelTemPar2.Name = "labelTemPar2";
            this.labelTemPar2.Size = new System.Drawing.Size(105, 13);
            this.labelTemPar2.TabIndex = 8;
            this.labelTemPar2.Text = "Temperatura actual: ";
            // 
            // labelParrilla2
            // 
            this.labelParrilla2.AutoSize = true;
            this.labelParrilla2.Location = new System.Drawing.Point(-3, 0);
            this.labelParrilla2.Name = "labelParrilla2";
            this.labelParrilla2.Size = new System.Drawing.Size(47, 13);
            this.labelParrilla2.TabIndex = 7;
            this.labelParrilla2.Text = "Parrilla 2";
            // 
            // pictureBoxFogata2
            // 
            this.pictureBoxFogata2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFogata2.ErrorImage")));
            this.pictureBoxFogata2.InitialImage = null;
            this.pictureBoxFogata2.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxFogata2.Name = "pictureBoxFogata2";
            this.pictureBoxFogata2.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFogata2.TabIndex = 0;
            this.pictureBoxFogata2.TabStop = false;
            // 
            // bEncender1
            // 
            this.bEncender1.Location = new System.Drawing.Point(3, 121);
            this.bEncender1.Name = "bEncender1";
            this.bEncender1.Size = new System.Drawing.Size(68, 23);
            this.bEncender1.TabIndex = 12;
            this.bEncender1.Text = "Encender";
            this.bEncender1.UseVisualStyleBackColor = true;
            // 
            // bApagar1
            // 
            this.bApagar1.Location = new System.Drawing.Point(80, 121);
            this.bApagar1.Name = "bApagar1";
            this.bApagar1.Size = new System.Drawing.Size(59, 23);
            this.bApagar1.TabIndex = 13;
            this.bApagar1.Text = "Apagar";
            this.bApagar1.UseVisualStyleBackColor = true;
            // 
            // bContinuar1
            // 
            this.bContinuar1.Location = new System.Drawing.Point(145, 121);
            this.bContinuar1.Name = "bContinuar1";
            this.bContinuar1.Size = new System.Drawing.Size(70, 23);
            this.bContinuar1.TabIndex = 14;
            this.bContinuar1.Text = "Continuar";
            this.bContinuar1.UseVisualStyleBackColor = true;
            // 
            // bContinuar2
            // 
            this.bContinuar2.Location = new System.Drawing.Point(144, 122);
            this.bContinuar2.Name = "bContinuar2";
            this.bContinuar2.Size = new System.Drawing.Size(70, 23);
            this.bContinuar2.TabIndex = 17;
            this.bContinuar2.Text = "Continuar";
            this.bContinuar2.UseVisualStyleBackColor = true;
            // 
            // bApagar2
            // 
            this.bApagar2.Location = new System.Drawing.Point(79, 122);
            this.bApagar2.Name = "bApagar2";
            this.bApagar2.Size = new System.Drawing.Size(59, 23);
            this.bApagar2.TabIndex = 16;
            this.bApagar2.Text = "Apagar";
            this.bApagar2.UseVisualStyleBackColor = true;
            // 
            // bEncender2
            // 
            this.bEncender2.Location = new System.Drawing.Point(2, 122);
            this.bEncender2.Name = "bEncender2";
            this.bEncender2.Size = new System.Drawing.Size(68, 23);
            this.bEncender2.TabIndex = 15;
            this.bEncender2.Text = "Encender";
            this.bEncender2.UseVisualStyleBackColor = true;
            // 
            // calentador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFogata1);
            this.Controls.Add(this.configuracion);
            this.Controls.Add(this.panelConexion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(573, 520);
            this.MinimumSize = new System.Drawing.Size(573, 520);
            this.Name = "calentador";
            this.Text = "calentador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelConexion.ResumeLayout(false);
            this.panelConexion.PerformLayout();
            this.configuracion.ResumeLayout(false);
            this.configuracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSegundos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTemperatura)).EndInit();
            this.panelFogata1.ResumeLayout(false);
            this.panelFogata1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFogata1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFogata2)).EndInit();
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
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.Label labelSegundos;
        private System.Windows.Forms.Label lablelMinutos;
        private System.Windows.Forms.NumericUpDown numericSegundos;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericHoras;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label labelResistencia;
        private System.Windows.Forms.Panel panelFogata1;
        private System.Windows.Forms.PictureBox pictureBoxFogata1;
        private System.Windows.Forms.Label labelTimePar1;
        private System.Windows.Forms.Label labelTemPar1;
        private System.Windows.Forms.Label labelParrilla1;
        private System.Windows.Forms.Label labelTemp1;
        private System.Windows.Forms.Label labelTempAc1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTemp2;
        private System.Windows.Forms.Label labelTempAc2;
        private System.Windows.Forms.Label labelTimePar2;
        private System.Windows.Forms.Label labelTemPar2;
        private System.Windows.Forms.Label labelParrilla2;
        private System.Windows.Forms.PictureBox pictureBoxFogata2;
        private System.Windows.Forms.Button bContinuar1;
        private System.Windows.Forms.Button bApagar1;
        private System.Windows.Forms.Button bEncender1;
        private System.Windows.Forms.Button bContinuar2;
        private System.Windows.Forms.Button bApagar2;
        private System.Windows.Forms.Button bEncender2;
    }
}

