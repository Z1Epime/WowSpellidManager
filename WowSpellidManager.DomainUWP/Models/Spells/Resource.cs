using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.Domain.Models.Spells
{
    /// <summary>
    /// This class represents a combat resource (energy, rage, mana focus etc.) for spells and abilites in World of Warcraft. <br></br>
    /// For simplification purposes this class does not inherit from Entity. Note that this class does not have a GUID.
    /// </summary>
    public class Resource
    {
        #region Fields
        private double fAmount;
        private string fDesignation;
        #endregion

        #region Properties
        /// <summary>
        /// The designation (name) of the resource that is needed to cast a spell a single time.
        /// </summary>
        public string Designation
        {
            get
            {
                return fDesignation;
            }

            set
            {
                fDesignation= value;
            }
        }

        /// <summary>
        /// The amount of resource that is needed for one cast of the spell.
        /// </summary>
        public double Amount
        {
            get
            {
                return fAmount;
            }

            set
            {
                fAmount = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// The main constructor to create a new instance of the Resource class
        /// </summary>
        /// <param name="aDesignation">See property (in Entity class) "Designation"</param>
        /// <param name="aAmount">See propertie "Amount"</param>
        public Resource(string aDesignation, double aAmount)
        {
            fDesignation = aDesignation;
            Amount = aAmount;
        }

        /// <summary>
        /// For json deserializing only.
        /// </summary>
        public Resource()
        {

        }
        #endregion
    }
}
