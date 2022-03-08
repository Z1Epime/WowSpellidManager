using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using WowSpellidManager.WinUI3.Views;

namespace WowSpellidManager.WinUI3.Navigation
{
    public static class NavigationLists
    {
        #region Fields
        private static ObservableCollection<NavigationOption> fNavigationOptionsMain;

        private static NavigationOption fHome;
        private static NavigationOption fClasses;
        private static NavigationOption fSettings;
        private static NavigationOption fQuit;

        #endregion

        #region Properties
        public static ObservableCollection<NavigationOption> NavigationOptionsMain
        {
            get
            {
                if (fNavigationOptionsMain == null)
                {
                    fNavigationOptionsMain = new ObservableCollection<NavigationOption>();
                }
                return fNavigationOptionsMain;
            }
            set
            {
                if (value != null)
                {
                    fNavigationOptionsMain = value;
                }
            }
        }
        #endregion


        public static void LoadNavigationLists()
        {
            NavigationOptionsMain.Clear();

            //if (Windows.UI.Core.CoreWindow.GetForCurrentThread() != null)

            // TODO: experimental ?
            ResourceLoader resourceLoader = ResourceLoader.GetForViewIndependentUse();

            fHome = new NavigationOption("Home", resourceLoader.GetString("Home"), Symbol.Home);
            fClasses = new NavigationOption("Classes", resourceLoader.GetString("Classes"), Symbol.Library);
            fSettings = new NavigationOption("Settings", resourceLoader.GetString("Settings"), Symbol.Setting);
            fQuit = new NavigationOption("Quit", resourceLoader.GetString("Quit"), Symbol.Cancel);

            NavigationOptionsMain.Add(fHome);
            NavigationOptionsMain.Add(fClasses);
            NavigationOptionsMain.Add(fSettings);
            NavigationOptionsMain.Add(fQuit);
        }
    }
}
