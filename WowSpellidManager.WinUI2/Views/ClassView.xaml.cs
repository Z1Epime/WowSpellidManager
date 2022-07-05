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
        private NavigationView fMainNavigationView;
        public ClassView(WowClassViewModel aWowClass, NavigationView aMainNavigationView)
        {
            this.InitializeComponent();
            fMainNavigationView = aMainNavigationView;
            fWowClass = aWowClass;
            SpecializationNavigationView.MenuItemsSource = aWowClass.Specializations;
        }

        private async void SpecializationNavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            specializationsFrame.Content = new SpecializationView(fWowClass, (SpecializationViewModel)SpecializationNavigationView.SelectedItem, fMainNavigationView);
        }
    }
}
