using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Spells;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Core
{
    public class CooldownViewModel : INotifyPropertyChanged
    {
        private Cooldown fCooldown;

        public double Number
        {
            get
            {
                return fCooldown.Number;
            }

            set
            {
                if (fCooldown.Number != value)
                {
                    fCooldown.Number = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public TimeUnit Unit
        {
            get
            {
                return fCooldown.Unit;
            }

            set
            {
                if (fCooldown.Unit != value)
                {
                    fCooldown.Unit = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool fHasCooldown;
        public bool HasCooldown
        {
            get
            {
                if (Number > 0)
                    fHasCooldown = true;
                else
                    fHasCooldown = false;
                return fHasCooldown;
            }

            set
            {
                if (value == false)
                    Number = 0;
                else
                    Number = 1;
                fHasCooldown = value;
            }
        }

        public IEnumerable<TimeUnit> TimeUnitValues
        {
            get
            {
                return Enum.GetValues(typeof(TimeUnit))
                    .Cast<TimeUnit>();
            }
        }

        public CooldownViewModel(Cooldown aCooldown)
        {
            fCooldown = aCooldown;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
