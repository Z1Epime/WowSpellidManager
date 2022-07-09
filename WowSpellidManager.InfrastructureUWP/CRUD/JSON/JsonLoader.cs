using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Infrastructure.Metadata;

namespace WowSpellidManager.Infrastructure.CRUD.JSON
{
    internal class JsonLoader
    {
        public static ObservableCollection<WowClass> LoadWowClasses()
        {
            ObservableCollection<WowClass> wowClasses = new ObservableCollection<WowClass>();

            if (Directory.Exists(LoadSettings().SavingsPath + "\\WowSpellIDManager\\Data\\Classes"))
            {
                foreach (var @class in Generator.Generate())
                {
                    string readContentsClass;
                    if (File.Exists(LoadSettings().SavingsPath + $"\\WowSpellIDManager\\Data\\Classes\\" +
                        $"{@class.DesignationHolder.Designation}\\{@class.DesignationHolder.Designation}.json"))
                    {
                        using (StreamReader streamReader = new StreamReader(LoadSettings().SavingsPath + $"\\WowSpellIDManager\\Data\\Classes\\" +
                            $"{@class.DesignationHolder.Designation}\\{@class.DesignationHolder.Designation}.json"))
                        {
                            readContentsClass = streamReader.ReadToEnd();
                        }
                        wowClasses.Add(JsonConvert.DeserializeObject<WowClass>(readContentsClass));
                    }


                    wowClasses[wowClasses.Count - 1].Specializations = new List<Specialization>();
                    foreach (var spec in @class.Specializations)
                    {
                        if (File.Exists(LoadSettings().SavingsPath + $"\\WowSpellIDManager\\Data\\Classes\\" +
                            $"{@class.DesignationHolder.Designation}\\Specializations\\{spec.DesignationHolder.Designation}.json"))
                        {
                            string readContentsSpec;
                            using (StreamReader streamReader = new StreamReader(LoadSettings().SavingsPath + $"\\WowSpellIDManager\\Data\\Classes\\" +
                                $"{@class.DesignationHolder.Designation}\\Specializations\\{spec.DesignationHolder.Designation}.json"))
                            {
                                readContentsSpec = streamReader.ReadToEnd();
                            }

                            // safest way to determine newst item of collection ? 
                            wowClasses[wowClasses.Count - 1].Specializations.Add(JsonConvert.DeserializeObject<Specialization>(readContentsSpec));
                        }
                    }
                }
            }
            else
            {
                var abc = LoadSettings().SavingsPath;
                Directory.CreateDirectory(abc + "\\WowSpellIDManager\\Data\\Classes");
                foreach (var @class in Generator.Generate())
                {
                    Directory.CreateDirectory(abc + $"\\WowSpellIDManager\\Data\\Classes\\{@class.DesignationHolder.Designation}\\");
                    File.Create(LoadSettings().SavingsPath + $"\\WowSpellIDManager\\Data\\Classes\\" +
                        $"{@class.DesignationHolder.Designation}\\{@class.DesignationHolder.Designation}.json").Dispose();

                    string jsonClass = JsonConvert.SerializeObject(@class);
                    File.WriteAllText(LoadSettings().SavingsPath + $"\\WowSpellIDManager\\Data\\Classes\\" +
                        $"{@class.DesignationHolder.Designation}\\{@class.DesignationHolder.Designation}.json", jsonClass);


                    foreach (var spec in @class.Specializations)
                    {
                        Directory.CreateDirectory(abc + $"\\WowSpellIDManager\\Data\\Classes\\{@class.DesignationHolder.Designation}\\Specializations\\");
                        File.Create(LoadSettings().SavingsPath + $"\\WowSpellIDManager\\Data\\Classes\\{@class.DesignationHolder.Designation}\\Specializations\\" +
                            $"{spec.DesignationHolder.Designation}.json").Dispose();


                        string jsonSpec = JsonConvert.SerializeObject(spec);
                        File.WriteAllText(LoadSettings().SavingsPath + $"\\WowSpellIDManager\\Data\\Classes\\{@class.DesignationHolder.Designation}" +
                            $"\\Specializations\\{spec.DesignationHolder.Designation}.json", jsonSpec);

                    }
                }
                wowClasses = Generator.Generate();
            }
            return wowClasses;
        }

        public static Settings LoadSettings()
        {
            string readContents;

            // Directory.CreateDirectory only creates a directory if it doesnt already exist
            Directory.CreateDirectory(JsonSaver.SETTINGSPATH);

            if (!File.Exists(JsonSaver.SETTINGSPATH + "settings.JSON"))
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
