using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.WinUI3.ViewModels.Validators.Checkers;
using WowSpellidManager.WinUI3.ViewModels.Validators.Errors;
using WowSpellidManager.WinUI3.ViewModels.Validators.Rules;

namespace WowSpellidManager.WinUI3.ViewModels.Validators
{
    public class AddSpellValidatorViewModel : ViewModel
    {
        private SpellChecker fSpellChecker;
        public AddSpellValidatorViewModel()
        {
            fSpellChecker = new SpellChecker();
        }

        public void Validate(string aName, string aID, string aDescription)
        {
            //Error error = fSpellChecker.CheckSpell(aName, aID, aDescription);
            //if (error != null)
            //{
                
                
            //}
        }

    }
}
