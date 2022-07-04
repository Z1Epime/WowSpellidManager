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
    public class CooldownViewModel : INotifyPropertyChanged, IAutoSave
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
                    Save();
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
                    Save();
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
                Save();
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

        public DataOperationProvider DataOperationProvider => new DataOperationProvider();

        public CooldownViewModel(Cooldown aCooldown)
        {
            fCooldown = aCooldown;
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
