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
            // TODO: this.Visibility = Visibility.Visible;
            fSpec = aSpec;
            //((SpellViewModel)aSpell).Cooldown = new Domain.Models.Spells.Cooldown(2, DomainUWP.Models.Spells.TimeUnit.Minute);
            //((SpellViewModel)aSpell).Cast = new Domain.Models.Spells.Cast(2, DomainUWP.Models.Spells.CastType.Cast, DomainUWP.Models.Spells.TimeUnit.Second, true);
            //((SpellViewModel)aSpell).Charges = 2;
            //((SpellViewModel)aSpell).Cost = new Domain.Models.Spells.Resource(DomainUWP.Models.Spells.ResourceType.Mana, 50);
            //((SpellViewModel)aSpell).IsPassive = false;
            //((SpellViewModel)aSpell).Range = new Domain.Models.Spells.Range(40, DomainUWP.Models.Spells.RangeUnit.Yard);
            //((SpellViewModel)aSpell).AdditionalInfo = "sehfiuoseifuhseiofuhseifouhseiopfuesifopusehfiopueshfiu";
            //((SpellViewModel)aSpell).Availability = DomainUWP.Models.Spells.Availability.Baseline;
            //((SpellViewModel)aSpell).ToolTipText = "afsejofpjseofpisejfopisepofijseopiföjseofpijseofsjefsiejfespfijseofipjafsejofpjseofpisejfopisepofijseopiföjseofpijseofsjefsiejfespfijseofipjafsejofpjseofpisejfopisepo";

            fSpell = aSpell;
            this.aSpellNavigationView = aSpellNavigationView;
            fSpellHelper = new SpellHelper();
            this.DataContext = fSpell;

            fEditSpellView = new EditSpellView(fSpell);
            EditSpellStackPanel.Children.Add(fEditSpellView);
        }

        //private void AcceptButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        //{
        //    fEditSpellView.SaveSpell();
        //}

        //private void CancelEditButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        //{
        //    fEditSpellView.CancelEdit();
        //}
    }
}
