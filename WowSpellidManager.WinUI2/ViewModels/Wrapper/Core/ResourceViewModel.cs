using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Spells;
using WowSpellidManager.Infrastructure.CRUD;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Core
{
    public class ResourceViewModel : INotifyPropertyChanged, IAutoSave
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
                    Save();
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
                    Save();
                }
            }
        }

        private bool fHasCost;
        public bool HasCost
        {
            get
            {
                if (Amount > 0)
                    fHasCost = true;
                else
                    fHasCost = false;
                return fHasCost;
            }

            set
            {
                if (value == false)
                    Amount = 0;
                else
                    Amount = 1;
                fHasCost = value;
                Save();
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

        public DataOperationProvider DataOperationProvider => new DataOperationProvider();

        public ResourceViewModel(Resource aResource)
        {
            fResource = aResource;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Save()
        {
            DataOperationProvider.WowClassOperator.Save();
        }
    }
}
