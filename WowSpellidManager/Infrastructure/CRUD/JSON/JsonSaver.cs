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
        private const string fPATH = "E:\\VisualStudio Projects\\WowSpellidManager\\Data";
        public static void SaveSpells()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(fPATH))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                foreach(var spell in fDataOperationProvider.fSpellOperator.GetSpells())
                {
                    serializer.Serialize(writer, spell);
                }
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
