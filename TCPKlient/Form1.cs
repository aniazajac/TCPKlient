using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TCPKlient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void polacz_Click(object sender, EventArgs e)
        {
            string host = adres.Text;
            int port = System.Convert.ToInt16(my_port.Value);

            try
            {
                TcpClient klient = new TcpClient(host, port);
                info_o_polaczeniu.Items.Add("Nawiązano połączenie z" + host + "na porcie:"
                    + port);
                    klient.Close(); 
            }
            catch (Exception ex)
            {
                info_o_polaczeniu.Items.Add("Błąd:" + "Nie udało się nawiązać połączenia");
                MessageBox.Show(ex.ToString(), "Błąd");
            }
        }
    }
}
