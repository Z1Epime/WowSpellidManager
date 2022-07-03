using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Exceptions;
using WowSpellidManager.DomainUWP.Models.Helper;
using WowSpellidManager.DomainUWP.Models.Spells;

namespace WowSpellidManager.Domain.Models.Spells
{
    /// <summary>
    /// Represents a World of Warcraft spell from a certain class / specialization
    /// </summary>
    public class Spell : Entity
    {
        #region Fields
        private IDHolder fIDHolder;
        private AdditionalInfoHolder fAdditionalInfoHolder;
        private Resource? fCost;
        private Cooldown? fCooldown;
        private ChargesHolder fChargesHolder;
        private Range? fRange;
        private ToolTipTextHolder fToolTipTextHolder;
        private Cast fCast;
        private IsPassiveHolder fIsPassiveHolder;
        private AvailabilityHolder fAvailabilityHolder;
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
        public ToolTipTextHolder ToolTipTextHolder
        {
            get
            {
                return fToolTipTextHolder;
            }

            set
            {
                fToolTipTextHolder = value;
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
        public ChargesHolder ChargesHolder
        {
            get
            {
                return fChargesHolder;
            }

            set
            {
                fChargesHolder = value;
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
                //if (fCooldown == null)
                //    fCooldown = new Cooldown();
                //if (fCooldown == null)
                //    fCooldown = new Wrapper<Cooldown>();
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
        public AdditionalInfoHolder AdditionalInfoHolder
        {
            get
            {
                return fAdditionalInfoHolder;
            }

            set
            {
                fAdditionalInfoHolder = value;
            }
        }

        /// <summary>
        /// The id of a spell / buff / debuff which is unique throughout the program and wow.
        /// </summary>
        public IDHolder IDHolder
        {
            get
            {
                return fIDHolder;
            }

            set
            {
                ArgumentGuard.CheckID(value);
                fIDHolder = value;
            }
        }

        /// <summary>
        /// Determines how the player acquires the spell.
        /// </summary>
        public AvailabilityHolder AvailabilityHolder
        {
            get
            {
                return fAvailabilityHolder;
            }

            set
            {
                fAvailabilityHolder = value;
            }
        }
          

        /// <summary>
        /// Determines wether is spell is a passive or not.
        /// </summary>
        public IsPassiveHolder IsPassiveHolder
        {
            get
            {
                return fIsPassiveHolder;
            }

            set
            {
                fIsPassiveHolder = value;
            }
        }
        #endregion

        #region Constructors
        public Spell(GuidHolder aGuid, DesignationHolder aDesignation, Cast aCast, IDHolder aID, IsPassiveHolder aIsPassive,
            AvailabilityHolder aAvailability, Range? aRange = null, ChargesHolder aCharges = null,
            ToolTipTextHolder aToolTipText = null, Cooldown? aCooldown = null, Resource? aCost = null,
            AdditionalInfoHolder aAdditionalInfo = null) : base(aGuid, aDesignation)
        {
            Cast = aCast;
            IsPassiveHolder = aIsPassive;
            Range = aRange;
            ChargesHolder = aCharges;
            Cost = aCost;
            ToolTipTextHolder = aToolTipText;
            Cooldown = aCooldown;
            AdditionalInfoHolder = aAdditionalInfo;
            AvailabilityHolder = aAvailability;
            IDHolder = aID;
        }

        public Spell(DesignationHolder aDesignation, Cast aCast, IDHolder aID, IsPassiveHolder aIsPassive,
            AvailabilityHolder aAvailability, Range? aRange = null, ChargesHolder aCharges = null,
            ToolTipTextHolder aToolTipText = null, Cooldown? aCooldown = null, Resource? aCost = null,
            AdditionalInfoHolder aAdditionalInfo = null) : base(aDesignation)
        {
            Cast = aCast;
            IsPassiveHolder = aIsPassive;
            Range = aRange;
            ChargesHolder = aCharges;
            Cost = aCost;
            ToolTipTextHolder = aToolTipText;
            Cooldown = aCooldown;
            AdditionalInfoHolder = aAdditionalInfo;
            AvailabilityHolder = aAvailability;
            IDHolder = aID;
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
