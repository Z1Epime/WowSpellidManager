using System;
using System.Collections.ObjectModel;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Helper;
using WowSpellidManager.Infrastructure.DataManager;

namespace WowSpellidManager.Infrastructure.CRUD
{
    public class SpellOperator
    {
        private static DataOperationProvider fDataOperationProvider = new DataOperationProvider();

        public void RemoveClassSpell(Guid aSpellGuid)
        {
            foreach (var @class in fDataOperationProvider.WowClassOperator.GetWowClasses())
            {
                for (int i = 0; i < @class.Spells.Count; i++)
                {
                    if (@class.Spells[i].GuidHolder.Guid == aSpellGuid)
                    {
                        @class.Spells.Remove(@class.Spells[i]);
                    }
                }
            }
        }

        public void RemoveSpecializationSpell(Guid aSpecializationGuid, Guid aSpellGuid)
        {
            foreach (var @class in fDataOperationProvider.WowClassOperator.GetWowClasses())
            {
                foreach (var spec in @class.Specializations)
                {
                    if (spec.GuidHolder.Guid == aSpecializationGuid)
                    {
                        for (int i = 0; i < spec.Spells.Count; i++)
                        {
                            if (spec.Spells[i].GuidHolder.Guid == aSpellGuid)
                            {
                                spec.Spells.Remove(spec.Spells[i]);
                            }
                        }
                    }
                }
            }
        }

        public Spell GetSpell(GuidHolder aSpellGuid)
        {
            foreach (var wowClass in DataHolder.DataProvider.DataHolder.WowClasses)
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
            foreach (var wowClass in DataHolder.DataProvider.DataHolder.WowClasses)
            {
                if (wowClass.GuidHolder.Guid == aClassGuid.Guid)
                {
                    foreach (var spec in wowClass.Specializations)
                    {
                        if (spec.GuidHolder == aSpecializationGuid)
                        {
                            spec.Spells.Add(aSpell);
                        }
                    }
                }
            }
        }

        public void AddSpellToClass(Spell aSpell, GuidHolder aClassGuid)
        {
            // TODO: use linq here
            foreach (var wowClass in DataHolder.DataProvider.DataHolder.WowClasses)
            {
                if (wowClass.GuidHolder.Guid == aClassGuid.Guid)
                {
                    wowClass.Spells.Add(aSpell);
                }
            }
        }
    }
}
