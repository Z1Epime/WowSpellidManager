using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Helper;
using WowSpellidManager.DomainUWP.Models.Spells;
using WowSpellidManager.Infrastructure.CRUD;
using WowSpellidManager.ViewModels;
using WowSpellidManager.ViewModels.Wrapper;

namespace WowSpellidManager.ViewModels.Helper
{
    public class SpellHelper
    {
        private DataOperationProvider fDataOperationProvider = new DataOperationProvider();
        public void AddSpell(string aSpellName, string aSpellID, object aClass, object aSpecialization)
        {
            //var spell = new Spell(new DesignationHolder() { Designation = aSpellName }, 
            //    null, 
            //    new IDHolder() { ID = aSpellID }, 
            //    false, 
            //    Availability.Talent);

            var spell = new Spell()
            {
                Designation = new DesignationHolder() { Designation = aSpellName },
                ID = new IDHolder() { ID = aSpellID },
                Availability = Availability.Talent,
                Cooldown = new Cooldown(),
            };

            foreach (var @class in WowClassHelper.ViewModels)
            {
                if (@class.Guid == (aClass as WowClassViewModel).Guid)
                {
                    foreach (var spec in @class.Specializations)
                    {
                        if (spec.Guid == (aSpecialization as SpecializationViewModel).Guid)
                        {
                            spec.Spells.Add(new SpellViewModel() { ID = spell.ID, 
                                Designation = spell.Designation,
                                AdditionalInfo = spell.AdditionalInfo, 
                                Guid = spell.Guid,
                                Cooldown = spell.Cooldown,
                            });
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

        public void SwitchSpellViewModel(SpellViewModel aOldSpellViewModel, SpellViewModel aNewSpellViewModel)
        {
            foreach (var @class in WowClassHelper.ViewModels)
            {
                foreach (var spec in @class.Specializations)
                {
                    for (int i = 0; i < spec.Spells.Count; i++)
                    {
                        if (spec.Spells[i].Guid.Equals(aOldSpellViewModel.Guid))
                        {
                            spec.Spells[i].Cooldown = aNewSpellViewModel.Cooldown;
                            spec.Spells[i].Cost = aNewSpellViewModel.Cost;
                            spec.Spells[i].Cast= aNewSpellViewModel.Cast;
                            spec.Spells[i].AdditionalInfo = aNewSpellViewModel.AdditionalInfo;
                            spec.Spells[i].Availability = aNewSpellViewModel.Availability;
                            spec.Spells[i].Charges = aNewSpellViewModel.Charges;
                            spec.Spells[i].Designation = aNewSpellViewModel.Designation;
                            spec.Spells[i].Guid = aNewSpellViewModel.Guid;
                            spec.Spells[i].ID = aNewSpellViewModel.ID;
                            spec.Spells[i].IsPassive = aNewSpellViewModel.IsPassive;
                            spec.Spells[i].Range = aNewSpellViewModel.Range;
                            spec.Spells[i].ToolTipText = aNewSpellViewModel.ToolTipText;
                        }
                    }
                }
            }
        }
    }
}