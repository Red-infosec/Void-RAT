using System;
using System.Text;
using System.Net.Sockets;

namespace Void_client.Libs
{
    class TCP
    {
        public static void SendInformation(string information, NetworkStream stream)
        {
            //writes the information to the stream
            try
            {
                byte[] bytes = Encoding.ASCII.GetBytes(information + "|");

                stream.Write(bytes, 0, bytes.Length);
            }
            catch (Exception) { }
        }

        public static string[] ReadAndRecieve(NetworkStream stream)
        {
            //reads the input from the client
            byte[] bytes = new byte[1024];

            try
            {
                stream.Read(bytes, 0, bytes.Length);
            }
            catch (Exception) { }

            return Encoding.ASCII.GetString(bytes).Split('|');
        }
    }
}