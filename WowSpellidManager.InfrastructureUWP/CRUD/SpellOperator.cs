using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Helper;
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

        public Spell GetSpell(GuidHolder aSpellGuid)
        {
            foreach(var wowClass in DataHolder.DataProvider.DataHolder.WowClasses)
            {
                foreach (var spec in wowClass.Specializations)
                {
                    foreach (var spell in spec.Spells)
                    {
                        if (spell.GuidHolder.Guid == aSpellGuid.Guid)
                        {
                            return spell;
                        }
                    }
                }
            }
            return null;
        }

        public void Save()
        {
            DataHolder.DataProvider.DataParser.Save();
        }
        
        public void AddSpell(Spell aSpell, GuidHolder aClassGuid, GuidHolder aSpecializationGuid)
        {
            // TODO: use linq here
            foreach(var wowClass in DataHolder.DataProvider.DataHolder.WowClasses)
            {
                if(wowClass.GuidHolder.Guid == aClassGuid.Guid)
                {
                    foreach(var spec in wowClass.Specializations)
                    {
                        if(spec.GuidHolder == aSpecializationGuid)
                        {
                            spec.Spells.Add(aSpell);
                        }
                    }
                }
            }
        }


    }
}
