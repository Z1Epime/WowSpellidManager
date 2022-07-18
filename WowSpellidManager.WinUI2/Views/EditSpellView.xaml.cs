using Windows.UI.Xaml.Controls;
using WowSpellidManager.ViewModels.Helper;
using WowSpellidManager.ViewModels.Wrapper.Main;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WowSpellidManager.WinUI2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EditSpellView : Page
    {
        private SpellViewModel fSpell;
        private SpellHelper fSpellHelper;

        public EditSpellView(object aSpell)
        {
            this.InitializeComponent();
            fSpell = (SpellViewModel)aSpell;
            fSpellHelper = new SpellHelper();
        }
    }
}
