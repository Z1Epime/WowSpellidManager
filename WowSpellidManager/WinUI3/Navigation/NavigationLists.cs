using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.WinUI3.Views;

namespace WowSpellidManager.WinUI3.Navigation
{
    public static class NavigationLists
    {
        #region NavigationOptions

        public static NavigationOption Home { get; set; }
        public static NavigationOption Classes { get; set; }
        public static NavigationOption Settings { get; set; }
        public static NavigationOption Quit{ get; set; }

        #endregion

        #region NavigationLists
        public static ObservableCollection<NavigationOption> NavigationOptionsMain { get; set; }
        #endregion


        public static void LoadNavigationLists()
        {
            NavigationOptionsMain.Clear();

            Home = new NavigationOption("Home", Symbol.Home);
            Classes = new NavigationOption("Classes", Symbol.Library);
            Settings= new NavigationOption("Settings", Symbol.Setting);
            Quit = new NavigationOption("Quit", Symbol.Cancel);

            NavigationOptionsMain.Add(Home);
            NavigationOptionsMain.Add(Classes);
            NavigationOptionsMain.Add(Settings);
            NavigationOptionsMain.Add(Quit);
        }
    }
}
