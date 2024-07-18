using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class ConfigurationManager
    {
        private static ConfigurationManager instance = null;
        private static readonly object padlock = new object();
        private Dictionary<string, string> settings;

        private ConfigurationManager()
        {
            // Yükleme işlemleri
            settings = new Dictionary<string, string>();
            LoadSettings();
        }

        public static ConfigurationManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ConfigurationManager();
                    }
                    return instance;
                }
            }
        }

        private void LoadSettings()
        {
            // Ayarları yükleyin, örneğin bir dosyadan veya veritabanından
            settings["ApiUrl"] = "https://api.example.com";
            settings["Timeout"] = "30";
        }

        public string GetSetting(string key)
        {
            return settings.ContainsKey(key) ? settings[key] : null;
        }
    }

}
