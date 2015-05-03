using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IRCClient
{
    public class IRCClient
    {
        TcpClient _client;

        public void Connect(string nick, string oAuth, string channel)
        {
            _client = new TcpClient("irc.twitch.tv", 6667);
            _writer = new StreamWriter(_client.GetStream());
            _reader = new StreamReader(_client.GetStream());

            WriteLine("PASS " + oAuth);
            WriteLine("NICK " + nick);
            WriteLine("JOIN #" + channel);

            _readWorker = new BackgroundWorker();
            _readWorker.DoWork += ReadLineAsync;
            _readWorker.RunWorkerCompleted += ReadLineComplete;
            _readWorker.RunWorkerAsync();
        }

        private void ReadLineAsync(object sender, DoWorkEventArgs e)
        {
            _lineReceived = _reader.ReadLine();
        }

        private void ReadLineComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            if (onMessageReceived != null)
                onMessageReceived(_lineReceived);
            _readWorker.RunWorkerAsync();
        }

        public void WriteLine(string line)
        {
            _writer.WriteLine(line);
            _writer.Flush();
        }

        public Action<string> onMessageReceived;
        private StreamWriter _writer;
        private StreamReader _reader;
        private string _lineReceived;
        private BackgroundWorker _readWorker;
    }
}
