using System.Collections.ObjectModel;
using WowSpellidManager.DomainUWP.Models.Helper;

namespace WowSpellidManager.ViewModels.Wrapper.Main
{
    public class SpecializationViewModel
    {
        public ObservableCollection<SpellViewModel> Spells { get; set; }

        public GuidHolder GuidHolder { get; set; }

        public DesignationHolder DesignationHolder { get; set; }

        public string Image { get; set; }
    }
}
