using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WowSpellidManager.Infrastructure.CRUD;
using WowSpellidManager.ViewModels.Helper;
using WowSpellidManager.ViewModels.Wrapper;
using WowSpellidManager.Views;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WowSpellidManager.WinUI2.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EditSpellView : Page
    {
        private SpellViewModel fSpell;

        private SpellViewModel fTempSpell;
        private SpellHelper fSpellHelper;

        public EditSpellView(object aSpell)
        {
            this.InitializeComponent();
            fSpell = (SpellViewModel) aSpell;
            fSpellHelper = new SpellHelper();

            //fSpell.SelectedMyEnumType = fSpell.Cooldown.Unit;
            //Copy();

            //InitControls();
        }

        private void AdditionalInfoTextBox_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            fSpell.Cooldown.Number++;
        }

        //private void InitControls()
        //{
        //    #region NameAndSpellID

        //    if (fTempSpell != null)
        //    {
        //        if (fTempSpell.Designation != null)
        //            spellNameTextBox.Text = fTempSpell.Designation;
        //        if (fTempSpell.ID != null)
        //            spellidTextBox.Text = fTempSpell.ID;
        //    }

        //    #endregion

        //    #region Cooldown

        //    if (fTempSpell.Cooldown == null)
        //        CooldownCheckBox.IsChecked = false;
        //    else
        //    {
        //        CooldownCheckBox.IsChecked = true;

        //        TimeTextBox.Text = fTempSpell.Cooldown.Number.ToString();

        //        //if (fTempSpell.Cooldown.Unit.ToString().Equals("Second"))
        //        //    UnitComboBoxCooldown.SelectedItem = ComboBoxItemSecond;
        //        //if (fTempSpell.Cooldown.Unit.ToString().Equals("Minute"))
        //        //    UnitComboBoxCooldown.SelectedItem = ComboBoxItemMinute;
        //        //if (fTempSpell.Cooldown.Unit.ToString().Equals("Hour"))
        //        //    UnitComboBoxCooldown.SelectedItem = ComboBoxItemHour;

        //        if (fTempSpell.Charges == 0)
        //            ChargesCheckBox.IsChecked = false;
        //        else
        //        {
        //            ChargesCheckBox.IsChecked = true;
        //            ChargesValueTextBlock.Text = fTempSpell.Charges.ToString();

        //            ChargesValueTextBlock.Text = fTempSpell.Charges.ToString();
        //        }         
        //    }

        //    #endregion

        //    #region Cast

        //    if(fTempSpell.Cast != null)
        //    {
        //        InstantCastRadioButton.IsChecked = false;
        //        ChannelingRadioButton.IsChecked = false;
        //        NormalCastRadioButton.IsChecked = false;

        //        if (fTempSpell.Cast.CastType.ToString().Equals("Instant"))
        //            InstantCastRadioButton.IsChecked = true;
        //        else if(fTempSpell.Cast.CastType.ToString().Equals("Channeling"))            
        //            ChannelingRadioButton.IsChecked = true;
        //        else if(fTempSpell.Cast.CastType.ToString().Equals("Cast"))
        //            NormalCastRadioButton.IsChecked = true;

        //        if (fTempSpell.Cast.Time != null)
        //        {
        //            BaseCastTimeTextBox.Text = fTempSpell.Cast.Time.ToString();
        //            DurationTextBox.Text = fTempSpell.Cast.Time.ToString();
        //        }


        //        if (fTempSpell.Cast.Unit.ToString().Equals("Second"))
        //            UnitComboBoxDuration.SelectedItem = UnitComboBoxItemSecond;
        //        else if (fTempSpell.Cast.Unit.ToString().Equals("Minute"))
        //            UnitComboBoxDuration.SelectedItem = UnitComboBoxItemMinute;
        //        else if (fTempSpell.Cast.Unit.ToString().Equals("Hour"))
        //            UnitComboBoxDuration.SelectedItem = UnitComboBoxItemHour;

        //        if (fTempSpell.Cast.IsOffGlobal)
        //            OffGlobalCheckBox.IsChecked = true;
        //        else
        //            OffGlobalCheckBox.IsChecked = false;

        //        if(fTempSpell.Range == null)
        //            RangeCheckBox.IsChecked = false;
        //        else
        //        {
        //            RangeCheckBox.IsChecked = true;
        //            RangeTextBox.Text = fTempSpell.Range.Number.ToString();

        //            if (fTempSpell.Range.Unit.ToString().Equals("Yard"))
        //                UnitComboBoxRange.SelectedItem = RangeUnitYard;
        //        }             
        //    }

        //    #endregion

        //    #region Availability

        //    if(fTempSpell != null)
        //    {
        //        Talent.IsChecked = false;
        //        PVPTalent.IsChecked = false;
        //        Baseline.IsChecked = false;
        //        Other.IsChecked = false;

        //        if (fTempSpell.Availability.ToString().Equals("Talent"))
        //            Talent.IsChecked = true;
        //        else if (fTempSpell.Availability.ToString().Equals("HonorTalent"))
        //            PVPTalent.IsChecked = true;
        //        else if (fTempSpell.Availability.ToString().Equals("Baseline"))
        //            Baseline.IsChecked = true;
        //        else if (fTempSpell.Availability.ToString().Equals("Other"))
        //            Other.IsChecked = true;
        //    }

        //    #endregion

        //    #region AdditionalInfo

        //    if (fTempSpell != null)
        //    {
        //        if (fTempSpell.AdditionalInfo != null)
        //        {
        //            AdditionalInfoTextBox.Document.SetText(TextSetOptions.None, fTempSpell.AdditionalInfo);
        //        }
        //    }

        //    #endregion
        //}

        //private void Copy()
        //{
        //    var newSpellViewModel = new SpellViewModel()
        //    {
        //        AdditionalInfo = String.Copy(fSpell.AdditionalInfo),
        //        //Cooldown = new Domain.Models.Spells.Cooldown(fSpell.Cooldown.Number, fSpell.Cooldown.Unit),
        //        Availability = fSpell.Availability,
        //        Cast = new Domain.Models.Spells.Cast(fSpell.Cast.Time, fSpell.Cast.CastType, fSpell.Cast.Unit, fSpell.Cast.IsOffGlobal),
        //        Charges = fSpell.Charges,
        //        Cost = new Domain.Models.Spells.Resource(fSpell.Cost.Designation, fSpell.Cost.Amount),
        //        Designation = String.Copy(fSpell.Designation),
        //        Guid = new Guid(fSpell.Guid.ToString()),
        //        ID = String.Copy(fSpell.ID),
        //        IsPassive = fSpell.IsPassive,
        //        Range = new Domain.Models.Spells.Range(fSpell.Range.Number, fSpell.Range.Unit),
        //        ToolTipText = String.Copy(fSpell.ToolTipText),
        //    };

        //    fTempSpell = newSpellViewModel;
        //}

        //    public void SaveSpell()
        //    {
        //        ApplyChangesFromControls();
        //        fSpellHelper.SwitchSpellViewModel(fSpell, fTempSpell);
        //        new DataOperationProvider().WowClassOperator.Save();

        //    }

        //    public void CancelEdit()
        //    {

        //    }

        //    private void ApplyChangesFromControls()
        //    {
        //        AdditionalInfoTextBox.Document.GetText(TextGetOptions.None, out string temp);
        //        fTempSpell.AdditionalInfo = temp;

        //        fTempSpell.Charges = Convert.ToInt32(ChargesValueTextBlock.Text);

        //        fTempSpell.ID = spellidTextBox.Text;
        //        fTempSpell.Designation = spellNameTextBox.Text;

        //        fTempSpell.Cooldown.Number = Convert.ToInt32(TimeTextBox.Text);

        //        //if (UnitComboBoxCooldown.SelectedItem == ComboBoxItemSecond)
        //        //    fTempSpell.Cooldown.Unit = DomainUWP.Models.Spells.TimeUnit.Second;
        //        //else if (UnitComboBoxCooldown.SelectedItem == UnitComboBoxItemMinute)
        //        //    fTempSpell.Cooldown.Unit = DomainUWP.Models.Spells.TimeUnit.Minute;
        //        //else if (UnitComboBoxCooldown.SelectedItem == UnitComboBoxItemHour)
        //        //    fTempSpell.Cooldown.Unit = DomainUWP.Models.Spells.TimeUnit.Hour;


        //        if ((bool)NormalCastRadioButton.IsChecked)
        //        {
        //            fTempSpell.Cast.CastType = DomainUWP.Models.Spells.CastType.Cast;
        //            fTempSpell.Cast.Time = Convert.ToInt32(BaseCastTimeTextBox.Text);
        //        }
        //        else if ((bool) ChannelingRadioButton.IsChecked)
        //        {
        //            fTempSpell.Cast.CastType = DomainUWP.Models.Spells.CastType.Channeling;
        //            fTempSpell.Cast.Time = Convert.ToInt32(DurationTextBox.Text);
        //        }
        //        else if ((bool)InstantCastRadioButton.IsChecked)
        //            fTempSpell.Cast.CastType = DomainUWP.Models.Spells.CastType.Instant;

        //        if ((bool)OffGlobalCheckBox.IsChecked)
        //            fTempSpell.Cast.IsOffGlobal = true;
        //        else
        //            fTempSpell.Cast.IsOffGlobal = false;


        //        if ((bool)RangeCheckBox.IsChecked)
        //        {
        //            fTempSpell.Range.Number = Convert.ToInt32(RangeTextBox.Text);

        //            if (UnitComboBoxRange.SelectedItem == RangeUnitYard)
        //            {
        //                fTempSpell.Range.Unit = DomainUWP.Models.Spells.RangeUnit.Yard;
        //            }
        //        }


        //        if ((bool)Talent.IsChecked)
        //            fTempSpell.Availability = DomainUWP.Models.Spells.Availability.Talent;
        //        else if ((bool)Baseline.IsChecked)
        //            fTempSpell.Availability = DomainUWP.Models.Spells.Availability.Baseline;
        //        else if ((bool)PVPTalent.IsChecked)
        //            fTempSpell.Availability = DomainUWP.Models.Spells.Availability.HonorTalent;
        //        else if ((bool)Other.IsChecked)
        //            fTempSpell.Availability = DomainUWP.Models.Spells.Availability.Other;

        //    }
    }
}
