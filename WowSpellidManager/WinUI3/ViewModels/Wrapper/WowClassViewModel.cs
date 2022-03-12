using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using WowSpellidManager.Domain.Models;

namespace WowSpellidManager.WinUI3.ViewModels.Wrapper
{
    public class WowClassViewModel
    {
        public WowClass WowClass { get; set; }

        public string Description
        {
            get
            {
                return WowClass.Description;
            }
            set
            {
                WowClass.Description = value;
            }
        }

        public List<SpecializationViewModel> Specializations
        {
            get
            {
                return WrapSpecialization(WowClass.Specializations);
            }
            set
            {
                WowClass.Specializations = UnwrapSpecialization(value);
            }
        }

        public Guid Guid
        {
            get
            {
                return WowClass.Guid;
            }
            set
            {
                WowClass.Guid = value;
            }
        }

        public string Designation
        {
            get
            {
                return new ResourceLoader().GetString(WowClass.Designation);
            }
            set
            {
                WowClass.Designation = value;
            }
        }

        public WowClassViewModel(WowClass aWowClass)
        {
            WowClass = aWowClass;
        }

        public List<SpecializationViewModel> WrapSpecialization(List<Specialization> aSpecializations)
        {
            var list = new List<SpecializationViewModel>();
            foreach (var specialization in aSpecializations)
            {
                list.Add(new SpecializationViewModel(specialization));
            }
            return list;
        }

        public List<Specialization> UnwrapSpecialization(List<SpecializationViewModel> aSpecializationViewModels)
        {
            var list = new List<Specialization>();
            foreach (var specialitaionVM in aSpecializationViewModels)
            {
                list.Add(specialitaionVM.Specialization);
            }
            return list;
        }
    }
}
