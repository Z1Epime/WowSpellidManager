using Windows.UI.Xaml.Controls;
using WowSpellidManager.ViewModels.Helper;
using WowSpellidManager.ViewModels.Wrapper.Main;

namespace WowSpellidManager.Views
{
    public sealed partial class ClassesView : Page
    {
        private WowClassHelper fHelperWowClassViewModel;
        private NavigationView fMainNavigationView;

        public ClassesView(NavigationView aMainNavigationView)
        {
            this.InitializeComponent();
            fMainNavigationView = aMainNavigationView;
            fHelperWowClassViewModel = new WowClassHelper();
            ClassNavigationView.MenuItemsSource = fHelperWowClassViewModel.GetWowClasses();
        }

        private void ClassNavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            classesFrame.Content = new ClassView((WowClassViewModel)ClassNavigationView.SelectedItem, fMainNavigationView);
        }
    }
}
