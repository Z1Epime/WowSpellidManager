using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Xaml.Controls;
using WowSpellidManager.ViewModels.Helper;
using WowSpellidManager.ViewModels.Wrapper.Main;
using WowSpellidManager.WinUI2.Views;

namespace WowSpellidManager.Views
{
    public sealed partial class SpellView : Page
    {
        private SpecializationViewModel fSpec;
        private SpellViewModel fSpell;
        private readonly NavigationView fSpellNavigationView;
        private NavigationView fMainNavigationView;
        private SpellHelper fSpellHelper;
        private EditSpellView fEditSpellView;
        private Frame fSpellFrame;

        public SpellView(SpecializationViewModel aSpec, SpellViewModel aSpell, NavigationView aMainNavigationView, NavigationView aSpellNaviationView,
            Frame aSpellFrame)
        {
            this.InitializeComponent();
            fSpellNavigationView = aSpellNaviationView;
            fSpellFrame = aSpellFrame;
            fSpec = aSpec;
            fSpell = aSpell;
            fMainNavigationView = aMainNavigationView;
            fSpellHelper = new SpellHelper();
            this.DataContext = fSpell;

            fEditSpellView = new EditSpellView(fSpell);
            EditSpellStackPanel.Children.Add(fEditSpellView);
        }

        private void CopySpellidButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            DataPackage datapackage = new DataPackage()
            {
                RequestedOperation = DataPackageOperation.Copy
            };
            datapackage.SetText(SpellidTextBlock.Text);
            Clipboard.SetContent(datapackage);
        }

        private void ToggleWebViewToggleButton_Unchecked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            webView.Navigate(new Uri("about:blank"));
            fMainNavigationView.IsPaneOpen = true;
        }

        private void ToggleWebViewToggleButton_Checked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            string link = "https://www.wowhead.com/spell=" + fSpell.IDHolderViewModel.ID;

            webView.Navigate(new Uri(link));
            fMainNavigationView.IsPaneOpen = false;
        }

        private async void DeleteButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            string spellName = fSpell.DesignationHolderViewModel.Designation;

            ContentDialog dialog = new ContentDialog();
            dialog.XamlRoot = this.Content.XamlRoot;
            dialog.Title = "Confirmation";
            dialog.Content = $"Are you sure you want to delete \"{spellName}\"?";
            dialog.CloseButtonText = "Cancel";
            dialog.DefaultButton = ContentDialogButton.Primary;
            dialog.PrimaryButtonText = "Delete";

            var result = await dialog.ShowAsync();

            if (result == ContentDialogResult.Primary)
            {
                fSpellHelper.RemoveSpell(fSpec, fSpell);
                fSpellNavigationView.SelectedItem = null;
                fSpellFrame.Content = null;
                fSpellNavigationView.MenuItemsSource = fSpec.Spells;
            }
        }
    }
}
