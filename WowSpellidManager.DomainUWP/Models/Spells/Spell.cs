using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Exceptions;
using WowSpellidManager.DomainUWP.Models.Spells;

namespace WowSpellidManager.Domain.Models.Spells
{
    /// <summary>
    /// Represents a World of Warcraft spell from a certain class / specialization
    /// </summary>
    public class Spell : Entity
    {
        #region Fields
        private string fID;
        private string? fAdditionalInfo;
        private Resource? fCost;
        private Cooldown? fCooldown;
        private int? fCharges;
        private Range? fRange;
        private string fToolTipText;
        private Cast fCast;
        private bool fIsPassive;
        private Availability fAvailability;
        #endregion


        #region Properties
        /// <summary>
        /// Determines wether the spell is casted, instant cast or channeled throughout the Cast class
        /// </summary>
        public Cast Cast
        {
            get
            {
                return fCast;
            }

            set
            {
                fCast = value;
            }
        }

        /// <summary>
        /// The text of the Tooltip of the spell. Only The main text, not the other information (range, costs, cast time etc).
        /// </summary>
        public string ToolTipText
        {
            get
            {
                return fToolTipText;
            }

            set
            {
                fToolTipText = value;
            }
        }

        /// <summary>
        /// The range the spell has. Nullable because a spell can have unlimited range or it's not worth mentioning a range.
        /// </summary>
        public Range? Range
        {
            get
            {
                return fRange;
            }

            set
            {
                fRange = value;
            }
        }

        /// <summary>
        /// The number of charges (multiple uses before it goes on cooldown) a spell has. <br></br>
        /// Nullable because sometimes not worth mentioning or it just has one charge.
        /// </summary>
        public int? Charges
        {
            get
            {
                return fCharges;
            }

            set
            {
                fCharges = value;
            }
        }

        /// <summary>
        /// The cooldown this spell has represented by an instance of the Cooldown class. <br></br>
        /// Because a spell can have no cooldown at all this property is nullable.
        /// </summary>
        public Cooldown? Cooldown
        {
            get
            {
                return fCooldown;
            }

            set
            {
                fCooldown = value;
            }
        }

        /// <summary>
        /// An instance of the Resource class which represents the name and <br></br>
        /// the amount of the resource which is needed to cast the spell a single time <br></br>
        /// Because a spell can have costs not worth mentioning or no costs at all this property is nullable.
        /// </summary>
        public Resource? Cost
        {
            get
            {
                return fCost;
            }

            set
            {
                fCost = value;
            }
        }

        /// <summary>
        /// A String which contains more info about a spell which cannot be represented throughout the other properties. <br></br>
        /// Nullable because sometimes no additional info is required.
        /// </summary>
        public string? AdditionalInfo
        {
            get
            {
                return fAdditionalInfo;
            }

            set
            {
                fAdditionalInfo = value;
            }
        }

        /// <summary>
        /// The id of a spell / buff / debuff which is unique throughout the program and wow.
        /// </summary>
        public string ID
        {
            get
            {
                return fID;
            }

            set
            {
                ArgumentGuard.CheckID(value);
                fID = value;
            }
        }

        /// <summary>
        /// Determines how the player acquires the spell.
        /// </summary>
        public Availability Availability
        {
            get
            {
                return fAvailability;
            }

            set
            {
                Availability = value;
            }
        }
          

        /// <summary>
        /// Determines wether is spell is a passive or not.
        /// </summary>
        public bool IsPassive
        {
            get
            {
                return fIsPassive;
            }

            set
            {
                fIsPassive = value;
            }
        }
        #endregion

        #region Constructors
        public Spell(Guid aGuid, string aDesignation, Cast aCast, string aID, bool aIsPassive,
            Availability aAvailability, Range? aRange = null, int? aCharges = null, 
            string aToolTipText = null, Cooldown? aCooldown = null, Resource? aCost = null, 
            string aAdditionalInfo = null) : base(aGuid, aDesignation)
        {
            Cast = aCast;
            IsPassive = aIsPassive;
            Range = aRange;
            Charges = aCharges;
            Cost = aCost;
            ToolTipText = aToolTipText;
            Cooldown = aCooldown;
            AdditionalInfo = aAdditionalInfo;
            Availability = aAvailability;
            ID = aID;
        }

        public Spell(string aDesignation, Cast aCast, string aID, bool aIsPassive, 
            Availability aAvailability, Range? aRange = null, int? aCharges = null,
            string aToolTipText = null, Cooldown? aCooldown = null, Resource? aCost = null,
            string aAdditionalInfo = null) : base(aDesignation)
        {
            Cast = aCast;
            IsPassive = aIsPassive;
            Range = aRange;
            Charges = aCharges;
            Cost = aCost;
            ToolTipText = aToolTipText;
            Cooldown = aCooldown;
            AdditionalInfo = aAdditionalInfo;
            Availability = aAvailability;
            ID = aID;
        }

        /// <summary>
        /// For json deserializing only
        /// </summary>
        public Spell()
        {

        }
        #endregion

    }
}
