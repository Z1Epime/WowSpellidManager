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
using WowSpellidManager.Infrastructure.CRUD;
using WowSpellidManager.ViewModels.Helper;
using WowSpellidManager.ViewModels.Wrapper.Main;
using WowSpellidManager.WinUI2.Views;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WowSpellidManager.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SpecializationView : Page
    {
        private SpecializationViewModel fSpec;
        private WowClassViewModel fWowClass;
        private SpellHelper fSpellHelper;
        public SpecializationView(WowClassViewModel aWowClass, SpecializationViewModel aSpecialization)
        {
            this.InitializeComponent();
            fSpellHelper = new SpellHelper();
            fSpec = aSpecialization;
            fWowClass = aWowClass;
            //SpellsListView.MenuItemsSource = GenerateSpellNavigationOptionsCollection(((SpecializationViewModel)aSpecialization).Spells);
            SpellNavigationView.MenuItemsSource = ((SpecializationViewModel)aSpecialization).Spells;
        }

        private void SpellsListView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            SpellFrame.Content = new SpellView(fSpec, (SpellViewModel)SpellNavigationView.SelectedItem, SpellNavigationView);
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            ((SpecializationViewModel)fSpec).Spells.Remove((SpellViewModel)SpellNavigationView.SelectedItem);
        }

        private async void AddSpellButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog dialog = new ContentDialog();
            dialog.XamlRoot = this.Content.XamlRoot;
            dialog.Title = "Add a spell:";
            dialog.CloseButtonText = "Cancel";
            dialog.DefaultButton = ContentDialogButton.Primary;
            dialog.PrimaryButtonText = "Add";
            dialog.Content = new AddSpellView();

            var result = await dialog.ShowAsync();

            var view = (AddSpellView)dialog.Content;
            if (result == ContentDialogResult.Primary)
            {
                fSpellHelper.AddSpell(view.SpellName, view.ID, fWowClass, fSpec);
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //var esa0fioj = WowClassHelper.ViewModels;


            //foreach (var @class in new DataOperationProvider().WowClassOperator.GetWowClasses())
            //{
            //    foreach (var spec in @class.Specializations)
            //    {
            //        foreach (var spell in spec.Spells)
            //        {
            //            if (spell.ID.ID == "123")
            //            {


            //                foreach (var @class2 in WowClassHelper.ViewModels)
            //                {
            //                    foreach (var spec2 in @class2.Specializations)
            //                    {
            //                        foreach (var spell2 in spec2.Spells)
            //                        {
            //                            if (spell2.ID.ID == "123")
            //                            {

            //                                if (ReferenceEquals(spell.ID, spell2.ID))
            //                                {
            //                                    Console.WriteLine("They are !");
            //                                }

            //                                if (ReferenceEquals(spell.Designation, spell2.Designation))
            //                                {
            //                                    Console.WriteLine("They are !");
            //                                }


            //                            }
            //                        }
            //                    }
            //                }


            //            }
            //        }
            //    }
            //}
            new DataOperationProvider().WowClassOperator.Save();
        }
    }
}
