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
using WowSpellidManager.WinUI3.ViewModels.Helper;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WowSpellidManager.WinUI3.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsView : Page
    {
        private HelperSettingsViewModel fHelperSettingsViewModel = new HelperSettingsViewModel();
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
    }
}
