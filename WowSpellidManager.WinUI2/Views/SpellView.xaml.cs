using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml.Controls;
using WowSpellidManager.ViewModels.Helper;
using WowSpellidManager.ViewModels.Wrapper;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WowSpellidManager.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SpellView : Page
    {
        private object fSpec;
        private object fSpell;
        private readonly object aSpellNavigationView;
        private SpellHelper fSpellHelper;

        public SpellView(object aSpec, object aSpell, object aSpellNavigationView)
        {
            this.InitializeComponent();
            this.DataContext = aSpell;
            // TODO: this.Visibility = Visibility.Visible;
            fSpec = aSpec;
            fSpell = aSpell;
            this.aSpellNavigationView = aSpellNavigationView;
            fSpellHelper = new SpellHelper();
        }
    }
}
