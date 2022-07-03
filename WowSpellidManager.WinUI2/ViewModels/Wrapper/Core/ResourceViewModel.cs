using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Spells;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Core
{
    public class ResourceViewModel : INotifyPropertyChanged
    {
        private Resource fResource;

        public double Amount
        {
            get
            {
                return fResource.Amount;
            }

            set
            {
                if (fResource.Amount != value)
                {
                    fResource.Amount = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ResourceType Designation
        {
            get
            {
                return fResource.Designation;
            }

            set
            {
                if (fResource.Designation != value)
                {
                    fResource.Designation = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public IEnumerable<ResourceType> ResourceUnitValues
        {
            get
            {
                return Enum.GetValues(typeof(ResourceType))
                    .Cast<ResourceType>();
            }
        }

        public ResourceViewModel(Resource aResource)
        {
            fResource = aResource;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
