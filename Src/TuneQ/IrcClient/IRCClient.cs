using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TuneQ
{
    public class IRCClient
    {
        public Action<string> OnMessageReceived;
        TcpClient _client;
        bool _reading;

        public void Connect(string nick, string oAuth, string channel)
        {
            _client = new TcpClient("irc.twitch.tv", 6667);
            _writer = new StreamWriter(_client.GetStream());
            _reader = new StreamReader(_client.GetStream());

            OnMessageReceived += HandlePing;

            WriteLine("PASS " + oAuth);
            WriteLine("NICK " + nick);
            WriteLine("JOIN #" + channel);

            _readWorker = new BackgroundWorker();
            _readWorker.DoWork += ReadLineAsync;
            _readWorker.RunWorkerCompleted += ReadLineComplete;
            _readWorker.WorkerSupportsCancellation = true;
            _reading = true;
            _readWorker.RunWorkerAsync();
        }

        private void HandlePing(string msg)
        {
            if(msg.Contains("PING"))
            {
                WriteLine(msg.Replace("PING", "PONG"));
            }
        }

        private void ReadLineAsync(object sender, DoWorkEventArgs e)
        {
            try
            {
                _lineReceived = _reader.ReadLine();
            }
            catch(Exception exception)
            {
                _lineReceived = exception.ToString();
                _reading = false;
            }
        }

        private void ReadLineComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            if (OnMessageReceived != null)
                OnMessageReceived(_lineReceived);
            if (_reading)
            {
                //Read next line
                _readWorker.RunWorkerAsync();
            }
        }

        public void WriteLine(string line)
        {
            _writer.WriteLine(line);
            _writer.Flush();
        }

        public void Close()
        {
            if (_readWorker != null
                && _readWorker.IsBusy)
                _readWorker.CancelAsync();
            _client.Close();
        }

        private StreamWriter _writer;
        private StreamReader _reader;
        private string _lineReceived;
        private BackgroundWorker _readWorker;
    }
}
