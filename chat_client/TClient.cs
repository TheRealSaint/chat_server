using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace chat_client
{
    public class TClient
    {
        public static int ServerPort = 12345;

        // GUI, in der die empfangenen Nachrichten angezeigt werden
        ClientForm clientForm;

        // Thread, der die Kommunikation verwaltet
        Thread clientThread;

        // Socket zum Server
        TcpClient server;
        blablablab
        // Netzwerk-Streams
        StreamWriter writer;
        StreamReader reader;

        // so lange läuft der Client
        bool running;

        // Konstruktor
        public TClient(ClientForm aClientForm, string serverIP)
        {
            clientForm = aClientForm;

            // Thread mit der übergebenen IP starten
            clientThread = new Thread(run);
            clientThread.Start(serverIP);
        }

        // Client-Prozess beenden
        public void stop()
        {
            running = false;
        }

        // msg an den Server schicken
        public void sendMessage (string msg)
        {
            try
            {
                // an den Server schicken
                writer.WriteLine(msg);
                writer.Flush();
            }
            catch (Exception e)
            {
                clientForm.showClientMessage(e.Message);
                stop();
            }
        }

        // dies führt der Client-Thread aus
        void run (Object serverIP)
        {
            connectToServer(serverIP);

            // Kommunikationsschleife
            while (running)
            {
                // vom Server empfangen
                string msg = reader.ReadLine();

                // wenn der Server nicht beendet (<q>)
                if (msg != null && msg != "<q>")
                    clientForm.showClientMessage(msg);
                else
                {
                    // sonst Ende der Verbindung
                    sendMessage("<q>");
                    stop();
                }
            }

            clientForm.showClientMessage("Ended connection with server.");
            Thread.Sleep(100);

            if (server != null)
                server.Close();
        }

        private void connectToServer(Object serverIP)
        {
            // Verbindung zum Server herstellen
            try
            {
                server = new TcpClient((string)serverIP, ServerPort);

                writer = new StreamWriter(server.GetStream());
                reader = new StreamReader(server.GetStream());
                running = true;
            }
            catch (SocketException se)
            {
                clientForm.showClientMessage("Connection error: " + se.Message);
                stop();
            }
        }
    }
}
