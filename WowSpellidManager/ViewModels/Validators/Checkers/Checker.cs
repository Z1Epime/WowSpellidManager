using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WowSpellidManager.ViewModels.Validators.Errors;
using WowSpellidManager.ViewModels.Validators.Rules;

namespace WowSpellidManager.ViewModels.Validators.Checkers
{
    public class Checker : IStringRule
    {

        public Error Empty(string aStringToCheck, string aInputName)
        {
            if (string.IsNullOrEmpty(aStringToCheck))
            {
                return new Error($"The {aInputName} has to contain something.");
            }
            return null;
        }

        public Error Letters(string aStringToCheck, string aInputName)
        {
            if (aStringToCheck.Any(x => !char.IsLetter(x)))
            {
                return new Error($"The {aInputName} cannot have letters.");
            }
            return null;
        }

        public Error MaxCharacters(string aStringToCheck, int aMaximum, string aInputName)
        {
            if (aStringToCheck.Length > aMaximum)
            {
                return new Error($"The {aInputName} cannot have more than {aMaximum} characters.");
            }
            return null;
        }

        public Error MinCharacters(string aStringToCheck, int aMinimum, string aInputName)
        {
            if (aStringToCheck.Length < aMinimum)
            {
                return new Error($"The {aInputName} cannot have less than {aMinimum} characters.");
            }
            return null;
        }

        public Error Numbers(string aStringToCheck, string aInputName)
        {
            if (Regex.Match(aStringToCheck, @"[\d]").Success)
            {
                return new Error($"The {aInputName} cannot have numbers.");
            }
            return null;
        }

        public Error OnlyAlphanumeric(string aStringToCheck, string aInputName)
        {
            if (!Regex.IsMatch(aStringToCheck, "^[a-zA-Z0-9]*$"))
            {
                return new Error($"The {aInputName} has to contain alphanumeric characters only.");
            }
            return null;
        }

        public Error OnlyLettersAndCertainCharacters(string aStringToCheck, string aInputName)
        {
            if (!Regex.Match(aStringToCheck, @"[A-Z'’a-zö äüÖÄÜ-]").Success)
            {
                return new Error($"The {aInputName} has to contain the following characters only: letters, ö, ä, ü, -, ', ’");
            }
            return null;
        }

        public Error OnlyNumbers(string aStringToCheck, string aInputName)
        {
            if (!aStringToCheck.All(char.IsDigit))
            {
                return new Error($"The {aInputName} has to contain letters only.");
            }
            return null;
        }
    }
}
