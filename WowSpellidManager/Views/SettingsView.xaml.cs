using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
        private HelperSettingsViewModel fHelperSettingsViewModel = new HelperSettingsViewModel();
        private Error fSavingsPathError;
        public SettingsView()
        {
            this.InitializeComponent();
            fileLocation.DataContext = fHelperSettingsViewModel.GetSettings();
            ToggleSwitchDarkTheme.DataContext = fHelperSettingsViewModel.GetSettings();
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
    }
}
