using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.DomainUWP.Models.Spells;

namespace WowSpellidManager.Domain.Models.Spells
{
    /// <summary>
    /// Represents the cast of a spell. A spell can either be instant cast, <br></br>
    /// have a cast time or has to be channeled. That is determined by the CastType enumeration type. <br></br>
    /// For simplification purposes this class does not inherit from Entity. Note that this class does not have a GUID.
    /// </summary>
    public class Cast
    {
        #region Fields
        private int? fTime;
        private CastType fCastType;
        private bool fIsOffGlobal;
        private TimeUnit fUnit;
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
        /// Determines in which way the spell is cast.
        /// </summary>
        public CastType CastType
        {
            get
            {
                return fCastType;
            }

            set
            {
                fCastType = value;
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

        /// <summary>
        /// The unit of the time of cast.
        /// </summary>
        public TimeUnit Unit
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
        /// The main constructor to create a new instance of the Cast class with.
        /// </summary>
        /// <param name="aTime"></param>
        /// <param name="aIsChanneling"></param>
        public Cast(int? aTime, CastType aCastType, TimeUnit aUnit, bool aIsOffGlobal)
        {
            Time = aTime;
            CastType = aCastType;
            Unit = aUnit;
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
