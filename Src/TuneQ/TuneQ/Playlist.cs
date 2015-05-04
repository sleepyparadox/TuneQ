using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuneQ
{
    public class Playlist : IEnumerable<SongRequest>
    {
        public string Name { get { return Path.Replace("\\", "/").Split('/').Last(); } }
        public string Path { get; set; }
        public int CurrentIndex { get; set; }
        public int Count { get { return _list.Count; } }
        public Action<Playlist> OnPlaylistModified;
        List<SongRequest> _list;

        public Playlist(string name = null)
        {
            name = name ?? "Stream_" + DateTime.UtcNow.ToString("yyyy_MM_dd_HH");
            Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/TuneQ/" + name;
            _list = new List<SongRequest>();
        }

        public void AddNext(SongRequest song)
        {
            _list.Insert(Math.Min(CurrentIndex + 1, _list.Count), song);
            song.AddedToPlaylist(this);
            song.OnModified += (s) => PlaylistModified();
            PlaylistModified();
        }

        public void AddLast(SongRequest song)
        {
            _list.Add(song);
            song.AddedToPlaylist(this);
            song.OnModified += (s) => PlaylistModified();
            PlaylistModified();
        }

        private void PlaylistModified()
        {
            if (!Directory.Exists(Path))
                Directory.CreateDirectory(Path);

            if(OnPlaylistModified != null)
                OnPlaylistModified(this);
        }

        public IEnumerator<SongRequest> GetEnumerator()
        {
            foreach (var song in _list)
                yield return song;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public List<SongRequestBase> GetDisplayData()
        {
            List<SongRequestBase> displayData = new List<SongRequestBase>();
            lock(_list)
            {
                foreach(var item in _list)
                {
                    lock(item)
                    {
                        displayData.Add(new SongRequestBase()
                            {
                                SongState = item.SongState,
                                SongName = item.SongName,
                                Comment = item.Comment,
                                RequestedBy = item.RequestedBy,
                                Url = item.Url,
                            });
                    }
                }
            }
            return displayData;
        }
    }
}
