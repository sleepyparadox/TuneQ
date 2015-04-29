//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace TuneQueue
//{
//    public class Config
//    {
//        public static string GoogleAuthKey { get; private set; }
//        const string ConfigPath = "Config.txt";
//        const string ConfigKeyAuthKey = "authkey";

//        public static void Load()
//        {
//            try 
//            {
//                var lines = File.ReadAllLines(ConfigPath).Select(line => 
//                    {
//                        //Remove whitespace and split key/value
//                        var cells = line.Replace(" ", "").Replace("\t", "").Split('=');
//                        return new { Key = cells[0], Value = cells[1] };
//                    }).ToList();

//                GoogleAuthKey = lines.First(row => row.Key == ConfigKeyAuthKey).Value;
//            }
//            catch(Exception e)
//            {
//                //Thow up some messages for the poor sod using this app
//                MessageBox.Show(string.Format("Requires {0} file in same dir as .exe, with {1}=<YOURAUTHKEY> in one of the lines",
//                                                ConfigPath,
//                                                ConfigKeyAuthKey));
//                MessageBox.Show(e.ToString());

//                throw e;
//            }
//        }
//    }
//}
