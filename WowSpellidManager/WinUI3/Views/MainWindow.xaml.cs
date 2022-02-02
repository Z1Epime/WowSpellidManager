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
            ObservableCollection<NavigationOption> navigationoptions = new ObservableCollection<NavigationOption>();
            navigationoptions.Add(new NavigationOption("Home", Symbol.Home));
            navigationoptions.Add(new NavigationOption("Explore classes", Symbol.Library));
            navigationoptions.Add(new NavigationOption("Settings", Symbol.Setting));
            navigationoptions.Add(new NavigationOption("Quit", Symbol.Cancel));

            mainNavigationView.MenuItemsSource = navigationoptions;
        }

        private void mainNavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            string item = mainNavigationView.SelectedItem as string;

            if(item != null)
            {
                if (item.Equals("Settings", StringComparison.OrdinalIgnoreCase))
                {
                    mainFrame.Content = new SettingsView();
                } else if (item.Equals("Main", StringComparison.OrdinalIgnoreCase))
                {
                    mainFrame.Content = new MainPage();
                } else if (item.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("nix");
                }
            }
        }
    }
}
