using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuneQ
{
    public class SongRequestBase
    {
        public SongState SongState { get; set; }
        public string SongName { get; set; }
        public string RequestedBy { get; set; }
        public string Comment { get; set; }
        public string Url { get; set; }
    }
}
