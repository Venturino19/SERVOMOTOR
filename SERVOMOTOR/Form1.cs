using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SERVOMOTOR
{
    public partial class Form1 : Form
    {
        delegate void SetTextDelegate(string value);

        public SerialPort ArduinoPort
        {
            get;
        }
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM4";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.DataBits = 8;
            ArduinoPort.ReadTimeout = 1000;
            ArduinoPort.WriteTimeout = 1000;
            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            this.btConectar.Click += btConectar_Click;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string dato = ArduinoPort.ReadLine();
            EscribirTxt(dato);
        }

        private void EscribirTxt(string dato)
        {
            if (InvokeRequired)
                try
                {
                    Invoke(new SetTextDelegate(EscribirTxt), dato);
                }
                catch
                {
                    //Poner acción de aviso de error si es necesario
                }
            else
                lbTemp.Text = dato;
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ArduinoPort.IsOpen)
                    ArduinoPort.Open();
                if (int.TryParse(tbLimTemp.Text, out int temperatureLimit))
                {
                    //Convierte el valor a una cadena y luego en un arreglo de bytes
                    string limitString = temperatureLimit.ToString();
                    ArduinoPort.Write(limitString);
                }
                else
                {
                    MessageBox.Show("Ingresa un valor numerico valido");
                }
                lbConexion.Text = "Conexion OK";
                lbConexion.ForeColor = System.Drawing.Color.Lime;
            }
            catch
            {
                MessageBox.Show("Configure el puerto de comunicacion correcto o desconecte");
            }
        }

        private void btDesconectar_Click(object sender, EventArgs e)
        {
            btConectar.Enabled = true;
            btDesconectar.Enabled = false;
            if (ArduinoPort.IsOpen)
                ArduinoPort.Close();
            lbConexion.Text = "Desconectado";
            lbConexion.ForeColor = System.Drawing.Color.Red;
            lbTemp.Text = "00.0";

        }
    }
}