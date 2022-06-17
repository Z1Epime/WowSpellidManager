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
            // TODO: this.Visibility = Visibility.Visible;
            fSpec = aSpec;
            ((SpellViewModel)aSpell).Cooldown = new Domain.Models.Spells.Cooldown(2, "min");
            ((SpellViewModel)aSpell).Charges = 2;
            ((SpellViewModel)aSpell).Cast = new Domain.Models.Spells.Cast() { Time = 2, IsChanneling = false, IsOffGlobal = true };
            ((SpellViewModel)aSpell).IsTalent = false;
            ((SpellViewModel)aSpell).IsPvPTalent = true;
            ((SpellViewModel)aSpell).Cast = new Domain.Models.Spells.Cast(null, false, false);
            ((SpellViewModel)aSpell).Charges = null;
            ((SpellViewModel)aSpell).Cost = new Domain.Models.Spells.Resource("Mana", 50);
            ((SpellViewModel)aSpell).IsPassive = false;
            ((SpellViewModel)aSpell).Range = new Domain.Models.Spells.Range(40, "Yard");
            ((SpellViewModel)aSpell).AdditionalInfo = "sehfiuoseifuhseiofuhseifouhseiopfuesifopusehfiopueshfiu";
            ((SpellViewModel)aSpell).ToolTipText = "afsejofpjseofpisejfopisepofijseopiföjseofpijseofsjefsiejfespfijseofipjafsejofpjseofpisejfopisepofijseopiföjseofpijseofsjefsiejfespfijseofipjafsejofpjseofpisejfopisepo";

            fSpell = aSpell;
            this.aSpellNavigationView = aSpellNavigationView;
            fSpellHelper = new SpellHelper();
            this.DataContext = fSpell;
        }

    }
}
