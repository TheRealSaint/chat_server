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
            btn_send.Hide();
            chlb_chat_partner.Items.Add("Toni", true);
            chlb_chat_partner.Items.Add("Holger", false);
            chlb_chat_partner.Items.Add("Lars", false);
        }

        
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // client mit der IP aus der Eingabzeile erstellen
            client = new TClient(this, tb_ip_adress.Text);
            btnConnect.Hide();
            btn_send.Show();
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
            
            client.sendMessage(tb_chat_text.Text);
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

        // Eingabefeld für Chattext
        private void tb_chat_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //client.sendMessage(tb_chat_text.Text);
                //tb_chat_text.Clear();
                string msg = "{\"FromC\":\"" + tb_your_name.Text + "\",\"ToC\":\"" + chlb_chat_partner.GetItemText(chlb_chat_partner.SelectedItem) + "\",\"MSG\":\"" + tb_chat_text.Text + "\"}";
                client.sendMessage(msg);
                tb_chat_text.Clear();
            }
        }
    }
}
