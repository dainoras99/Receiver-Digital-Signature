using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receiver_Digital_Signature_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Encoding encoding = Encoding.GetEncoding("437");
        SimpleTcpServer server;


        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            messageFromTheSender.Invoke((MethodInvoker)delegate ()
            {
                string receivedMessage = e.MessageString;
                receivedMessage.Substring(0, receivedMessage.Length - 1);
                string stringSplit = "AtSkYrImaSA!@345f";

                string[] splitReceivedMessage = receivedMessage.Split(new string[] { stringSplit }, StringSplitOptions.None);
                messageFromTheSender.Text = splitReceivedMessage[0];
                digitalSignatureFromTheSender.Text = splitReceivedMessage[1];
            });
        }

        private void start_Click(object sender, EventArgs e)
        {
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(ipTextBox.Text);
            server.Start(ip, Convert.ToInt32(portTextBox.Text));
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
            signatureConfirmedLabel.Visible = false;
        }
        public bool VerifySignedHash()
        {
            try
            {
                byte[] dataToVerify = encoding.GetBytes(messageFromTheSender.Text);
                byte[] signedData = encoding.GetBytes(digitalSignatureFromTheSender.Text);

                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();

                RSAParameters Key = RSAalg.ExportParameters(true);
                return RSAalg.VerifyData(dataToVerify, SHA256.Create(), signedData);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return false;
            }
        }

        private void confirmTheSignatureButton_Click(object sender, EventArgs e)
        {
            if (VerifySignedHash() == true)
                signatureConfirmedLabel.Text = "Verified";
            else
                signatureConfirmedLabel.Text = "Not verified";
            signatureConfirmedLabel.Visible = true;
        }
    }
}
