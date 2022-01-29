using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Exceptions;

namespace WowSpellidManager.Domain.Models
{
    /// <summary>
    /// Represents a World of Warcraft calss Specialization.
    /// </summary>
    public class Specialization : Entity
    {

        private ObservableCollection<Spell> fSpells;
        private string fDescription;
        public string Description
        {
            get
            {
                return fDescription;
            }
            set
            {
                ArgumentGuard.StringNullOrEmpty(value);
                fDescription = value;
            }
        }

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aGuid">A Global Uniqe Identifier (GUID) to uniqly identify a WowClass in the program. <br/> 
        /// If no Guid is known the other constructor should be of use.</param>
        /// <param name="aDesignation">The name of the World of Warcraft class specialization as a string which will be set in the constructor of the derived class.</param>
        /// <param name="aDescription">The description of the World of Warcraft class specialization as a string.</param>
        public Specialization(Guid aGuid, string aDesignation, string aDescription) : base(aGuid, aDesignation)
        {
            Description = aDescription;
            Spells = new ObservableCollection<Spell>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aDesignation">The name of the World of Warcraft class specialization as a string which will be set in the constructor of the derived class.</param>
        /// <param name="aDescription">The description of the World of Warcraft class specialization as a string.</param>
        public Specialization(string aDesignation, string aDescription) : base(aDesignation)
        {
            Description = aDescription;
            Spells = new ObservableCollection<Spell>();
        }

        /// <summary>
        /// For json deserializing only
        /// </summary>
        public Specialization()
        {

        }
    }
}
