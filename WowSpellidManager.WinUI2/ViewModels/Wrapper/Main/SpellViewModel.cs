using WowSpellidManager.DomainUWP.Models.Helper;
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
    }
}
