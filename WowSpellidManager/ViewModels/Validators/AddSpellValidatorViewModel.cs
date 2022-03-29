using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.ViewModels;
using WowSpellidManager.ViewModels.Validators.Checkers;
using WowSpellidManager.ViewModels.Validators.Errors;
using WowSpellidManager.ViewModels.Validators.Rules;

namespace WowSpellidManager.ViewModels.Validators
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
