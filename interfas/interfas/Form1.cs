using System;
using System.Drawing;
using System.Windows.Forms;

namespace interfas
{
    public partial class calentador : Form
    {
        string ruta;

        int hrdes1;
        int mindes1;
        int segdes1;
        int segdes2;
        int mindes2;
        int hrdes2;

        int temperaturaDeseada1;
        int temperaturaDeseada2;
        int temperaturaActual1;
        int temperaturaActual2;

        public calentador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch; //establece el reescalamiento de la img de fondo

            //obtener los puertos coms en el combobox para los puertos
            string[] ListaPuertos = System.IO.Ports.SerialPort.GetPortNames();
            CmBxPuertos.DataSource = ListaPuertos;

            //Carga las parrillas activas
            string[] listaParrillas = new string[] { "1", "2" };
            cmBxParrillas.DataSource = listaParrillas;

            //carga de imagenes
            ruta =Environment.CurrentDirectory.Replace(@"interfas\bin\Debug", "")+
                    @"recursos\fogata.gif";
            pictureBoxFogata1.Image= Image.FromFile(ruta);
            pictureBoxFogata2.Image= Image.FromFile(ruta);
            pictureBoxFogata1.Enabled = false;
            pictureBoxFogata2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conecta el puerto serie
            try
            {
                string sPuerto = CmBxPuertos.SelectedItem.ToString();
                PuertoSerie.PortName = sPuerto;
                PuertoSerie.Open();
                MessageBox.Show("Puerto abierto");
            }
            catch
            {
                MessageBox.Show("No se encontro ningun puerto");
            }
        }

        private void bDesconectar_Click(object sender, EventArgs e)
        {
            //desconecta el puerto serie
            try
            {
                string sPuerto = CmBxPuertos.SelectedItem.ToString();
                if (PuertoSerie.IsOpen)
                {
                    PuertoSerie.Close();
                    MessageBox.Show("Puerto cerrado");
                }
            }
            catch
            {
                MessageBox.Show("No se encontro ningun puerto");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // recargar los puertos seriales
            string[] ListaPuertos = System.IO.Ports.SerialPort.GetPortNames();
            CmBxPuertos.DataSource = ListaPuertos;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lableConfiguracion_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CmBxPuertos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonIniciar_Click(object sender, EventArgs e)
        { // Envia los datos de configuracion por el puerto seri
          // e inicia la animacion para la parrilla correspondiente
            if (PuertoSerie.IsOpen)
            {
                //recoleccion de datos
                string tipo = "1";
                string parrilla = cmBxParrillas.SelectedItem.ToString();
                string temperatura = numericTemperatura.Value.ToString();

                int hr = int.Parse(numericHoras.Value.ToString());
                int min = int.Parse(numericMinutos.Value.ToString());
                int seg = int.Parse(numericSegundos.Value.ToString());
                string tiempo = ""+((3600*hr)+(60*min)+seg);

                string[] mensaje = new string[4] { tipo, parrilla, temperatura, tiempo };

                //envio por puerto serie

                //iniciar contador
                if (cmBxParrillas.SelectedItem.ToString()=="1")
                {
                    hrdes1=hr;
                    mindes1= min;
                    segdes1= seg;
                    temperaturaDeseada1=int.Parse(numericTemperatura.Value.ToString());
                    labelTemp1.Text ="--:--:--";
                    timer1.Enabled=true;

                }
                else if (cmBxParrillas.SelectedItem.ToString()=="2")
                {
                    hrdes2=hr;
                    mindes2= min;
                    segdes2= seg;
                    temperaturaDeseada2=int.Parse(numericTemperatura.Value.ToString());
                    labelTemp2.Text ="--:--:--";
                    timer2.Enabled =true;
                }
                //iniciar animacion de la fogata
                if (cmBxParrillas.SelectedItem.ToString()=="1")
                {
                    pictureBoxFogata1.Enabled = true;
                }
                else if (cmBxParrillas.SelectedItem.ToString()=="2")
                {
                    pictureBoxFogata2.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Puerto no conectado");
            }

        }


        private void labelTimePar1_Click(object sender, EventArgs e)
        {

        }

        private void labelTemp1_Click(object sender, EventArgs e)
        {

        }

        private void cmBxPredeterminados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            compruebaTemperaturaActual(1);
            if (temperaturaActual1==temperaturaDeseada1)
            {
                if (segdes1>0)
                {
                    segdes1--;
                }
                else
                {
                    segdes1 = 60;
                    if (mindes1>0)
                    {
                        segdes1 = 60;
                        mindes1--;
                    }
                    else
                    {
                        if (hrdes1>0)
                        {
                            hrdes1--;
                        }
                        else
                        {
                            segdes1 = 0;
                            timer1.Stop();
                            pictureBoxFogata1.Enabled = false;
                        }

                    }
                }

                labelTemp1.Text =hrdes1+" : " +mindes1+ " : " +segdes1;

            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            compruebaTemperaturaActual(1);
            if (temperaturaActual1==temperaturaDeseada1)
            {
                if (segdes1>0)
                {
                    segdes1--;
                }
                else
                {
                    segdes1 = 60;
                    if (mindes1>0)
                    {
                        segdes1 = 60;
                        mindes1--;
                    }
                    else
                    {
                        if (hrdes1>0)
                        {
                            hrdes1--;
                        }
                        else
                        {
                            segdes1 = 0;
                            timer1.Stop();
                            pictureBoxFogata1.Enabled = false;
                        }

                    }
                }

                labelTemp1.Text =hrdes1+" : " +mindes1+ " : " +segdes1;

            }
        }
    }
}
