using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

static class TCPServer
{
    static Thread Thread;
    public static Queue<string> Messages = new Queue<string>();

    // Start is called before the first frame update
    static public void Start()
    {
        //dataPath = Application.dataPath;
        Thread = new Thread(TCPStart);
        Thread.Start();

    }

    static void TCPStart()
    {
        TcpListener server = null;
        try
        {
            // Set the TcpListener on port 13000.
            Int32 port = 13000;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");

            // TcpListener server = new TcpListener(port);
            server = new TcpListener(localAddr, port);

            // Start listening for client requests.
            server.Start();

            // Buffer for reading data
            Byte[] bytes = new Byte[256];
            String data = null;

            // Enter the listening loop.
            while (true)
            {
                Console.Write("Waiting for a connection... ");

                // Perform a blocking call to accept requests.
                // You could also use server.AcceptSocket() here.
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Connected!");

                data = null;

                // Get a stream object for reading and writing
                

                // Loop to receive all the data sent by the client.
                while (client.Connected)
                {
                    NetworkStream stream = client.GetStream();

                    /*int i;
                    i = stream.Read(bytes, 0, bytes.Length);
                    // Translate data bytes to a ASCII string.
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    if (data != "")
                    {
                        Console.WriteLine("Received: {0}", data);
                    }*/

                    //Send object from que
                    string msgtext;
                    if (Messages.Count > 0)
                    {
                        msgtext = Messages.Dequeue();
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(msgtext);
                        // Send back a response.
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Sent: {0}", msgtext);
                    }
                    //JsonConvert.SerializeObject(obj);
                }

                // Shutdown and end connection
                client.Close();
            }
        }
        catch (SocketException e)
        {
            Console.WriteLine("SocketException: {0}", e);
        }
        finally
        {
            // Stop listening for new clients.
            server.Stop();
        }

        Console.WriteLine("\nHit enter to continue...");
        Console.Read();

    }
}