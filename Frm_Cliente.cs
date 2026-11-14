using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Threading;
using System.Net;


namespace Cliente
{

    public partial class Frm_Cliente : Form
    {
        TcpClient client = new TcpClient();
        ASCIIEncoding encoder = new ASCIIEncoding();
        NetworkStream stream = null;
        byte[] buffer;
        string message = "";
        private const int LargoTrama = 24;
        private const int Capacidad = 67;

        public Frm_Cliente()
        {
            InitializeComponent();
        }

        private void Btn_Conectar_Click(object sender, EventArgs e)
        {
            Btn_Conectar.Enabled = false;
            Bnt_Enviar.Enabled = true;


            if (Txt_Servidor.Text == "")
            {
                MessageBox.Show("Por favor ingrese una dirección IP para el servidor", "Error al conectar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!client.Connected)
                {
                    try
                    {
                        client = new TcpClient();
                        IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(Txt_Servidor.Text), 30000);
                        client.Connect(serverEndPoint);
                        NetworkStream clientStream = client.GetStream();
                        buffer = encoder.GetBytes("Hello Server!");
                        clientStream.Write(buffer, 0, buffer.Length);
                        clientStream.Flush();

                        byte[] message2 = new byte[4096];
                        int bytesRead = clientStream.Read(message2, 0, 4096);

                        MessageBox.Show("Conexión Realizada con Exito");
                        Txt_Mensaje.Focus();

                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.ToString());
                    }
                }
                else
                {
                    try
                    {
                        client.Close();


                    }
                    catch (Exception Exc)
                    {
                        MessageBox.Show(Exc.ToString());
                    }
                }
            }
        }
        private void Btn_Desconectar_Click(object sender, EventArgs e)
        {
            Btn_Conectar.Enabled = true;
            Bnt_Enviar.Enabled = false;
            if (client.Connected)
                try
                {
                    client.Close();
                    MessageBox.Show("Desconexión Realizada con Exito");

                }
                catch (Exception Exc)
                {
                    MessageBox.Show(Exc.ToString());
                }
            pnlAsientos.Visible = true;
        }

        private void Bnt_Enviar_Click(object sender, EventArgs e)
        {
            //-1
            NetworkStream clientStream = client.GetStream();
            buffer = encoder.GetBytes(Txt_Mensaje.Text.Trim());
            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();

            //-2
            byte[] message2 = new byte[4096];
            int bytesRead = clientStream.Read(message2, 0, 4096);

            //-3
            string message3 = encoder.GetString(message2, 0, bytesRead);
            Txt_Mensaje.Text = message3;

            //-4
            TraduccionTrama(message3);
        }


        private void TraduccionTrama(string trama)
        {
            //1
            if (string.IsNullOrEmpty(trama))
            {
                return;
            }

            //-2 
            string digito = trama.Substring(0, 1);
            string estado;
            switch (digito)
            {
                case "0":
                    estado = "No hay asientos disponibles";
                    lblEstado.ForeColor = Color.Red;
                    break;
                case "1":
                    estado = "Transacción exitosa";
                    lblEstado.ForeColor = Color.Green;
                    break;
                case "3":
                    estado = "Excede la cantidad permitida, el número máximo de boletos es 5";
                    lblEstado.ForeColor = Color.Orange;
                    break;
                case "4":
                    estado = "Código de viaje no existe";
                    lblEstado.ForeColor = Color.Red;
                    break;
                case "5":
                    estado = "Formato invalido";
                    lblEstado.ForeColor = Color.Red;
                    break;
                default:
                    estado = "Error sin documentación";
                    lblEstado.ForeColor = Color.Red;
                    break;
            }
            lblEstado.Text = estado;
            if (digito != "1" || trama.Length < LargoTrama) return;

            //-3 
            string CodigoViaje = trama.Substring(1, 2);
            string Fila1 = trama.Substring(3, 2);
            string Asientos1 = trama.Substring(5, 5);
            string Fila2 = trama.Substring(10, 2);
            string Asientos2 = trama.Substring(12, 5);
            int MontoTransaccion = int.Parse(trama.Substring(17, 5));
            int AsientosDisponibles = int.Parse(trama.Substring(22, 2));

            //-4 
            string Viaje = CodigoViaje switch
            {
                "01" => "SAN JOSE - EL COCO",
                "02" => "EL COCO - SAN JOSE",
                _ => "Viaje " + CodigoViaje
            };
            txtRuta.Text = Viaje;

            //-5
            string fila1 = "Fila " + int.Parse(Fila1) + " - Asientos: " + GetAsientos(Asientos1);
            string fila2;
            if (Fila2 == "00")
            {
                fila2 = "no fue necesaria la fila 2";
            }
            else
            {
                fila2 = "Fila " + int.Parse(Fila2) + " - Asientos: " + GetAsientos(Asientos2);
            }
            txtBoxFila1.Text = fila1;
            txtBoxFila2.Text = fila2;

            //-6
            string monto = "Monto de la transacción: " + MontoTransaccion.ToString("N0") + " Colones";
            txtBoxMonto.Text = monto;



            //-7
            PintarMapa(Fila1, Asientos1, Fila2, Asientos2, AsientosDisponibles);
        }

        private string GetAsientos(string asientos)
        {
            return string.Join(", ", asientos.Where(c => c != '0'));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Txt_Mensaje.Clear();
            txtRuta.Clear();
            txtBoxFila1.Clear();
            txtBoxFila2.Clear();
            txtBoxMonto.Clear();
            lblEstado.Text = "";
            pnlAsientos.Visible = false;
        }


        //MAPA BUS

        //-1 
        private int NumeroAsiento(string nombre)
        {
            int fila = nombre[0] - 'A';
            int asiento = int.Parse(nombre.Substring(1));
            return (fila * 5) + asiento;
        }

        //-2
        private void AgregarAsientos(List<int> lista, string fila, string asientos)
        {
            int f = int.Parse(fila);

            if (f == 0)
            {
                return;
            }

            foreach (char ch in asientos)
            {
                if (ch != '0')
                {
                    lista.Add((f - 1) * 5 + (ch - '0'));
                }
            }
        }

        //-3
        private void PintarMapa(string fila1, string asientos1, string fila2, string asientos2, int disponibles)
        {
            var mios = new List<int>();
            AgregarAsientos(mios, fila1, asientos1);
            AgregarAsientos(mios, fila2, asientos2);

            int vendidos = Capacidad - disponibles;
            int rojos = Math.Max(0, vendidos - mios.Count);

            foreach (Control c in pnlAsientos.Controls)
            {
                if (c is Button b && b.Name.Length > 0 && char.IsLetter(b.Name[0]))
                {
                    int n = NumeroAsiento(b.Name);

                    if (mios.Contains(n)) b.BackColor = Color.RoyalBlue;

                    else if (n <= rojos) b.BackColor = Color.Red;

                    else b.BackColor = Color.LightGreen;
                }
            }

            pnlAsientos.Visible = true;
        }
    } // Close Class    
} //Close Namespace