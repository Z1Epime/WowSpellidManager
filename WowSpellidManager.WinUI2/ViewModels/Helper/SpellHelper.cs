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
using WowSpellidManager.ViewModels.Wrapper.Main;

namespace WowSpellidManager.ViewModels.Helper
{
    public class SpellHelper
    {
        private DataOperationProvider fDataOperationProvider = new DataOperationProvider();
        public void AddSpell(string aSpellName, string aSpellID, object aClass, object aSpecialization)
        {
            var spell = new Spell()
            {
                DesignationHolder = new DesignationHolder() { Designation = aSpellName },
                ID = new IDHolder() { ID = aSpellID },
                Cooldown = new Cooldown(),
            };

            foreach (var @class in WowClassHelper.ViewModels)
            {
                if (@class.GuidHolder == (aClass as WowClassViewModel).GuidHolder)
                {
                    foreach (var spec in @class.Specializations)
                    {
                        if (spec.GuidHolder == (aSpecialization as SpecializationViewModel).GuidHolder)
                        {
                            spec.Spells.Add(new SpellViewModel() { IDHolder = spell.ID, 
                                DesignationHolder = spell.DesignationHolder,
                                AdditionalInfoHolder = spell.AdditionalInfoHolder, 
                                GuidHolder = spell.GuidHolder,
                                Cooldown = spell.Cooldown,
                            });
                        }
                    }
                }

            }

            fDataOperationProvider.SpellOperator.AddSpell(spell, ((WowClassViewModel)aClass).GuidHolder, ((SpecializationViewModel)aSpecialization).GuidHolder);
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
                        if (spell.GuidHolder == ((SpellViewModel)aSpell).GuidHolder)
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
                        if (spec.Spells[i].GuidHolder.Equals(aOldSpellViewModel.GuidHolder))
                        {
                            spec.Spells[i].Cooldown = aNewSpellViewModel.Cooldown;
                            spec.Spells[i].Cost = aNewSpellViewModel.Cost;
                            spec.Spells[i].Cast= aNewSpellViewModel.Cast;
                            spec.Spells[i].AdditionalInfoHolder = aNewSpellViewModel.AdditionalInfoHolder;
                            spec.Spells[i].AvailabilityHolder = aNewSpellViewModel.AvailabilityHolder;
                            spec.Spells[i].ChargesHolder = aNewSpellViewModel.ChargesHolder;
                            spec.Spells[i].DesignationHolder = aNewSpellViewModel.DesignationHolder;
                            spec.Spells[i].GuidHolder = aNewSpellViewModel.GuidHolder;
                            spec.Spells[i].IDHolder = aNewSpellViewModel.IDHolder;
                            spec.Spells[i].IsPassiveHolder = aNewSpellViewModel.IsPassiveHolder;
                            spec.Spells[i].Range = aNewSpellViewModel.Range;
                            spec.Spells[i].ToolTipTextHolder = aNewSpellViewModel.ToolTipTextHolder;
                        }
                    }
                }
            }
        }
    }
}