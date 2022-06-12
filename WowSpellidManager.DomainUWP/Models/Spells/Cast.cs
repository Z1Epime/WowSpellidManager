using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.Domain.Models.Spells
{
    /// <summary>
    /// Represents the cast of a spell. A spell can either be instant cast, <br></br>
    /// have a cast time or has to be channeled. <br></br>
    /// For simplification purposes this class does not inherit from Entity. Note that this class does not have a GUID.
    /// </summary>
    public class Cast
    {
        #region Fields
        private int? fTime;
        private bool fIsChanneling;
        private bool fIsOffGlobal;
        #endregion

        #region Properties
        /// <summary>
        /// The time that is needed to either cast or channel the spell.
        /// </summary>
        public int? Time
        {
            get
            {
                return fTime;
            }

            set
            {
                fTime = value;
            }
        }

        /// <summary>
        /// Determines wether the spell is needed to be channeled or casted.
        /// </summary>
        public bool IsChanneling
        {
            get
            {
                return fIsChanneling;
            }

            set
            {
                fIsChanneling = value;
            }
        }

        /// <summary>
        /// Determines wether this spell is can be cast off global or not.
        /// </summary>
        public bool IsOffGlobal
        {
            get
            {
                return fIsOffGlobal;
            }

            set
            {
                fIsOffGlobal = value;
            }
        }
        #endregion

        #region Constructors 
        /// <summary>
        /// The main constructor to create a new instance of the Cast class with.
        /// </summary>
        /// <param name="aTime"></param>
        /// <param name="aIsChanneling"></param>
        public Cast(int? aTime, bool aIsChanneling, bool aIsOffGlobal)
        {
            Time = aTime;
            IsChanneling = aIsChanneling;
            IsOffGlobal = aIsOffGlobal;
        }

        /// <summary>
        /// For json deserializing only.
        /// </summary>
        public Cast()
        {

        }
        #endregion
    }
}
