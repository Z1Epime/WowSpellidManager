using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Infrastructure.CRUD;
using WowSpellidManager.ViewModels;
using WowSpellidManager.ViewModels.Wrapper;

namespace WowSpellidManager.ViewModels.Helper
{
    public class SpellHelper
    {
        private DataOperationProvider fDataOperationProvider = new DataOperationProvider();
        public void AddSpell(string aSpellName, string aSpellID, string aSpellDescription, object aClass, object aSpecialization)
        {
            var spell = new Spell(aSpellName, aSpellDescription, aSpellID);

            foreach (var @class in WowClassHelper.ViewModels)
            {
                if (@class.Guid == (aClass as WowClassViewModel).Guid)
                {
                    foreach (var spec in @class.Specializations)
                    {
                        if (spec.Guid == (aSpecialization as SpecializationViewModel).Guid)
                        {
                            spec.Spells.Add(new SpellViewModel() { ID = spell.ID, Designation = spell.Designation, Description = spell.AdditionalInfo, Guid = spell.Guid });
                        }
                    }
                }

            }

            fDataOperationProvider.SpellOperator.AddSpell(spell, ((WowClassViewModel)aClass).Guid, ((SpecializationViewModel)aSpecialization).Guid);
        }

        public void RemoveSpell(object aSpecialization, object aSpell)
        {
            ((SpecializationViewModel)aSpecialization).Spells.Remove(aSpell as SpellViewModel);
            foreach (var @class in fDataOperationProvider.WowClassOperator.GetWowClasses())
            {
                foreach (var spec in @class.Specializations)
                {
                    for (int i = 0; i < spec.Spells.Count; i++)
                    {
                        var spell = spec.Spells[i];
                        if (spell.Guid == ((SpellViewModel)aSpell).Guid)
                        {
                            spec.Spells.Remove(spec.Spells[i]);
                        }
                    }
                }
            }
        }

        public SpellViewModel GetLastSpellOfSpecialization(object aSpecialization)
        {
            return ((SpecializationViewModel)aSpecialization).Spells.LastOrDefault();
        }

        public bool HasSpells(object aSpecialization)
        {
            return ((SpecializationViewModel)aSpecialization).Spells.Any();
        }
    }
}