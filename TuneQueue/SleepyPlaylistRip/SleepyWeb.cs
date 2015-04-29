using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SleepyPlaylistRip
{
    /// <summary>
    /// Sloppy web request wrapping
    /// </summary>
    public static class SleepyWebRequest
    {
        public static string Get(string url, Dictionary<string, string> args)
        {
            return Get(url + ToUrlArgs(args));
        }

        public static string Get(string url)
        {
            var webRequest = WebRequest.Create(url);
            var response = webRequest.GetResponse();
            var resultReader = new StreamReader(response.GetResponseStream());
            var resultData = resultReader.ReadToEnd();
            resultReader.Close();

            return resultData;
        }

        public static string ToUrlArgs(Dictionary<string, string> keyValPairs)
        {
            if (keyValPairs.Keys.Count == 0)
                return string.Empty;
            return "?" + string.Join("&", keyValPairs.Select(pair => pair.Key + "=" + pair.Value).ToArray());
        }
    }
}
