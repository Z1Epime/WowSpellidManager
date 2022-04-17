using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Infrastructure.CRUD;
using WowSpellidManager.Infrastructure.Metadata;
using WowSpellidManager.ViewModels;
using WowSpellidManager.ViewModels.Wrapper;

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
                ViewModels.Add(new WowClassViewModel()
                {
                    Description = @class.Description,
                    Designation = new ResourceLoader().GetString(@class.Designation),
                    Guid = @class.Guid,
                    Image = WowClassImagePaths.GetPath(@class.Designation),
                    Specializations = new ObservableCollection<SpecializationViewModel>(@class.Specializations.Select(spec => new SpecializationViewModel()
                    {
                        Designation = new ResourceLoader().GetString(spec.Designation),
                        Guid = spec.Guid,
                        Description = spec.Description,
                        Image = SpecializationImagePaths.GetPath(@class.Designation, spec.Designation),
                        Spells = new ObservableCollection<SpellViewModel>(spec.Spells.Select(spell => new SpellViewModel()
                        {
                            Designation = spell.Designation,
                            Description = spell.AdditionalInfo,
                            Guid = spell.Guid,
                            ID = spell.ID
                        }).ToList())
                    }).ToList())
                });
            }

            return ViewModels;
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