using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.ViewModels;
using WowSpellidManager.ViewModels.Wrapper;

namespace WowSpellidManager.ViewModels.Helper
{
    public class HelperSpellViewModel : ViewModel
    {
        public void AddSpell(string aSpellName, string aSpellID, string aSpellDescription, object aClass, object aSpecialization)
        {
            fDataOperationProvider.SpellOperator.AddSpell(new Spell(aSpellName, aSpellDescription,
                aSpellID), ((WowClassViewModel)aClass).WowClass, ((SpecializationViewModel)aSpecialization).Specialization);
        }

        public void RemoveSpell(object aSpecialization, object aSpell)
        {
            ((SpecializationViewModel)aSpecialization).Spells.Remove(aSpell as Spell);
        }

        public Spell GetLastSpellOfSpecialization(object aSpecialization)
        {
            return ((SpecializationViewModel)aSpecialization).Spells.LastOrDefault();
        }

        public bool HasSpells(object aSpecialization)
        {
            return ((SpecializationViewModel)aSpecialization).Spells.Any();
        }
    }
}