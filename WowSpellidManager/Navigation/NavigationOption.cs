using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.Navigation
{
    public class NavigationOption
    {
        #region Properties

        /// <summary>
        /// The name of the NavigationOption
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The name of the NavigationOption visible in the UI
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// The Glyph (a symbol) of the NavigationOption
        /// </summary>
        public Symbol Glyph { get; set; }

        #endregion


        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        public NavigationOption(string aName, string aDisplayName, Symbol aGlyph)
        {
            Name = aName;
            Glyph = aGlyph;
            DisplayName = aDisplayName;
        }

        #endregion
    }
}
