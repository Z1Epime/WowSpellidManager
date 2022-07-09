using System.Collections.ObjectModel;
using System.Linq;
using Windows.ApplicationModel.Resources;
using WowSpellidManager.DomainUWP.Models.Helper;
using WowSpellidManager.Infrastructure.CRUD;
using WowSpellidManager.Infrastructure.Metadata;
using WowSpellidManager.ViewModels.Wrapper.Main;
using WowSpellidManager.WinUI2.ViewModels.Wrapper.Core;
using WowSpellidManager.WinUI2.ViewModels.Wrapper.Holder;

namespace WowSpellidManager.ViewModels.Helper
{
    public class WowClassHelper
    {
        private DataOperationProvider fDataOperationProvider = new DataOperationProvider();
        public static ObservableCollection<WowClassViewModel> ViewModels { get; set; }

        public ObservableCollection<WowClassViewModel> GetWowClasses()
        {
            ViewModels = new ObservableCollection<WowClassViewModel>();

            foreach (var @class in fDataOperationProvider.WowClassOperator.GetWowClasses())
            {
                var helper = WowClassImagePaths.GetPath(@class.DesignationHolder.Designation);
                ViewModels.Add(new WowClassViewModel()
                {
                    DesignationHolder = new DesignationHolder() { Designation = new ResourceLoader().GetString(@class.DesignationHolder.Designation) },
                    GuidHolder = @class.GuidHolder,
                    Image = WowClassImagePaths.GetPath(@class.DesignationHolder.Designation),
                    Spells = new ObservableCollection<SpellViewModel>(@class.Spells.Select(spell => new SpellViewModel()
                    {
                        DesignationHolderViewModel = new DesignationHolderViewModel(spell.DesignationHolder),
                        AdditionalInfoHolderViewModel = new AdditionalInfoHolderViewModel(spell.AdditionalInfoHolder),
                        GuidHolder = spell.GuidHolder,
                        IDHolderViewModel = new IDHolderViewModel(spell.IDHolder),
                        AvailabilityHolderViewModel = new AvailabilityHolderViewModel(spell.AvailabilityHolder),
                        CastViewModel = new CastViewModel(spell.Cast),
                        ChargesHolderViewModel = new ChargesHolderViewModel(spell.ChargesHolder),
                        CooldownViewModel = new CooldownViewModel(spell.Cooldown),
                        ToolTipTextHolderViewModel = new ToolTipTextHolderViewModel(spell.ToolTipTextHolder),
                        RangeViewModel = new RangeViewModel(spell.Range),
                        IsPassiveHolderViewModel = new IsPassiveHolderViewModel(spell.IsPassiveHolder),
                        CostViewModel = new ResourceViewModel(spell.Cost),
                    })),
                    Specializations = new ObservableCollection<SpecializationViewModel>(@class.Specializations.Select(spec => new SpecializationViewModel()
                    {
                        DesignationHolder = new DesignationHolder() { Designation = new ResourceLoader().GetString(spec.DesignationHolder.Designation) },
                        GuidHolder = spec.GuidHolder,
                        Image = SpecializationImagePaths.GetPath(@class.DesignationHolder.Designation, spec.DesignationHolder.Designation),
                        Spells = new ObservableCollection<SpellViewModel>(spec.Spells.Select(spell => new SpellViewModel()
                        {
                            DesignationHolderViewModel = new DesignationHolderViewModel(spell.DesignationHolder),
                            AdditionalInfoHolderViewModel = new AdditionalInfoHolderViewModel(spell.AdditionalInfoHolder),
                            GuidHolder = spell.GuidHolder,
                            IDHolderViewModel = new IDHolderViewModel(spell.IDHolder),
                            AvailabilityHolderViewModel = new AvailabilityHolderViewModel(spell.AvailabilityHolder),
                            CastViewModel = new CastViewModel(spell.Cast),
                            ChargesHolderViewModel = new ChargesHolderViewModel(spell.ChargesHolder),
                            CooldownViewModel = new CooldownViewModel(spell.Cooldown),
                            ToolTipTextHolderViewModel = new ToolTipTextHolderViewModel(spell.ToolTipTextHolder),
                            RangeViewModel = new RangeViewModel(spell.Range),
                            IsPassiveHolderViewModel = new IsPassiveHolderViewModel(spell.IsPassiveHolder),
                            CostViewModel = new ResourceViewModel(spell.Cost),
                        }).ToList())
                    }).ToList())
                });
            }

            foreach (var @class in ViewModels)
            {
                @class.Specializations.Insert(0, new SpecializationViewModel() { 
                    Spells = @class.Spells,
                    DesignationHolder = new DesignationHolder() { Designation = "General"},
                    Image = SpecializationImagePaths.GENERAL,
                });
            }

            return ViewModels;
        }

        public void SaveWowClasses()
        {
            fDataOperationProvider.SpellOperator.Save();
        }
    }
}