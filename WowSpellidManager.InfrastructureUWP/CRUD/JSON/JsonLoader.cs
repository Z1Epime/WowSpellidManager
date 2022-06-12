using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Infrastructure.DataManager;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Infrastructure.Metadata;

namespace WowSpellidManager.Infrastructure.CRUD.JSON
{
    internal class JsonLoader
    {
        public static ObservableCollection<WowClass> LoadWowClasses()
        {
            ObservableCollection<WowClass> wowClasses = new ObservableCollection<WowClass>();

            if (File.Exists(LoadSettings().SavingsPath + "\\WowSpellIDManager\\Data\\wowclasses.json"))
            {
                string readContents;
                using (StreamReader streamReader = new StreamReader(LoadSettings().SavingsPath + "\\WowSpellIDManager\\Data\\wowclasses.json"))
                {
                    readContents = streamReader.ReadToEnd();
                }

                wowClasses = JsonConvert.DeserializeObject<ObservableCollection<WowClass>>(readContents);
            } else
            {
                var abc = LoadSettings().SavingsPath;
                Directory.CreateDirectory(abc + "\\WowSpellIDManager\\Data\\");
                File.Create(LoadSettings().SavingsPath + "\\WowSpellIDManager\\Data\\wowclasses.json").Dispose();
                wowClasses = Generator.Generate();

                string json = JsonConvert.SerializeObject(wowClasses);
                File.WriteAllText(LoadSettings().SavingsPath + "\\WowSpellIDManager\\Data\\wowclasses.json", json);
            }
           
            return (ObservableCollection<WowClass>)wowClasses;
        }

        public static Settings LoadSettings()
        {         
            string readContents;

            // Directory.CreateDirectory only creates a directory if it doesnt already exist
            Directory.CreateDirectory(JsonSaver.SETTINGSPATH); 

            if(!File.Exists(JsonSaver.SETTINGSPATH + "settings.JSON"))
            {
                File.Create(JsonSaver.SETTINGSPATH + "settings.JSON").Dispose();
            }

            using (StreamReader streamReader = new StreamReader(JsonSaver.SETTINGSPATH + "settings.JSON"))
            {
                readContents = streamReader.ReadToEnd();
            }

            if (String.IsNullOrEmpty(readContents))
            {
                readContents = JsonConvert.SerializeObject(new Settings()
                {
                    SavingsPath = DefaultSettings.DefaultSavingsPath,
                    IsDarkThemeActive = DefaultSettings.DefaultDarkThemeActive
                });
            }

            Settings settings = JsonConvert.DeserializeObject<Settings>(readContents);

            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(JsonSaver.SETTINGSPATH + "settings.JSON"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, settings);
            }

            return settings;
        }
    }
}
