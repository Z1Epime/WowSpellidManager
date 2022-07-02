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
