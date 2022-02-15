﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WowSpellidManager.WinUI3.ViewModels.Validators.Errors;
using WowSpellidManager.WinUI3.ViewModels.Validators.Rules;

namespace WowSpellidManager.WinUI3.ViewModels.Validators.Checkers
{
    public class Checker : IStringRule
    {
        public Error Letters(string aStringToCheck, string aInputName)
        {
            if(aStringToCheck.Any(x => !char.IsLetter(x)))
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
            if (aStringToCheck.Any(char.IsDigit))
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

        public Error OnlyLetters(string aStringToCheck, string aInputName)
        {
            if (!aStringToCheck.All(char.IsLetter))
            {
                return new Error($"The {aInputName} has to contain letters only.");
            }
            return null;
        }

        public Error OnlyNumbers(string aStringToCheck, string aInputName)
        {
            if (!aStringToCheck.All(char.IsLetter))
            {
                return new Error($"The {aInputName} has to contain letters only.");
            }
            return null;
        }
    }
}