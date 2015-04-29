using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuneQueue
{
    public class Playlist : IEnumerable<SongRequest>
    {
        public List<SongRequest> List { get; set; }
        public string Name { get { return Path.Replace("\\", "/").Split('/').Last(); } }
        public string Path { get; set; }
        public int CurrentIndex { get; set; }
        public Action<Playlist> OnPlaylistModified;

        public Playlist(string name = null)
        {
            name = name ?? "Stream_" + DateTime.UtcNow.ToString("yyyy_MM_dd_HH");
            Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/TuneQueue/" + name;
            List = new List<SongRequest>();
        }

        public void AddNext(SongRequest song)
        {
            List.Insert(Math.Min(CurrentIndex + 1, List.Count), song);
            song.AddedToPlaylist(this);
            song.OnModified += (s) => PlaylistModified();
            PlaylistModified();
        }

        public void AddLast(SongRequest song)
        {
            List.Add(song);
            song.AddedToPlaylist(this);
            song.OnModified += (s) => PlaylistModified();
            PlaylistModified();
        }

        private void PlaylistModified()
        {
            if (!Directory.Exists(Path))
                Directory.CreateDirectory(Path);

            for(var i = 0; i < List.Count; ++i)
            {
                List[i].Index = i;
                List[i].Playing = (i == CurrentIndex);
            }

            if(OnPlaylistModified != null)
                OnPlaylistModified(this);
        }

        public IEnumerator<SongRequest> GetEnumerator()
        {
            foreach (var song in List)
                yield return song;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return List.GetEnumerator();
        }
    }
}
