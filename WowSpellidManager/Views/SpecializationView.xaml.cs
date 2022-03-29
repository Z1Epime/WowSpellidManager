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
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WowSpellidManager.ViewModels.Helper;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WowSpellidManager.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SpecializationView : Page
    {
        private object fSpecialization;
        private HelperSpellViewModel fHelperSpellViewModel = new HelperSpellViewModel();
        public SpecializationView(object aSpecialization, object aWowClass)
        {
            InitializeComponent();
            fSpecialization = aSpecialization;
            spellListView.DataContext = aSpecialization;
            spellDetailsHeaderStackPanel.DataContext = null;

            spellDetailsStackPanel.Visibility = Visibility.Collapsed;
            classTitleTextBlock.Visibility = Visibility.Collapsed;
            spellDetailsHeaderStackPanel.Visibility = Visibility.Collapsed;

            minorClassHeader.DataContext = aWowClass;
            minorSpecializationHeader.DataContext = aSpecialization;
        }

        private void spellListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            classTitleTextBlock.DataContext = spellListView.SelectedItem;
            spellDetailsStackPanel.DataContext = spellListView.SelectedItem;
            spellDetailsStackPanel.Visibility = Visibility.Visible;
            classTitleTextBlock.Visibility = Visibility.Visible;
            spellDetailsHeaderStackPanel.Visibility = Visibility.Visible;
        }

        private void CopySpellIdButton_Click(object sender, RoutedEventArgs e)
        {
            DataPackage datapackage = new DataPackage()
            {
                RequestedOperation = DataPackageOperation.Copy
            };
            datapackage.SetText(SpellIDTextBinded.Text);
            Clipboard.SetContent(datapackage);
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            fHelperSpellViewModel.RemoveSpell(fSpecialization, spellListView.SelectedItem);
            spellListView.SelectedItem = fHelperSpellViewModel.GetLastSpellOfSpecialization(fSpecialization);

            if (!fHelperSpellViewModel.HasSpells(fSpecialization)) 
            {
                spellDetailsStackPanel.Visibility = Visibility.Collapsed;
                spellDetailsHeaderStackPanel.Visibility = Visibility.Collapsed;
            } 
        }
    }
}
