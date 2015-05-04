using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuneQ
{
    public class Config
    {
        public static string GetTuneQDirectory()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/TuneQ/";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path;
        }
        
        public static Config Instance
        {
            get
            {
                if(_instance == null)
                    _instance = Load();
                return _instance; 
            }
        }
        public string TwitchNick = "DISPLAYNAME";
        public string TwitchOauth = "oath:YOURTOKEN";
        public string TwitchChannel = "CHANNELNAME";

        public static Config Load()
        {
            if(!File.Exists(GetConfigPath()))
                return new Config();
            try
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Config>(File.ReadAllText(GetConfigPath()));
            }
            catch(Exception e)
            {
                MessageBox.Show("Error loading " + GetConfigPath());
                MessageBox.Show(e.ToString());
                File.WriteAllText(GetTuneQDirectory() + "error.txt", e.ToString());
                throw e;
            }
        }

        public void Save()
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            File.WriteAllText(GetConfigPath(), json);
        }

        private static string GetConfigPath()
        {
            return GetTuneQDirectory() + "Config.json";
        }
       
        private static Config _instance; 
    }
}
