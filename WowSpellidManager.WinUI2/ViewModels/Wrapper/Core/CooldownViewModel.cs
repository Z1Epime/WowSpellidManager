using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Spells;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Core
{
    public class CooldownViewModel
    {
        private Cooldown fCooldown;

        public double Number
        {
            get => fCooldown.Number;
            set => fCooldown.Number = value;
        }

        public TimeUnit TimeUnit
        {
            get => fCooldown.Unit;
            set => fCooldown.Unit = value;
        }

        public CooldownViewModel(Cooldown aCooldown)
        {
            fCooldown = aCooldown;
        }
    }
}
