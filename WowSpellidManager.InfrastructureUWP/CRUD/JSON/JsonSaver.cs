using Newtonsoft.Json;
using System.IO;
using Windows.Storage;

namespace WowSpellidManager.Infrastructure.CRUD.JSON
{
    public class JsonSaver
    {
        public static DataOperationProvider fDataOperationProvider = new DataOperationProvider();
        public static readonly string SETTINGSPATH = ApplicationData.Current.LocalFolder.Path + "\\WowSpellIDManager\\Settings\\";

        public static void SaveWowClasses()
        {
            string savingsPath = fDataOperationProvider.SettingsOperator.GetSettings().SavingsPath;

            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Include;

            if (!Directory.Exists(savingsPath + "\\WowSpellIDManager\\Data\\Classes\\"))
            {
                Directory.CreateDirectory(savingsPath + "\\WowSpellIDManager\\Data\\Classes\\");
            }

            foreach (var @class in fDataOperationProvider.WowClassOperator.GetWowClasses())
            {
                Directory.CreateDirectory(savingsPath + $"\\WowSpellIDManager\\Data\\Classes\\{@class.DesignationHolder.Designation}\\");

                using (StreamWriter sw = new StreamWriter(savingsPath + $"\\WowSpellIDManager\\Data\\Classes\\" +
                    $"{@class.DesignationHolder.Designation}\\{@class.DesignationHolder.Designation}.json"))
                {
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, @class);
                    }
                }


                foreach (var spec in @class.Specializations)
                {
                    Directory.CreateDirectory(savingsPath + $"\\WowSpellIDManager\\Data\\Classes\\{@class.DesignationHolder.Designation}" +
                        $"\\Specializations\\");

                    using (StreamWriter sw = new StreamWriter(savingsPath + $"\\WowSpellIDManager\\Data\\Classes\\{@class.DesignationHolder.Designation}" +
                        $"\\Specializations\\{spec.DesignationHolder.Designation}.json"))
                    {
                        using (JsonWriter writer = new JsonTextWriter(sw))
                        {
                            serializer.Serialize(writer, spec);
                        }
                    }
                }
            }
        }

        public static void SaveSettings()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(SETTINGSPATH + "settings.JSON"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, fDataOperationProvider.SettingsOperator.GetSettings());
            }
        }
    }
}
