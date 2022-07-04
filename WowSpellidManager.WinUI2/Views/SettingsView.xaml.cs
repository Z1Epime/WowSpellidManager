using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using WowSpellidManager.ViewModels.Helper;
using WowSpellidManager.ViewModels.Validators.Errors;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WowSpellidManager.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsView : Page
    {
        private SettingsHelper fHelperSettingsViewModel = new SettingsHelper();
        private Error fSavingsPathError;
        private object View;
        public SettingsView(object aView)
        {
            this.InitializeComponent();
            fileLocation.DataContext = fHelperSettingsViewModel.GetSettings();
            ToggleSwitchDarkTheme.DataContext = fHelperSettingsViewModel.GetSettings();

            View = aView;
        }

        private void SaveSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            fHelperSettingsViewModel.SaveSettings();
        }

        private void fileLocation_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            Error error = fHelperSettingsViewModel.CheckDirectoryExists(fileLocation.Text);

            SavingsPathErrorTextBlock.Text = "";

            if (error != null)
                SavingsPathErrorTextBlock.Text = error.Message;

            fSavingsPathError = error;

            ErrorChanged();
        }

        private void ErrorChanged()
        {
            SaveSettingsButton.IsEnabled = false;

            if (fSavingsPathError == null)
                SaveSettingsButton.IsEnabled = true;
        }

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            (View as NavigationView).PaneDisplayMode = NavigationViewPaneDisplayMode.Top;
        }
    }
}
