using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using WowSpellidManager.DomainUWP.Models.Helper;
using WowSpellidManager.DomainUWP.Models.Spells;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Holder
{
    public class AvailabilityHolderViewModel : INotifyPropertyChanged
    {
        private AvailabilityHolder fAvailabilityHolder;

        public Availability Availability
        {
            get
            {
                return fAvailabilityHolder.Availability;
            }

            set
            {
                if (fAvailabilityHolder.Availability != value)
                {
                    fAvailabilityHolder.Availability = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public IEnumerable<Availability> AvailabilityValues
        {
            get
            {
                return Enum.GetValues(typeof(Availability))
                    .Cast<Availability>();
            }
        }

        public AvailabilityHolderViewModel(AvailabilityHolder aAvailabilityHolder)
        {
            fAvailabilityHolder = aAvailabilityHolder;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
