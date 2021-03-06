using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Exceptions;

namespace WowSpellidManager.Domain.Models
{
    /// <summary>
    /// Represents a World of Warcraft spell from a certain class / specialization
    /// </summary>
    public class Spell : Entity
    {
        private string fID;
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

        public Spell(Guid aGuid, string aDesignation, string aDescription, string aID) : base(aGuid, aDesignation)
        {
            Description = aDescription;
            ID = aID;
        }

        public Spell(string aDesignation, string aDescription, string aID) : base(aDesignation)
        {
            Description = aDescription;
            ID = aID;
        }

        /// <summary>
        /// For json deserializing only
        /// </summary>
        public Spell()
        {

        }

    }
}
