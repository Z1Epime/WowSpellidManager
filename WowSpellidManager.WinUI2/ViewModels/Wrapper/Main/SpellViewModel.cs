using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Helper;
using WowSpellidManager.DomainUWP.Models.Spells;
using WowSpellidManager.Infrastructure.CRUD;
using WowSpellidManager.WinUI2.ViewModels.Wrapper.Core;
using WowSpellidManager.WinUI2.ViewModels.Wrapper.Holder;

namespace WowSpellidManager.ViewModels.Wrapper.Main
{
    public class SpellViewModel
    {
        public IDHolderViewModel IDHolderViewModel { get; set; }

        public GuidHolder GuidHolder { get; set; }

        public DesignationHolderViewModel DesignationHolderViewModel { get; set; }

        public AdditionalInfoHolderViewModel AdditionalInfoHolderViewModel { get; set; }

        public ResourceViewModel CostViewModel { get; set; }

        public CooldownViewModel CooldownViewModel { get; set; }

        public ChargesHolderViewModel ChargesHolderViewModel { get; set; }

        public RangeViewModel RangeViewModel { get; set; }

        public ToolTipTextHolderViewModel ToolTipTextHolderViewModel { get; set; }

        public CastViewModel CastViewModel { get; set; }

        public AvailabilityHolderViewModel AvailabilityHolderViewModel { get; set; }

        public IsPassiveHolderViewModel IsPassiveHolderViewModel { get; set; }



        public IEnumerable<TimeUnit> TimeUnitValues
        {
            get
            {
                return Enum.GetValues(typeof(TimeUnit))
                    .Cast<TimeUnit>();
            }
        }

        private bool fHasCooldown;
        public bool HasCooldown
        {
            get
            {
                if (CooldownViewModel.Number > 0)
                    fHasCooldown = true; 
                else
                    fHasCooldown = false; 
                return fHasCooldown;
            }

            set
            {
                if (value == false)
                    CooldownViewModel.Number = 0;               
                else 
                    CooldownViewModel.Number = 1;
                fHasCooldown = value;
            }
        }
    }
}
