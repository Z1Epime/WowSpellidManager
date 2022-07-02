using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Exceptions;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Helper;

namespace WowSpellidManager.Domain.Models
{
    /// <summary>
    /// Represents a World of Warcraft calss Specialization.
    /// </summary>
    public class Specialization : Entity
    {
        #region Fields
        private ObservableCollection<Spell> fSpells;
        #endregion

        #region Properties
        public ObservableCollection<Spell> Spells
        {
            get
            {
                return fSpells;
            }
            set
            {
                ArgumentGuard.CheckNull(value);
                fSpells = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aGuid">A Global Uniqe Identifier (GUID) to uniqly identify a WowClass in the program. <br/> 
        /// If no Guid is known the other constructor should be of use.</param>
        /// <param name="aDesignation">The name of the World of Warcraft class specialization as a string which will be set in the constructor of the derived class.</param>
        /// <param name="aDescription">The description of the World of Warcraft class specialization as a string.</param>
        public Specialization(GuidHolder aGuid, DesignationHolder aDesignation) : base(aGuid, aDesignation)
        {
            Spells = new ObservableCollection<Spell>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aDesignation">The name of the World of Warcraft class specialization as a string which will be set in the constructor of the derived class.</param>
        /// <param name="aDescription">The description of the World of Warcraft class specialization as a string.</param>
        public Specialization(DesignationHolder aDesignation) : base(aDesignation)
        {
            Spells = new ObservableCollection<Spell>();
        }

        /// <summary>
        /// For json deserializing only
        /// </summary>
        public Specialization()
        {

        }
        #endregion
    }
}
