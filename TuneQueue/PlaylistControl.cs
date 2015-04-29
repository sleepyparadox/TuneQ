using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuneQueue
{
    public partial class PlaylistControl : UserControl
    {
        public Playlist Playlist { get; private set; }
        public PlaylistControl(Playlist playlist)
        {
            InitializeComponent();
            Playlist = playlist;
            DataGrid.DataSource = Playlist.List;

            Playlist.OnPlaylistModified += PlaylistModified;
        }

        private void PlaylistModified(TuneQueue.Playlist obj)
        {
            DataGrid.DataSource = null;
            DataGrid.DataSource = Playlist.List;
            DataGrid.Refresh();
        }
    }
}
