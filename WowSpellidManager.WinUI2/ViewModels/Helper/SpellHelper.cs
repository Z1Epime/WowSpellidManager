using System;
using System.Linq;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Helper;
using WowSpellidManager.Infrastructure.CRUD;
using WowSpellidManager.ViewModels.Wrapper.Main;
using WowSpellidManager.WinUI2.ViewModels.Wrapper.Core;
using WowSpellidManager.WinUI2.ViewModels.Wrapper.Holder;

namespace WowSpellidManager.ViewModels.Helper
{
    public class SpellHelper
    {
        private DataOperationProvider fDataOperationProvider = new DataOperationProvider();
        public void AddSpell(string aSpellName, string aSpellID, WowClassViewModel aClass, SpecializationViewModel aSpecialization)
        {
            var spell = new Spell()
            {
                DesignationHolder = new DesignationHolder() { Designation = aSpellName },
                IDHolder = new IDHolder() { ID = aSpellID },
                Cooldown = new Cooldown(),
                GuidHolder = new GuidHolder() { Guid = Guid.NewGuid() },
                AdditionalInfoHolder = new AdditionalInfoHolder(),
                AvailabilityHolder = new AvailabilityHolder(),
                Cast = new Cast(),
                ChargesHolder = new ChargesHolder(),
                Cost = new Resource(),
                IsPassiveHolder = new IsPassiveHolder(),
                Range = new Range(),
                ToolTipTextHolder = new ToolTipTextHolder(),
            };

            foreach (var @class in WowClassHelper.ViewModels)
            {
                if (@class.GuidHolder == (aClass as WowClassViewModel).GuidHolder)
                {
                    foreach (var spec in @class.Specializations)
                    {
                        if (spec.GuidHolder == (aSpecialization as SpecializationViewModel).GuidHolder)
                        {
                            spec.Spells.Add(new SpellViewModel()
                            {
                                IDHolderViewModel = new IDHolderViewModel(spell.IDHolder),
                                DesignationHolderViewModel = new DesignationHolderViewModel(spell.DesignationHolder),
                                AdditionalInfoHolderViewModel = new AdditionalInfoHolderViewModel(spell.AdditionalInfoHolder),
                                GuidHolder = spell.GuidHolder,
                                CooldownViewModel = new CooldownViewModel(spell.Cooldown),
                                ChargesHolderViewModel = new ChargesHolderViewModel(spell.ChargesHolder),
                                AvailabilityHolderViewModel = new AvailabilityHolderViewModel(spell.AvailabilityHolder),
                                CastViewModel = new CastViewModel(spell.Cast),
                                CostViewModel = new ResourceViewModel(spell.Cost),
                                IsPassiveHolderViewModel = new IsPassiveHolderViewModel(spell.IsPassiveHolder),
                                RangeViewModel = new RangeViewModel(spell.Range),
                                ToolTipTextHolderViewModel = new ToolTipTextHolderViewModel(spell.ToolTipTextHolder),
                            });
                        }
                    }
                }

            }

            if (aSpecialization.DesignationHolder.Designation == "General")
                fDataOperationProvider.SpellOperator.AddSpellToClass(spell, aClass.GuidHolder);
            else
                fDataOperationProvider.SpellOperator.AddSpell(spell, aClass.GuidHolder, aSpecialization.GuidHolder);

            fDataOperationProvider.WowClassOperator.Save();
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
    }
}