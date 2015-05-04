using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuneQ
{
    public enum SongState
    {
        New,
        Custom,
        YT_Info,
        YT_Download,
        YT_Extracting,
        YT_DLSuccess,
        YT_Cached,
        YT_Failed,
    }
}
