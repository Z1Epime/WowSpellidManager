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
    public class HelperWowClassViewModel : ViewModel
    {
        public ObservableCollection<WowClassViewModel> GetWowClasses()
        {
            var wowClasses = new ObservableCollection<WowClassViewModel>();

            foreach (var @class in fDataOperationProvider.WowClassOperator.GetWowClasses())
            {
                wowClasses.Add(new WowClassViewModel(@class));

                var specquery = from spec in @class.Specializations
                                select spec;
                var specializationVMs = new ObservableCollection<SpecializationViewModel>();

                foreach (var specialization in specquery)
                {
                    specializationVMs.Add(new SpecializationViewModel(specialization));

                    var spellquery = from spellq in specialization.Spells
                                     select spellq;
                    var spellVMs = new ObservableCollection<SpellViewModel>();

                    foreach (var spell in spellquery)
                    {
                        spellVMs.Add(new SpellViewModel(spell));
                    }
                }
            }

            return wowClasses;
        }

        public void AddWowClass(string aDesignation, string aDescription)
        {
            fDataOperationProvider.WowClassOperator.AddWowClass(new WowClass(aDesignation, aDescription));
        }

        public void SaveWowClasses()
        {
            fDataOperationProvider.SpellOperator.Save();
        }
    }
}