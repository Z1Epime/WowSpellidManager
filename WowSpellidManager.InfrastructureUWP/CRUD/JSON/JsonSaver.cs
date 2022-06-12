using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace WowSpellidManager.Infrastructure.CRUD.JSON
{
    public class JsonSaver
    {
        public static DataOperationProvider fDataOperationProvider = new DataOperationProvider();
        //public static readonly string SETTINGSPATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\WowSpellIDManager\\Settings\\";
        public static readonly string SETTINGSPATH = ApplicationData.Current.LocalFolder.Path + "\\WowSpellIDManager\\Settings\\";
        //public static readonly string SETTINGSPATH = KnownFolders.DocumentsLibrary.Path + "\\WowSpellIDManager\\Settings\\";
        public static void SaveWowClasses()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            if (!Directory.Exists(fDataOperationProvider.SettingsOperator.GetSettings().SavingsPath + "\\WowSpellIDManager\\Data\\"))
            {
                Directory.CreateDirectory(fDataOperationProvider.SettingsOperator.GetSettings().SavingsPath + "\\WowSpellIDManager\\Data\\");
            }

            using (StreamWriter sw = new StreamWriter(fDataOperationProvider.SettingsOperator.GetSettings().SavingsPath + "\\WowSpellIDManager\\Data\\wowclasses.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, fDataOperationProvider.WowClassOperator.GetWowClasses());
            }
        }

        public static void SaveSettings()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(SETTINGSPATH +"settings.JSON"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, fDataOperationProvider.SettingsOperator.GetSettings());
            }
        }
    }
}
