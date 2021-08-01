using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FNToolKit.sources
{
    class EpicHelper
    {
        private static string FortniteLauncher;
        public static string GetFortniteLauncher()
        {
            if (SavedData.ConfigData.CustomFortnitePath == null)
            {
                FortniteLauncher = Path.Combine(JsonConvert.DeserializeObject<EpicInstallLocations>(File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                    "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat"))).InstallationList.FirstOrDefault(i => i.AppName == "Fortnite")?.InstallLocation.ToString(), "FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe");
            }
            else
            {
                FortniteLauncher = Path.Combine(SavedData.ConfigData.CustomFortnitePath, "FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe");
                if (!File.Exists(FortniteLauncher)) FortniteLauncher = Path.Combine(SavedData.ConfigData.CustomFortnitePath, "Binaries\\Win64\\FortniteLauncher.exe");
                if (!File.Exists(FortniteLauncher)) FortniteLauncher = Path.Combine(SavedData.ConfigData.CustomFortnitePath, "Win64\\FortniteLauncher.exe");
                if (!File.Exists(FortniteLauncher)) FortniteLauncher = Path.Combine(SavedData.ConfigData.CustomFortnitePath, "FortniteLauncher.exe");
            }
            if (!File.Exists(FortniteLauncher)) return null;
            else return FortniteLauncher;
        }

        public class Installation
        {
            [JsonProperty("InstallLocation")]
            public string InstallLocation { get; set; }

            [JsonProperty("AppName")]
            public string AppName { get; set; }
        }

        public class EpicInstallLocations
        {
            [JsonProperty("InstallationList")]
            public List<Installation> InstallationList { get; set; }
        }
    }
}
