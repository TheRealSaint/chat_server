using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace chat_client
{
    public partial class ClientForm : Form
    {
        TClient client;

        public ClientForm()
        {
            InitializeComponent();
            btnSend.Hide();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // client mit der IP aus der Eingabzeile erstellen
            client = new TClient(this, tbInput.Text);
            btnConnect.Hide();
            btnSend.Show();
        }

        // Delegat-Typ für Thread-übergreifenden Methodenaufruf
        delegate void InvokeDelegate (string s);

        // Diese Methode wird aus dem Thread aufgerufen
        public void showClientMessage(string msg)
        {
            // Wenn unsicherer Zustand
            if (InvokeRequired)
                BeginInvoke(new InvokeDelegate(showClientMessage), msg);
            else
                // sonst direktes Schreiben möglich
                lbMessage.Items.Add(msg);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // über den client an den Server schicken
            client.sendMessage(tbInput.Text);
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Text = "Closing ...";
            if (client != null)
            {
                client.sendMessage("<q>");

                Thread.Sleep(100);
            }
        }
    }
}
