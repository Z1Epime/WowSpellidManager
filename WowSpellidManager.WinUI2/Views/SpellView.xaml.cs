using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
        private SpellHelper fSpellHelper;
        private EditSpellView fEditSpellView;

        public SpellView(SpecializationViewModel aSpec, SpellViewModel aSpell, object aSpellNavigationView)
        {
            this.InitializeComponent();
            fSpec = aSpec;
            fSpell = aSpell;
            this.aSpellNavigationView = aSpellNavigationView;
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
    }
}
