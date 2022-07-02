using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Spells;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Core
{
    public class ResourceViewModel
    {
        private Resource fResource;

        public double Amount
        {
            get => fResource.Amount;
            set => fResource.Amount = value;
        }

        public ResourceType Designation
        {
            get => fResource.Designation;
            set => fResource.Designation= value;
        }

        public ResourceViewModel(Resource aResource)
        {
            fResource = aResource;
        }
    }
}
