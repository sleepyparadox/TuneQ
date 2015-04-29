using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuneQueue
{
    public partial class EditorWindow : Form
    {
        public EditorWindow()
        {
            InitializeComponent();
            SongRequestControl.Enabled = false;
        }

        private void EditorWindow_Load(object sender, EventArgs e)
        {
            var temp = new Playlist();
            temp.AddLast(new SongRequest() { SongName = "Op", Url = "https://www.youtube.com/watch?v=SWvTGXlNEAw" });
            temp.AddLast(new SongRequest() { SongName = "Eva", Url = "https://www.youtube.com/watch?v=J9pl1q7s4mI" });
            temp.AddLast(new SongRequest() { SongName = "Careless", Url = "https://www.youtube.com/watch?v=dVmr3IaIXJc" });

            AddPlaylistTab(temp);
        }

        private void CreateNewPlaylist(object sender = null, EventArgs e = null)
        {
            var playlist = new Playlist();
            AddPlaylistTab(playlist);
        }

        void AddPlaylistTab(Playlist playlist)
        {
            var tabPage = new TabPage(playlist.Name);
            var playlistControl = new PlaylistControl(playlist);
            tabPage.Controls.Add(playlistControl);
            playlistControl.Dock = DockStyle.Fill;

            PlaylistTabs.TabPages.Add(tabPage);
            PlaylistTabs.TabIndex = PlaylistTabs.TabCount - 1;
            TabsChanged();
        }

        private void TabsChanged(object sender = null, EventArgs e = null)
        {
            var playlistControl = PlaylistTabs.SelectedTab.Children().FirstOrDefault(c => c is PlaylistControl);
            if(playlistControl != null)
            {
                SongRequestControl.Enabled = true;
                SongRequestControl.SelectedPlaylist = (playlistControl as PlaylistControl).Playlist;
            }
            else
            {
                SongRequestControl.Enabled = false;
            }
        }
    }
}
