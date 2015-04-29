//using Newtonsoft.Json;
//using SleepyMusic;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using YoutubeExtractor;

//namespace SleepyPlaylistRip.SleepyPlaylistRip
//{
//    public class SleepyYoutubeDownloader
//    {
//        public static void DownloadPlaylistAndGenerateMetaData(string musicDirectory, string deployDirectory, string playlistId, string[] playlistTags, string authKey, bool skipExisting)
//        {
//            Console.WriteLine("Begin playlist fetch " + playlistId);
//            var items = SleepyYoutube.GetPlaylistItems(playlistId, authKey, null);
//            Console.WriteLine("Finished playlist fetch " + playlistId);

//            foreach (var item in items)
//            {
//                try
//                {
//                    //Console.WriteLine("Begin downloading " + item);
//                    var songFileName = item.snippet.title;
//                    foreach (var invalidChar in Path.GetInvalidFileNameChars())
//                        songFileName = songFileName.Replace(invalidChar, '_');
//                    songFileName = songFileName.Replace('/', '_').Replace('\\', '_').Replace('?', '_');

//                    var metaPath = Path.Combine(musicDirectory, songFileName + ".json");
//                    if (!skipExisting
//                        || !File.Exists(metaPath))
//                    {
//                        Console.WriteLine("Download to " + metaPath);
//                        var youtubeUrl = item.YoutubeVideoUrl;
//                        var videoInfos = DownloadUrlResolver.GetDownloadUrls(youtubeUrl);

//                        //Grab the video with best audio quality
//                        var videos = videoInfos
//                            .Where(info => info.CanExtractAudio)
//                            .OrderByDescending(info => info.AudioBitrate)
//                            .ToList();
//                        var tries = 0;
//                        while (videos.Count > 0)
//                        {
//                            var video = videos[0];
//                            videos.RemoveAt(0);
//                            tries++;

//                            try
//                            {
//                                var videoPath = Path.Combine(musicDirectory, songFileName + video.VideoExtension);
//                                var audioPath = Path.Combine(musicDirectory, songFileName + video.AudioExtension);

//                                var audioDownloader = new AudioDownloader(video, audioPath, videoPath);
//                                audioDownloader.Execute();

//                                var now = DateTime.UtcNow.ToString();
//                                var metaData = new SPSongMetaData()
//                                {
//                                    MediaSource = youtubeUrl,
//                                    Title = songFileName,
//                                    YoutubeVideoId = item.snippet.resourceId.videoId,
//                                    Tags = playlistTags,
//                                    CreatedAt = now,
//                                    LastUpdatedAt = now,
//                                    Files = new SPSongMetaDataFile[] 
//                                    {
//                                        new SPSongMetaDataFile()
//                                        {
//                                            FileSource = youtubeUrl,
//                                            MediaType = MediaFormat.Audio,
//                                            FileName = songFileName + video.AudioExtension,
//                                        },
//                                        new SPSongMetaDataFile()
//                                        {
//                                            FileSource = youtubeUrl,
//                                            MediaType = MediaFormat.Video,
//                                            FileName = songFileName + video.VideoExtension,
//                                        },
//                                    },
//                                };

//                                var writer = new StreamWriter(metaPath);
//                                writer.Write(JsonConvert.SerializeObject(metaData));
//                                writer.Close();
//                                break; //Exit
//                            }
//                            catch(Exception e)
//                            {
//                                Console.ForegroundColor = ConsoleColor.Red;
//                                Console.WriteLine("failed to download " + item.snippet.resourceId.videoId + " on try " + tries);
//                                Console.WriteLine(e.ToString());
//                                Console.ForegroundColor = ConsoleColor.White;
//                            }
//                        }
//                    }
//                    var mp3Path = Path.Combine(musicDirectory, songFileName + ".mp3");
//                    var deployMp3ToPath = Path.Combine(deployDirectory, songFileName + ".mp3");
//                    if (File.Exists(mp3Path)
//                        && !File.Exists(deployMp3ToPath))
//                    {
//                        Console.WriteLine("Copy to " + deployMp3ToPath);
//                        File.Copy(mp3Path, deployMp3ToPath);
//                    }
//                }
//                catch (Exception e)
//                {
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.WriteLine("failed to download " + item.snippet.resourceId.videoId);
//                    Console.WriteLine(e.ToString());
//                    Console.ForegroundColor = ConsoleColor.White;
//                    continue;
//                }
//                //Console.WriteLine("Finished downloading " + item);
//            }
//        }
//    }
//}
