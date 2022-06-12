using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WowSpellidManager.Navigation;
using WowSpellidManager.Views;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WowSpellidManager.WinUI2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            NavigationLists.LoadNavigationLists();
            NavigationLists.LoadFooterNavigationLists();

            // mainNavigationView.FooterMenuItemsSource = NavigationLists.FooterNavigationOptionsMain;
            mainNavigationView.MenuItemsSource = NavigationLists.NavigationOptionsMain;
            mainNavigationView.SelectedItem = NavigationLists.NavigationOptionsMain.FirstOrDefault();
        }

        private void mainNavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationOption option = mainNavigationView.SelectedItem as NavigationOption;

            if (option != null)
            {
                if (option.Name.Equals("Home", StringComparison.OrdinalIgnoreCase))
                {
                    mainFrame.Content = new HomeView();
                }
                else if (option.Name.Equals("Classes", StringComparison.OrdinalIgnoreCase))
                {
                    mainFrame.Content = new ClassesView();
                }
                else if (option.Name.Equals("Settings", StringComparison.OrdinalIgnoreCase))
                {
                    mainFrame.Content = new SettingsView(mainNavigationView);
                }
                else if (option.Name.Equals("About", StringComparison.OrdinalIgnoreCase))
                {
                    mainFrame.Content = new AboutView();
                }
                else if (option.Name.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                {
                    Application.Current.Exit();
                }
            }
        }
    }
}
