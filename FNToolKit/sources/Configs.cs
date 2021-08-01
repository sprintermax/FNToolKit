using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace FNToolKit
{
    class SavedData
    {
        static string SaveDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\SpMax\\FNToolKit";
        static public AppConfig ConfigData = File.Exists(Path.Combine(SaveDataPath, "appconfig.json")) ? JsonConvert.DeserializeObject<AppConfig>(File.ReadAllText(Path.Combine(SaveDataPath, "appconfig.json"))) : CreateConfigFile();
        static public List<SavedAccs> AccountsData = File.Exists(Path.Combine(SaveDataPath, "savedaccs.json")) ? JsonConvert.DeserializeObject<List<SavedAccs>>(File.ReadAllText(Path.Combine(SaveDataPath, "savedaccs.json"))) : CreateAccountsFile();

        public static void CheckDir()
        {
            if (!Directory.Exists(SaveDataPath)) Directory.CreateDirectory(SaveDataPath);
        }

        private static AppConfig CreateConfigFile()
        {
            AppConfig NewCfgData = new AppConfig { };
            File.WriteAllText(Path.Combine(SaveDataPath, "appconfig.json"), JsonConvert.SerializeObject(NewCfgData));
            return NewCfgData;
        }

        private static List<SavedAccs> CreateAccountsFile()
        {
            List<SavedAccs> NewAccData = JsonConvert.DeserializeObject<List<SavedAccs>>("[]");
            File.WriteAllText(Path.Combine(SaveDataPath, "savedaccs.json"), JsonConvert.SerializeObject(NewAccData));
            return NewAccData;
        }

        public static void SaveConfigFile()
        {
            File.WriteAllText(Path.Combine(SaveDataPath, "appconfig.json"), JsonConvert.SerializeObject(ConfigData));
        }
        public static void SaveAccountsFile()
        {
            File.WriteAllText(Path.Combine(SaveDataPath, "savedaccs.json"), JsonConvert.SerializeObject(AccountsData));
        }
    }

    public class AppConfig
    {
        public bool LegacyLaunch { get; set; } = false;
        public int CurrentAccount { get; set; } = 0;
        public bool CloseOnStartGame { get; set; } = false;
        public string CustomFortnitePath { get; set; } = null;
        public bool ForceEAC { get; set; } = false;
    }

    public class SavedAccs
    {
        public string FNAccID { get; set; }
        public string FNDevID { get; set; }
        public string FNScrt { get; set; }
        public string FNName { get; set; }
    }
}
