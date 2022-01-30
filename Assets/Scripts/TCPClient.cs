using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;

public class TCPClient : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Thread client = new Thread(StartClient);
        client.Start();
        //StartClient();
    }

    void StartClient()
    {
        Debug.Log("test");
        string server = "127.0.0.1";
        string message = "test this is a test isnt it or am I the test? being tested";
        try
        {
            // Create a TcpClient.
            // Note, for this client to work you need to have a TcpServer
            // connected to the same address as specified by the server, port
            // combination.
            Int32 port = 13000;
            TcpClient client = new TcpClient(server, port);

            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

            // Get a client stream for reading and writing.
            //  Stream stream = client.GetStream();

            NetworkStream stream = client.GetStream();

            // Send the message to the connected TcpServer.
            stream.Write(data, 0, data.Length);

            Debug.LogError($"Sent: {message}");

            // Receive the TcpServer.response.

            // Buffer to store the response bytes.
            data = new Byte[256];

            // String to store the response ASCII representation.
            String responseData = String.Empty;

            // Read the first batch of the TcpServer response bytes.
            while (true) {
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                if (responseData != "")
                {
                    Debug.LogError($"Received: {responseData}");
                }
                responseData = "";
            }

            // Close everything.
            stream.Close();
            client.Close();
        }
        catch (ArgumentNullException e)
        {
            Debug.LogError($"ArgumentNullException: {e}");
        }
        catch (SocketException e)
        {
            Debug.LogError($"SocketExeption: {e}");
        }
    }
}
