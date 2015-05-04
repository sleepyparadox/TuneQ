using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using YoutubeExtractor;

namespace TuneQ
{
    public class SongRequest : SongRequestBase
    {
        //public int Index { get; set; }
        //public bool Playing { get; set; }
        public SongState SongState { get; set; }
        public Action<SongRequest> OnModified;

        public void AddedToPlaylist(Playlist playlist)
        {
            if (!string.IsNullOrWhiteSpace(Url)
                && (Url.Contains("youtube") || Url.Contains("youtu.be")))
            {
                SetDownloadState(SongState.YT_Info);

                var worker = new BackgroundWorker();
                worker.DoWork += (w, e) =>
                {
                    try
                    {
                        PreformDownload(playlist.Path, Url);
                        SetDownloadState(SongState.YT_DLSuccess);
                    }
                    catch(Exception exception)
                    {
                        SetDownloadState(SongState.YT_Failed);
                    }
                };
                worker.RunWorkerCompleted += (w, e) =>
                {
                        
                };
                worker.RunWorkerAsync();

                return;
            }
            else
            {
                SetDownloadState(SongState.Custom);
            }
        }

        void SetSongName(string name)
        {
            lock (this)
            {
                SongName = name;
                if (OnModified != null)
                    OnModified(this);
            }
        }

        void SetDownloadState(SongState state)
        {
            lock(this)
            {
                SongState = state;
                if (OnModified != null)
                    OnModified(this);
            }
        }

        void PreformDownload(string playlistPath, string videoUrl)
        {
            ////Hackiest way to rip out an arg
            //var uri = new Uri(videoUrl);
            //var args = HttpUtility.ParseQueryString(uri.Query);
            //var songFileName = args.Get("v");

            var videoInfos = DownloadUrlResolver.GetDownloadUrls(videoUrl);

            //Grab the video with best audio quality
            var videos = videoInfos
                .Where(info => info.CanExtractAudio)
                .OrderByDescending(info => info.AudioBitrate)
                .ToList();
            var video = videos.First();

            var invalidChars = Path.GetInvalidFileNameChars().ToList();
            invalidChars.Add('/');
            invalidChars.Add('\\');
            
            var songFileName = "";
            foreach(var c in video.Title)
            {
                songFileName += invalidChars.Contains(c) ? '_' : c;
            };

            SetSongName(songFileName + video.AudioExtension);


            //SetSongName(video.Title);

            //var videoPath = Path.Combine(playlistPath, songFileName + video.VideoExtension);
            var audioPath = Path.Combine(playlistPath, songFileName + video.AudioExtension);

            SetDownloadState(SongState.YT_Download);
            var audioDownloader = new AudioDownloader(video, audioPath);
            //audioDownloader.OnBeginExtractAudio += () => SetDownloadState(SongState.YT_Extracting);
            audioDownloader.Execute();
        }
    }
}
