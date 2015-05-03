using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new StreamWriter("twitchchat" + DateTime.UtcNow.Ticks + ".txt");

            var client = new IRCClient();
            client.onMessageReceived += Console.WriteLine;
            client.onMessageReceived += log.WriteLine;
            client.Connect(null, null, null);

            while(true)
            {
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
