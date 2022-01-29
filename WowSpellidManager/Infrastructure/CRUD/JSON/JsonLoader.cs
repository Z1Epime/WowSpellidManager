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

namespace WowSpellidManager.Infrastructure.CRUD.JSON
{
    internal class JsonLoader
    {
        private static DataOperationProvider fDataOperationProvider = new DataOperationProvider();

        public static ObservableCollection<Spell> LoadSpells()
        {

            string readContents;
            using (StreamReader streamReader = new StreamReader(JsonSaver.fSPELLSPATH))
            {
                readContents = streamReader.ReadToEnd();
            }

            ObservableCollection<Spell> spells = new ObservableCollection<Spell>();
            spells = JsonConvert.DeserializeObject<ObservableCollection<Spell>>(readContents);

            return (ObservableCollection<Spell>) spells;
        }

        public static ObservableCollection<Specialization> LoadSpecializations()
        {

            string readContents;
            using (StreamReader streamReader = new StreamReader(JsonSaver.fSPELLSPATH))
            {
                readContents = streamReader.ReadToEnd();
            }

            ObservableCollection<Specialization> specializations = new ObservableCollection<Specialization>();
            specializations = JsonConvert.DeserializeObject<ObservableCollection<Specialization>>(readContents);

            return (ObservableCollection<Specialization>)specializations;
        }

        public static ObservableCollection<WowClass> LoadWowClasses()
        {

            string readContents;
            using (StreamReader streamReader = new StreamReader(JsonSaver.fSPELLSPATH))
            {
                readContents = streamReader.ReadToEnd();
            }

            ObservableCollection<WowClass> wowClasses = new ObservableCollection<WowClass>();
            wowClasses = JsonConvert.DeserializeObject<ObservableCollection<WowClass>>(readContents);

            return (ObservableCollection<WowClass>)wowClasses;
        }
    }
}
