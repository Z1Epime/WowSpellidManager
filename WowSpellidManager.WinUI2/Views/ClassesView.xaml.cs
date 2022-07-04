using Windows.UI.Xaml.Controls;
using WowSpellidManager.ViewModels.Helper;
using WowSpellidManager.ViewModels.Wrapper.Main;

namespace WowSpellidManager.Views
{
    public sealed partial class ClassesView : Page
    {
        private WowClassHelper fHelperWowClassViewModel;

        public ClassesView()
        {
            this.InitializeComponent();
            fHelperWowClassViewModel = new WowClassHelper();
            ClassNavigationView.MenuItemsSource = fHelperWowClassViewModel.GetWowClasses();
        }

        private void ClassNavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            classesFrame.Content = new ClassView((WowClassViewModel)ClassNavigationView.SelectedItem);
        }
    }
}
