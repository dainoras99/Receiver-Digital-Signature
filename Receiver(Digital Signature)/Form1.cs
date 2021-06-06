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
        RSAParameters Key;
        SimpleTcpServer server;
        byte[] modulus = null;
        byte[] exponent = null;
        byte[] p = null;
        byte[] q = null;
        byte[] d = null;
        byte[] dp = null;
        byte[] dq = null;
        byte[] inverseq = null;
        string messageFromTheSenderString;
        string digitalSignatureValueFromTheSenderString;


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
                messageFromTheSenderString = splitReceivedMessage[0];
                digitalSignatureValueFromTheSenderString = splitReceivedMessage[1];
                messageFromTheSender.Text = splitReceivedMessage[0];
                digitalSignatureFromTheSender.Text = splitReceivedMessage[1];
               // messageFromTheSender.Text = messageFromTheSenderString;
               // digitalSignatureFromTheSender.Text = digitalSignatureValueFromTheSenderString;
                modulus = encoding.GetBytes(splitReceivedMessage[2]);
                exponent = encoding.GetBytes(splitReceivedMessage[3]);
                p = encoding.GetBytes(splitReceivedMessage[4]);
                q = encoding.GetBytes(splitReceivedMessage[5]);
                d = encoding.GetBytes(splitReceivedMessage[6]);
                dp = encoding.GetBytes(splitReceivedMessage[7]);
                dq = encoding.GetBytes(splitReceivedMessage[8]);
                inverseq = encoding.GetBytes(splitReceivedMessage[9]);
                inverseq = inverseq.Take(inverseq.Length - 1).ToArray();
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
                Key = new RSAParameters();
                byte[] dataToVerify = encoding.GetBytes(messageFromTheSender.Text);
                byte[] signedData = encoding.GetBytes(digitalSignatureFromTheSender.Text);
                Key.Modulus = modulus;
                Key.Exponent = exponent;
                Key.P = p;
                Key.Q = q;
                Key.DP = dp;
                Key.DQ = dq;
                Key.InverseQ = inverseq;
                Key.D = d;
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();
                RSAalg.ImportParameters(Key);
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
