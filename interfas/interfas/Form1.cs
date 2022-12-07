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
                string parrilla = cmBxParrillas.SelectedItem.ToString();
                string temperatura = numericTemperatura.Value.ToString();

                int hr = int.Parse(numericHoras.Value.ToString());
                int min = int.Parse(numericMinutos.Value.ToString());
                int seg = int.Parse(numericSegundos.Value.ToString());

                //iniciar contadores
                if (cmBxParrillas.SelectedItem.ToString()=="1")
                {
                    hrdes1=hr;
                    mindes1= min;
                    segdes1= seg;
                    temperaturaDeseada1=int.Parse(numericTemperatura.Value.ToString());
                    labelTemp1.Text ="--:--:--";
                    timer1.Enabled=true;
                    encenderParrilla("1");

                }
                else if (cmBxParrillas.SelectedItem.ToString()=="2")
                {
                    hrdes2=hr;
                    mindes2= min;
                    segdes2= seg;
                    temperaturaDeseada2=int.Parse(numericTemperatura.Value.ToString());
                    labelTemp2.Text ="--:--:--";
                    timer2.Enabled =true;
                    encenderParrilla("2");
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
            compruebaTemperaturaActual();
            if (temperaturaActual1>=temperaturaDeseada1)//comprueba que la temperatura sea desada
            {   //comprueba si quedan segundos si no restablese a 60 y resta minutos, luego repite operacion con las horas
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
                            //una vez que conclueye el temporizador apaga las animaciones y envia
                            //una señal de apagado de la parrilla por el puerto serie
                            segdes1 = 0;
                            timer1.Stop();
                            apagarParrilla("1");
                        }

                    }
                }

                labelTemp1.Text =hrdes1+" : " +mindes1+ " : " +segdes1;

            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            compruebaTemperaturaActual();
            if (temperaturaActual2>=temperaturaDeseada2)
            {//comprueba si quedan segundos si no restablese a 60 y resta minutos, luego repite operacion con las horas
                if (segdes2>0)
                {
                    segdes2--;
                }
                else
                {
                    segdes2 = 60;
                    if (mindes2>0)
                    {
                        segdes2 = 60;
                        mindes2 --;
                    }
                    else
                    {
                        if (hrdes2>0)
                        {
                            hrdes2--;
                        }
                        else
                        {
                            //una vez que conclueye el temporizador apaga las animaciones y envia
                            //una señal de apagado de la parrilla por el puerto serie
                            segdes2 = 0;
                            timer2.Stop();
                            apagarParrilla("2");
                        }

                    }
                }

                labelTemp2.Text =hrdes2+" : " +mindes2+ " : " +segdes2;

            }
        }
        private void compruebaTemperaturaActual()
        {
            string entradaSerie;
            if (PuertoSerie.IsOpen)
            {
                entradaSerie=PuertoSerie.ReadLine();
            }
            else
            {
                MessageBox.Show("Puerto no conectado");
            }
            //resta asignar la temperatura conforme a la entrada

        }
        private void enviarTiempo() {
            if (PuertoSerie.IsOpen)
            {
                //resta enviar tiempo
            }
            else
            {
                MessageBox.Show("Puerto no conectado");
            }
        }
        private void encenderParrilla(string parrilla)
        {
            if (PuertoSerie.IsOpen)
            {
                if (parrilla=="1")
                {
                    pictureBoxFogata1.Enabled = true;
                    PuertoSerie.WriteLine("E1");

                }
                else if (parrilla=="2")
                {
                    pictureBoxFogata2.Enabled = true;
                    PuertoSerie.WriteLine("E2");

                }
                else
                {
                    pictureBoxFogata1.Enabled = true;
                    PuertoSerie.WriteLine("E1");

                    pictureBoxFogata2.Enabled = true;
                    PuertoSerie.WriteLine("E2");

                }
            }
            else
            {
                MessageBox.Show("Puerto no conectado");
            }
        }
        private void apagarParrilla(string parrilla) {
            if (PuertoSerie.IsOpen)
            {
                if (parrilla=="1")
                {
                    pictureBoxFogata1.Enabled = false;
                    PuertoSerie.WriteLine("A1");

                }
                else if (parrilla=="2")
                {
                    pictureBoxFogata2.Enabled = false;
                    PuertoSerie.WriteLine("A2");

                }
                else
                {
                    pictureBoxFogata1.Enabled = false;
                    PuertoSerie.WriteLine("A1");

                    pictureBoxFogata2.Enabled = false;
                    PuertoSerie.WriteLine("A2");

                }
            }
            else
            {
                MessageBox.Show("Puerto no conectado");
            }
        }

        private void bEncender1_Click(object sender, EventArgs e)
        {
            encenderParrilla("1");
        }

        private void bEncender2_Click(object sender, EventArgs e)
        {
            encenderParrilla("2");
        }

        private void bApagar1_Click(object sender, EventArgs e)
        {
            apagarParrilla("1");
            timer1.Stop();
        }

        private void bApagar2_Click(object sender, EventArgs e)
        {
            apagarParrilla("2");
            timer2.Stop();
        }

        private void bContinuar1_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true;
            encenderParrilla("1");
        }

        private void bContinuar2_Click(object sender, EventArgs e)
        {
            timer2.Enabled=true;
            encenderParrilla("2");
        }
    }
}
