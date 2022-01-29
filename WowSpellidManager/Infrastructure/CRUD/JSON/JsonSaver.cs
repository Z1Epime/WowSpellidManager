using Newtonsoft.Json;
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
        public const string fSPELLSPATH = "E:\\VisualStudio Projects\\WowSpellidManager\\WowSpellidManager\\bin\\x86\\Debug\\net6.0-windows10.0.19041.0\\Data\\spells.JSON";
        public const string fSPECIALIZATIONSPATH = "E:\\VisualStudio Projects\\WowSpellidManager\\WowSpellidManager\\bin\\x86\\Debug\\net6.0-windows10.0.19041.0\\Data\\specializations.JSON";
        public const string fWOWCLASSESPATH = "E:\\VisualStudio Projects\\WowSpellidManager\\WowSpellidManager\\bin\\x86\\Debug\\net6.0-windows10.0.19041.0\\Data\\wowclasses.JSON";
        public static void SaveSpells()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(fSPELLSPATH))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {

                //string json = JsonConvert.SerializeObject(fDataOperationProvider.SpellOperator.GetSpells(), Formatting.Indented);
                
                    serializer.Serialize(writer, fDataOperationProvider.SpellOperator.GetSpells());
                
            }
        }

        public static void SaveSpecializations()
        {
            return;
        }

        public static void SaveWowClasses()
        {
            return;
        }
    }
}
