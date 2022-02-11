using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.WinUI3.ViewModels.Validators.Errors;

namespace WowSpellidManager.WinUI3.ViewModels.Validators.Checkers
{
    public class SpellChecker
    {
        private Checker fChecker;

        public SpellChecker()
        {
            fChecker = new Checker();
        }

        /// <summary>
        /// Checks input for a spell, returns an "Error" if incorrect input is found and returns null otherwise.
        /// </summary>
        /// <param name="aName"></param>
        /// <param name="aID"></param>
        /// <param name="aDescription"></param>
        /// <returns></returns>
        public Error CheckSpell(string aName, string aID, string aDescription)
        {
            Error error;

            // checking aName
            error = fChecker.Numbers(aName, "spell name");
            if(error != null) return error;

            error = fChecker.OnlyLetters(aName, "spell name");
            if( error != null) return error;

            error = fChecker.MaxCharacters(aName, 50, "spell name");
            if (error != null) return error;

            // checking aID
            error = fChecker.OnlyNumbers(aID, "spell id");
            if (error != null) return error;

            // checking aDescription
            error = fChecker.MaxCharacters(aDescription, 256, "spell description");
            if( (error != null) ) return error;

            return null;
        }
    }
}
