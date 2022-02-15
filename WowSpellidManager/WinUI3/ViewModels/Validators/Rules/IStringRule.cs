﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.WinUI3.ViewModels.Validators.Errors;

namespace WowSpellidManager.WinUI3.ViewModels.Validators.Rules
{
    public interface IStringRule
    {
        #region Methods
        /// <summary>
        /// Checks if the string contains numbers. Returns "Error" if so and null otherwise.
        /// </summary>
        /// <param name="aStringToCheck"></param>
        /// <param name="aSenderName"></param>
        /// <returns></returns>
        public Error Numbers(string aStringToCheck, string aSenderName);

        /// <summary>
        /// Checks if the string contains letters. Returns "Error" if so and null otherwise.
        /// </summary>
        /// <param name="aStringToCheck"></param>
        /// <param name="aSenderName"></param>
        /// <returns></returns>
        public Error Letters(string aStringToCheck, string aSenderName);

        /// <summary>
        /// Checks if the string contains alphanumeric characters only. Returns "Error" if not and null otherwise.
        /// </summary>
        /// <param name="aStringToCheck"></param>
        /// <param name="aSenderName"></param>
        /// <returns></returns>
        public Error OnlyAlphanumeric(string aStringToCheck, string aSenderName);

        /// <summary>
        /// Checks if the string longer than a given maxiumum. Returns "Error" if so and null otherwise.
        /// </summary>
        /// <param name="aStringToCheck"></param>
        /// <param name="aMaximum"></param>
        /// <param name="aSenderName"></param>
        /// <returns></returns>
        public Error MaxCharacters(string aStringToCheck, int aMaximum, string aSenderName);

        /// <summary>
        /// Checks if the string shorter than a given minimum. Returns "Error" if so and null otherwise.
        /// </summary>
        /// <param name="aStringToCheck"></param>
        /// <param name="aMinimum"></param>
        /// <param name="aSenderName"></param>
        /// <returns></returns>
        public Error MinCharacters(string aStringToCheck, int aMinimum, string aSenderName);

        /// <summary>
        /// Checks if the string contains letters only. Returns "Error" if not so and null otherwise.
        /// </summary>
        /// <param name="aStringToCheck"></param>
        /// <param name="aInputName"></param>
        /// <returns></returns>
        public Error OnlyLetters(string aStringToCheck, string aInputName);

        /// <summary>
        /// Checks if the string contains numbers only. Returns null if so and an "Error" otherwise.
        /// </summary>
        /// <param name="aStringToCheck"></param>
        /// <param name="aInputName"></param>
        /// <returns></returns>
        public Error OnlyNumbers(string aStringToCheck, string aInputName);


        #endregion
    }
}