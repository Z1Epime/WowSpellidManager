using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
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
        private NavigationView fMainNavigationView;
        public SpecializationView(WowClassViewModel aWowClass, SpecializationViewModel aSpecialization, NavigationView aMainNavigationView)
        {
            this.InitializeComponent();
            fMainNavigationView = aMainNavigationView;
            fSpellHelper = new SpellHelper();
            fSpec = aSpecialization;
            fWowClass = aWowClass;
            SpellNavigationView.MenuItemsSource = aSpecialization.Spells;
        }

        private void SpellsListView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            SpellFrame.Content = new SpellView(fSpec, (SpellViewModel)SpellNavigationView.SelectedItem, fMainNavigationView);
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            fSpec.Spells.Remove((SpellViewModel)SpellNavigationView.SelectedItem);
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

        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var queryString = SpellSearchBox.Text.Replace(" ", string.Empty);

            IEnumerable<SpellViewModel> results = fSpec.Spells.Where(spellVM =>
               spellVM.DesignationHolderViewModel.Designation.Contains(queryString, StringComparison.OrdinalIgnoreCase));

            SpellNavigationView.MenuItemsSource = results;
        }
    }
}
