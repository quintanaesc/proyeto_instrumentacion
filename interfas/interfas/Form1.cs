﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfas
{
    public partial class calentador : Form
    {
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
            string[] listaParrillas = new string[] {"1","2"};
            cmBxParrillas.DataSource = listaParrillas;

            //configuraciones predeterminadas
            string[] predeterminados;
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
    }
}
