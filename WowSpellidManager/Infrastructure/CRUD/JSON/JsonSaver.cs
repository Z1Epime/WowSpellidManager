﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.Infrastructure.CRUD.JSON
{
    public class JsonSaver
    {
        private static DataOperationProvider fDataOperationProvider = new DataOperationProvider();
        public const string fWOWCLASSESPATH = "E:\\VisualStudio Projects\\WowSpellidManager\\WowSpellidManager\\bin\\x86\\Debug\\net6.0-windows10.0.19041.0\\Data\\wowclasses.JSON";
        public const string fSETTINGSPATH = "E:\\VisualStudio Projects\\WowSpellidManager\\WowSpellidManager\\Settings\\settings.JSON";
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

            using (StreamWriter sw = new StreamWriter(fSETTINGSPATH))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, fDataOperationProvider.SettingsOperator.GetSettings());
            }
        }
    }
}
