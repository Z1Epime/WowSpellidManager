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
    public sealed partial class ClassesView : Page
    {
        private HelperWowClassViewModel fHelperWowClassViewModel;
        public ClassesView()
        {
            this.InitializeComponent();
            fHelperWowClassViewModel = new HelperWowClassViewModel();
            classListView.DataContext = fHelperWowClassViewModel.GetWowClasses();
            AddSpellButton.Visibility = Visibility.Collapsed;
            specializationView.Visibility = Visibility.Collapsed;
        }

        private void classListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // addSpellStackPanel.DataContext = itemListView.SelectedItem;
            specializationView.DataContext = classListView.SelectedItem;
            specializationView.Visibility = Visibility.Visible;
            AddSpellButton.Visibility = Visibility.Collapsed;
        }





        /*
        private void AddClass_Click(object sender, RoutedEventArgs e)
        {
            fHelperWowClassViewModel.AddWowClass(designationBox.Text, descriptionBox.Text);
        }

        
        private void itemListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            addClassStackPanel.DataContext = classListView.SelectedItem;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            fHelperWowClassViewModel.SaveWowClasses();
        }
        */

        private void specializationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            specializationFrame.Content = new SpecializationView(specializationView.SelectedItem, classListView.SelectedItem);
            AddSpellButton.Visibility = Visibility.Visible;
        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddSpellButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
