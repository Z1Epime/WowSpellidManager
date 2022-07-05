using System;
using Windows.ApplicationModel.DataTransfer;
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
    public sealed partial class SpellView : Page
    {
        private SpecializationViewModel fSpec;
        private SpellViewModel fSpell;
        private readonly object aSpellNavigationView;
        private NavigationView fMainNavigationView;
        private SpellHelper fSpellHelper;
        private EditSpellView fEditSpellView;

        public SpellView(SpecializationViewModel aSpec, SpellViewModel aSpell, NavigationView aMainNavigationView)
        {
            this.InitializeComponent();
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
    }
}
