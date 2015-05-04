using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuneQ
{
    public partial class PlaylistWindow : Form
    {
        Playlist _playlist;
        private object _contextMenuTarget;
        private IRCClient _twitchListener;
        public PlaylistWindow()
        {
            InitializeComponent();
            DataGrid.ReadOnly = true;

            PlayTab.MouseClick += TryShowMenuStrip;
            DataGrid.MouseClick += TryShowMenuStrip;
        }
        
        /// <summary>
        /// Create a new playlist when the app loads
        /// </summary>
        private void PlaylistWindow_Load(object sender, EventArgs e)
        {
            // Create a new playlist when the app loads
            ctxFileNew_Click(null, null);
        }

        private void TryShowMenuStrip(object sender, MouseEventArgs e)
        {
            _contextMenuTarget = sender;

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                contextMenuStrip1.Show(sender as Control, e.Location);
        }

        private void ctxFileNew_Click(object sender, EventArgs e)
        {
            _playlist = new Playlist();
            _playlist.OnPlaylistModified += OnPlaylistModified;
            OnPlaylistModified(_playlist);
        }


        private void OnPlaylistModified(Playlist playlist)
        {
            lock (playlist)
            {
                DisplayPlaylist(playlist.GetDisplayData());
            }
        }
        delegate void PlaylistModifiedCallback(List<SongRequestBase> playlist);
        private void DisplayPlaylist(List<SongRequestBase> playlist)
        {
            if (DataGrid.InvokeRequired)
            {
                var d = new PlaylistModifiedCallback(DisplayPlaylist);
                DataGrid.Invoke(d, playlist);
            }
            else
            {
                lock(playlist)
                {
                    Text = "(" + playlist.Count + " songs)";
                    DataGrid.DataSource = null;
                    DataGrid.DataSource = playlist;
                }
                
            }
            
        }

        private void TwitchListeningCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(TwitchListeningCheck.Checked
                && _twitchListener == null)
            {
                _twitchListener = new IRCClient();
                _twitchListener.OnMessageReceived += OnMessageRecieved;
                _twitchListener.Connect(nick: Config.Instance.TwitchNick, oAuth: Config.Instance.TwitchOauth, channel: Config.Instance.TwitchChannel);
            }
            else if(!TwitchListeningCheck.Checked
                && _twitchListener != null)
            {
                _twitchListener.Close();
                _twitchListener = null;
            } 
        }

        delegate void MessageRecievedCallback(string line);
        private void OnMessageRecieved(string line)
        {
            if (line == null)
                return;
            if (TwitchOut.InvokeRequired)
            {
                var d = new MessageRecievedCallback(OnMessageRecieved);
                TwitchOut.Invoke(d, line);
                return;
            }

            TwitchOut.Text += line + Environment.NewLine;
            try
            {
                if (!line.Contains(':'))
                    return;
                var superSections = line.Split(':').ToList();
                superSections.RemoveAt(0);//Empty
                
                var info = superSections[0];
                superSections.RemoveAt(0);

                var userName = info.Split('!')[0];
                var userMessage = string.Join(":", superSections);
                SongRequest songRequest = null;

                var msgSections = userMessage.Split(' ');
                var commentSections = new List<string>();
                foreach(var msgSection  in msgSections)
                {
                    if (!msgSection.Contains("youtube") && !msgSection.Contains("youtu.be"))
                    {
                        commentSections.Add(msgSection);
                        continue;
                    }
                    var possibleUrl = msgSection;
                    if (!possibleUrl.Contains("http"))
                        possibleUrl = "http://" + possibleUrl;
                    Uri uriResult;
                    if(Uri.TryCreate(possibleUrl, UriKind.Absolute, out uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeHttp
                            || uriResult.Scheme == Uri.UriSchemeHttps))
                    {
                        //Valid url!
                        var comment = string.Join(" ", commentSections);
                        songRequest = new SongRequest()
                        {
                            SongName = "New request",
                            Url = possibleUrl,
                            Comment = string.Join(" ", commentSections),
                            RequestedBy = userName,
                        };
                    }
                }

                if(songRequest == null
                    && requestKeywords.Any(keyword => userMessage.Contains(keyword)))
                {
                    songRequest = new SongRequest()
                    {
                        SongName = userMessage,
                        RequestedBy = userName,
                        Comment = userMessage,
                        Url = null,
                    };
                }

                if (songRequest != null)
                    _playlist.AddLast(songRequest);
            }
            catch(Exception e)
            {
                TwitchOut.Text += "FAILED TO PARSE " + line;
                TwitchOut.Text += e.ToString() + Environment.NewLine;
            }
        }

        private void PlaylistWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_twitchListener != null)
                _twitchListener.Close();
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            OnMessageRecieved(TestBox.Text);
        }

        private List<string> requestKeywords = new List<string>()
        {
            "please",    
        };
    }
}
