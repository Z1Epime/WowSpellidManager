using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.Domain.Models.Spells
{
    /// <summary>
    /// This class represents the cooldown of a spell in World of Warcraft. <br></br>
    /// For simplification purposes this class does not inherit from Entity. Note that this class does not have a GUID.
    /// </summary>
    public class Cooldown
    {
        #region Fields
        private double fNumber;
        private string fUnit;
        #endregion

        #region Properties
        /// <summary>
        /// The number part of the cooldown.
        /// </summary>
        public double Number
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
        /// The specified unit of the cooldown (minutes, seconds, hours etc.).
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
        /// The main constructor to create a new instance of the Cooldown class with.
        /// </summary>
        /// <param name="aNumber"></param>
        /// <param name="aUnit"></param>
        public Cooldown(double aNumber, string aUnit)
        {
            fNumber = aNumber;
            fUnit = aUnit;
        }

        /// <summary>
        /// For json deserializing only.
        /// </summary>
        public Cooldown()
        {

        }
        #endregion
    }
}
