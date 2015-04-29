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
    public partial class SongRequestControl : UserControl
    {
        public Playlist SelectedPlaylist { get; set; }
        
        SongRequest SongFromInfo()
        {
            return new SongRequest()
            {
                Index = -1,
                SongName = InfoSongName.Text,
                RequestedBy = InfoRequestedBy.Text,
                Comment = InfoComment.Text,
                Url = InfoUrl.Text,
            };
        }
        
        public SongRequestControl()
        {
            InitializeComponent();
        }

        private void BtnAddLast_Click(object sender, EventArgs e)
        {
            SelectedPlaylist.AddLast(SongFromInfo());
        }

        private void BtnAddNext_Click(object sender, EventArgs e)
        {
            SelectedPlaylist.AddNext(SongFromInfo());
        }
    }
}
