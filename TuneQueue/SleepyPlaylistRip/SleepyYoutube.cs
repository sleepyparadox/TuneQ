using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyPlaylistRip
{
    public static class SleepyYoutube
    {
        const string YoutubeApiUrl = "https://www.googleapis.com/youtube/v3/";

        public static List<YTPlaylistItem> GetPlaylistItems(string playlistId, string authKey, ProgressEventHandler onProgress)
        {
            var urlArgs = new Dictionary<string, string>();
            urlArgs.Add("key", authKey); //Required
            urlArgs.Add("part", "snippet"); //Required
            urlArgs.Add("playlistId", playlistId); //Required

            var items = new List<YTPlaylistItem>();
            string nextPageToken = null;
            var pageIndex = 0;
            do
            {
                if (nextPageToken != null)
                {
                    if (urlArgs.ContainsKey("pageToken"))
                        urlArgs["pageToken"] = nextPageToken;
                    else
                        urlArgs.Add("pageToken", nextPageToken);
                }
                
                var resultJson = SleepyWebRequest.Get(YoutubeApiUrl + "playlistItems", urlArgs);
                var result = Newtonsoft.Json.JsonConvert.DeserializeObject<YTPlaylistItemsPageResult>(resultJson);
                items.AddRange(result.items);
                nextPageToken = result.nextPageToken;

                if(onProgress != null)
                {
                    var progressArgs = new ProgressEventArgs(result.pageInfo.GetProgress(pageIndex));
                    onProgress(null, progressArgs);
                    if (progressArgs.Cancel)
                        break;
                }
                pageIndex++;
            }
            while (nextPageToken != null);

            if(onProgress != null)
                onProgress(null, new ProgressEventArgs(1));
            return items;
        }
    }

    public class YTPlaylistItemsPageResult
    {
        public YTPlaylistItem[] items;
        public string nextPageToken;
        public TYPageInfo pageInfo;
    }

    public class TYPageInfo
    {
        public int totalResults;
        public int resultsPerPage;
        public float GetProgress(int pageIndex)
        {
            return Math.Min((float)pageIndex * resultsPerPage / totalResults, 1);
        }
    }

    public class YTPlaylistItem
    {
        public string id;
        public YTSnippet snippet;
        public override string ToString()
        {
            return snippet.title;
        }
        public string YoutubeVideoUrl
        {
            get
            {
                return "https://www.youtube.com/watch?v=" + snippet.resourceId.videoId;
            }
        }
    }

    public class YTSnippet
    {
        public string title;
        public string description;
        public Dictionary<string, YTSnippetThumbnail> thumbnails;
        public YTResourceId resourceId;
    }
    public class YTSnippetThumbnail
    {
        public string url;
        public int width;
        public int height;
    }

    public class YTResourceId
    {
        public string kind;
        public string videoId;
    }
}
