using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyPlaylistRip
{
    public delegate void ProgressEventHandler(object sender, ProgressEventArgs args);
    public class ProgressEventArgs
    {
        public ProgressEventArgs(float progressPercentage)
        {
            ProgressPercentage = progressPercentage;
        }
        public readonly float ProgressPercentage;
        public bool Cancel { get; set; }
    }
}
