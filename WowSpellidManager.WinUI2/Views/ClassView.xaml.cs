using Windows.UI.Xaml.Controls;
using WowSpellidManager.ViewModels.Wrapper.Main;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WowSpellidManager.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ClassView : Page
    {
        private WowClassViewModel fWowClass;
        public ClassView(WowClassViewModel aWowClass)
        {
            this.InitializeComponent();
            fWowClass = aWowClass;
            SpecializationNavigationView.MenuItemsSource = aWowClass.Specializations;
        }

        private async void SpecializationNavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            specializationsFrame.Content = new SpecializationView(fWowClass, (SpecializationViewModel)SpecializationNavigationView.SelectedItem);
            //specializationsFrame.Content = new EditSpellView();
        }
    }
}
