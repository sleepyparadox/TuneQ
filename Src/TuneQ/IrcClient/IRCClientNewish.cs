using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TuneQ
{
    public class IRCClientNewish
    {
        TcpClient _client;
        bool _reading;

        public void Connect(string nick, string oAuth, string channel)
        {
            _client = new TcpClient("irc.twitch.tv", 6667);
            _writer = new StreamWriter(_client.GetStream());
            _reader = new StreamReader(_client.GetStream());

            ReadCharactersAsync();

            WriteLine("PASS " + oAuth);
            WriteLine("NICK " + nick);
            WriteLine("JOIN #" + channel);

        }

        async void ReadCharactersAsync()
        {
            _reading = true;
            while (_reading)
            {
                try
                {
                    var line = await _reader.ReadLineAsync();
                    if (onMessageReceived != null)
                        onMessageReceived(line);
                }
                catch(Exception e)
                {
                    _reading = false;
                }
                
            }
        }

        public void WriteLine(string line)
        {
            _writer.WriteLine(line);
            _writer.Flush();
        }

        public void Close()
        {
            _reading = false;
            _client.Close();
        }

        public Action<string> onMessageReceived;
        private StreamWriter _writer;
        private StreamReader _reader;
        private string _lineReceived;
    }

}
