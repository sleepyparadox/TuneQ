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

namespace TuneQueue
{
    public class SongRequest
    {
        public int Index { get; set; }
        public bool Playing { get; set; }
        public string DownloadState { get; set; }
        Thread DownloadThread;
        public Action<SongRequest> OnModified;

        public string SongName { get; set; }
        public string RequestedBy { get; set; }
        public string Comment { get; set; }
        public string Url { get; set; }

        

        public void AddedToPlaylist(Playlist playlist)
        {
            if (!string.IsNullOrWhiteSpace(Url))
            {
                if (Url.Contains("youtube") || Url.Contains("youtu.be"))
                {
                    SetDownloadState("Starting Download");
                    //PreformDownload(playlist.Path, Url);
                    string _result = "";
                    var worker = new BackgroundWorker();
                    worker.DoWork += (w, e) =>
                    {
                        try
                        {
                            PreformDownload(playlist.Path, Url);
                            _result = "Success";
                        }
                        catch(Exception exc)
                        {
                            _result = "Failed " + exc.ToString();
                        }
                    };
                    worker.RunWorkerCompleted += (w, e) =>
                    {
                        SetDownloadState(_result);
                        if (OnModified != null)
                            OnModified(this);
                    };
                    worker.RunWorkerAsync();

                    return;
                }
            }

            SetDownloadState("Offline");
        }

        void SetDownloadState(string state)
        {
            lock(this)
            {
                DownloadState = state;
            }
        }

        void PreformDownload(string playlistPath, string videoUrl)
        {
            //Hackiest way to rip out an arg
            var uri = new Uri(videoUrl);
            var args = HttpUtility.ParseQueryString(uri.Query);
            var songFileName = args.Get("v");

            var videoInfos = DownloadUrlResolver.GetDownloadUrls(videoUrl);

            //Grab the video with best audio quality
            var videos = videoInfos
                .Where(info => info.CanExtractAudio)
                .OrderByDescending(info => info.AudioBitrate)
                .ToList();
            var video = videos.First();

            var videoPath = Path.Combine(playlistPath, songFileName + video.VideoExtension);
            var audioPath = Path.Combine(playlistPath, songFileName + video.AudioExtension);

            var audioDownloader = new AudioDownloader(video, audioPath, videoPath);
            audioDownloader.Execute();
        }
    }
}
