using Neptuno.Views.domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuno.Views.helpers
{
    public class ConfiguratorHelper : IConfiguratorHelper
    {
        private string CONFIG_FILE_NAME = "neptuno.cfg";

        private Configuration _config;

        public LANGUAGE Language { get => _config.Language; set => _config.Language = value; }

        public string DbHost { get => _config.DbHost; set => _config.DbHost = value; }

        public string DbPort { get => _config.DbPort; set => _config.DbPort = value; }

        public string DbName { get => _config.DbName; set => _config.DbName = value; }

        public string DbUser { get => _config.DbUser; set => _config.DbUser = value; }

        public string DbPassword { get => _config.DbPassword; set => _config.DbPassword = value; }
        
        public ConfiguratorHelper()
        {
            CreateConfigurationFileIfNotExist();
        }

        public void SaveConfiguration()
        {
            using (StreamWriter file = File.CreateText(CONFIG_FILE_NAME))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, _config);
            }
        }

        private Configuration LoadConfiguration()
        {
            Configuration result = null;

            try
            {
                using (StreamReader file = File.OpenText(CONFIG_FILE_NAME))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    result = (Configuration)serializer.Deserialize(file, typeof(Configuration));
                }
            }
            catch (Exception error)
            {
                
            }

            return result;
        }

        private void CreateConfigurationFileIfNotExist()
        {
            try
            {
                if (File.Exists(CONFIG_FILE_NAME))
                {
                    _config = LoadConfiguration();
                }
                else
                {
                    _config = new Configuration();
                    SaveConfiguration();
                }
            }
            catch (Exception error)
            {

            }
        }
    }
}
