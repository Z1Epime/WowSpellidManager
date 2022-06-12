using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WowSpellidManager.ViewModels.Wrapper;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WowSpellidManager.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SpecializationView : Page
    {
        private object fSpec;
        public SpecializationView(object aSpecialization)
        {
            this.InitializeComponent();
            fSpec = aSpecialization;
            //SpellsListView.MenuItemsSource = GenerateSpellNavigationOptionsCollection(((SpecializationViewModel)aSpecialization).Spells);
            SpellNavigationView.MenuItemsSource = ((SpecializationViewModel)aSpecialization).Spells;
        }

        private void SpellsListView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            SpellFrame.Content = new SpellView(fSpec, SpellNavigationView.SelectedItem, SpellNavigationView);
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            ((SpecializationViewModel)fSpec).Spells.Remove((SpellViewModel)SpellNavigationView.SelectedItem);
        }

        //private ObservableCollection<SpellNavigationOption> GenerateSpellNavigationOptionsCollection(ObservableCollection<SpellViewModel> aSpellViewModels)
        //{
        //    var navOptions = new ObservableCollection<SpellNavigationOption>();

        //    foreach(var spellViewModel in aSpellViewModels)
        //    {
        //        navOptions.Add(new SpellNavigationOption()
        //        {
        //            DisplayName = spellViewModel.Designation,
        //            RemoveButton
        //        }) ;
        //    }
        //}

        //private class SpellNavigationOption
        //{
        //    private SpellViewModel fSpell;

        //    public string DisplayName { get; set; }
        //    public Button RemoveButton { get; set; }
        //}

    }
}
