using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.Domain.Models.Spells
{
    /// <summary>
    /// Represents the maximum distance in order to cast a spell at an enemy. <br></br>
    /// For simplification purposes this class does not inherit from Entity. Note that this class does not have a GUID.
    /// </summary>
    public class Range
    {
        #region Fields
        private int fNumber;
        private string fUnit;
        #endregion

        #region Properties
        /// <summary>
        /// The number part of the range of a spell.
        /// </summary>
        public int Number
        {
            get
            {
                return fNumber;
            }

            set
            {
                fNumber = value;
            }
        }

        /// <summary>
        /// The unit of the range the spell has. Currently its "yard" everytime.
        /// </summary>
        public string Unit
        {
            get
            {
                return fUnit;
            }

            set
            {
                fUnit = value;
            }
        }
        #endregion

        #region Constructors 
        /// <summary>
        /// The main constructor to create a new instance of the Range class with.
        /// </summary>
        /// <param name="aNumber"></param>
        /// <param name="aUnit"></param>
        public Range(int aNumber, string aUnit)
        {
            fNumber = aNumber;
            fUnit = aUnit;
        }

        /// <summary>
        /// For json deserializing only.
        /// </summary>
        public Range()
        {

        }
        #endregion
    }
}
