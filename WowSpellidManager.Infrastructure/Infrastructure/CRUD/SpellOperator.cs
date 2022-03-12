using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Infrastructure.DataManager;

namespace WowSpellidManager.Infrastructure.CRUD
{
    public class SpellOperator
    {
        private static DataOperationProvider fDataOperationProvider = new DataOperationProvider();

        public ObservableCollection<Spell> GetSpells()
        {
            //return DataHolder.DataProvider.DataHolder.Spells;
            return null;
        }

        public void Save()
        {
            DataHolder.DataProvider.DataParser.Save();
        }
        
        public void AddSpell(Spell aSpell, WowClass aClass, Specialization aSpecialization)
        {
            // TODO: use linq here
            foreach(var wowClass in DataHolder.DataProvider.DataHolder.WowClasses)
            {
                if(wowClass == aClass)
                {
                    foreach(var spec in wowClass.Specializations)
                    {
                        if(spec == aSpecialization)
                        {
                            spec.Spells.Add(aSpell);
                        }
                    }
                }
            }
        }


    }
}
