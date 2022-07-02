using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Helper;
using WowSpellidManager.Infrastructure.CRUD;
using WowSpellidManager.Infrastructure.Metadata;
using WowSpellidManager.ViewModels;
using WowSpellidManager.ViewModels.Wrapper.Main;
using WowSpellidManager.WinUI2.ViewModels.Wrapper.Core;

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
                    Specializations = new ObservableCollection<SpecializationViewModel>(@class.Specializations.Select(spec => new SpecializationViewModel()
                    {
                        DesignationHolder = new DesignationHolder() { Designation = new ResourceLoader().GetString(spec.DesignationHolder.Designation) },
                        GuidHolder = spec.GuidHolder,
                        Image = SpecializationImagePaths.GetPath(@class.DesignationHolder.Designation, spec.DesignationHolder.Designation),
                        Spells = new ObservableCollection<SpellViewModel>(spec.Spells.Select(spell => new SpellViewModel()
                        {
                            DesignationHolder = spell.DesignationHolder,
                            AdditionalInfoHolder = spell.AdditionalInfoHolder,
                            GuidHolder = spell.GuidHolder,
                            IDHolder = spell.ID,
                            AvailabilityHolder = spell.AvailabilityHolder,
                            CastViewModel = new CastViewModel(spell.Cast),
                            ChargesHolder = spell.ChargesHolder,
                            CooldownViewModel = new CooldownViewModel(spell.Cooldown),
                            ToolTipTextHolder = spell.ToolTipTextHolder,
                            RangeViewModel = new RangeViewModel(spell.Range),
                            IsPassiveHolder = spell.IsPassiveHolder,
                            CostViewModel = new ResourceViewModel(spell.Cost),
                        }).ToList())
                    }).ToList())
                });
            }

            //foreach (var @class in fDataOperationProvider.WowClassOperator.GetWowClasses())
            //{
            //    foreach (var spec in @class.Specializations)
            //    {
            //        foreach (var spell in spec.Spells)
            //        {
            //            if (spell.Designation == "asd")
            //            {


            //                foreach (var @class2 in ViewModels)
            //                {
            //                    foreach (var spec2 in @class2.Specializations)
            //                    {
            //                        foreach (var spell2 in spec2.Spells)
            //                        {
            //                            if (spell2.Designation == "asd")
            //                            {

            //                                if (ReferenceEquals(spell.ID, spell2.ID))
            //                                {
            //                                    Console.WriteLine("They are !");
            //                                }

            //                                if (ReferenceEquals(spell.Designation, spell2.Designation))
            //                                {
            //                                    Console.WriteLine("They are !");
            //                                }


            //                            }
            //                        }
            //                    }
            //                }


            //            }
            //        }
            //    }
            //}

            return ViewModels;
        }

        public void SaveWowClasses()
        {
            fDataOperationProvider.SpellOperator.Save();
        }
    }
}