using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WowSpellidManager.WinUI3.ViewModels;
using WowSpellidManager.WinUI3.ViewModels.Helper;
using WowSpellidManager.WinUI3.ViewModels.Wrapper;
using WowSpellidManager.Infrastructure;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.WinUI3.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WowSpellidManager.WinUI3.Views
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            NavigationLists.LoadNavigationLists();
            NavigationLists.LoadFooterNavigationLists();

            mainNavigationView.FooterMenuItemsSource = NavigationLists.FooterNavigationOptionsMain;
            mainNavigationView.MenuItemsSource = NavigationLists.NavigationOptionsMain;
            mainNavigationView.SelectedItem = NavigationLists.NavigationOptionsMain.FirstOrDefault();
        }

        private void mainNavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationOption option = mainNavigationView.SelectedItem as NavigationOption;

            if(option != null)
            {
                if (option.Name.Equals("Home", StringComparison.OrdinalIgnoreCase))
                {
                    mainFrame.Content = new HomeView();
                } else if (option.Name.Equals("Classes", StringComparison.OrdinalIgnoreCase))
                {
                    mainFrame.Content = new ClassesView();
                }
                else if (option.Name.Equals("Settings", StringComparison.OrdinalIgnoreCase))
                {
                    mainFrame.Content = new SettingsView();
                }
                else if (option.Name.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                {
                    Application.Current.Exit();
                }
            }
        }
    }
}
