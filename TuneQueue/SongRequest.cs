using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuneQueue
{
    public class SongRequest
    {
        public int Index { get; set; }
        public bool Playing { get; set; }

        public string SongName { get; set; }
        public string RequestedBy { get; set; }
        public string Comment { get; set; }
        public string Url { get; set; }

        public string DownloadState { get; set; }


        public void AddedToPlaylist()
        {
            if (!string.IsNullOrWhiteSpace(Url))
            {
                if (Url.Contains("youtube") || Url.Contains("youtu.be"))
                {
                    DownloadState = "TODO";
                    return;
                }
            }

            
            DownloadState = "Offline";
        }
    }
}
