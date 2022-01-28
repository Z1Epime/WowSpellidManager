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
    /// Represent a class(i.e. Paladin, Warrior, Hunter, ...) from World of Warcraft. <br/>
    /// The WowClass will be held as simple as possible to only meet the very needs which are group, filter and sort stuff by class etc.
    /// </summary>
    public class WowClass : Entity
    {
        /// <summary>
        /// A constant integer to very that a WowClasses amount <br></br>
        /// of specializations is not less than a specific number.
        /// <para></para>
        /// In World of Warcraft the Demonhunter class currently has 2 specializations <br></br>
        /// and the Druid class has 4. Every other class has 3.
        /// </summary>
        public const int SPECIALIZATIONSMIN = 2;

        /// <summary>
        /// A constant integer to very that a WowClasses amount <br></br>
        /// of specializations is not higher than a specific number.
        /// <para></para>
        /// In World of Warcraft the Demonhunter class currently has 2 specializations <br></br> 
        /// and the Druid class has 4. Every other class has 3.
        /// </summary>
        public const int SPECIALIZATIONSMAX = 4;


        private Specialization[] fSpecializations;
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

        public Specialization[] Specializations
        { 
            get 
            { 
                return fSpecializations; 
            }
            set 
            {
                ArgumentGuard.CheckNumberOfSpecializations(value);
                fSpecializations = value; 
            }
        }

       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aGuid">A Global Uniqe Identifier (GUID) to uniqly identify a WowClass in the program. <br/> 
        /// If no Guid is known the other constructor should be of use.</param>
        /// <param name="aDesignation">The name of the World of Warcraft class as a string which will be set in the constructor of the derived class.</param>
        /// <param name="aDescription">The description of the World of Warcraft class as a string.</param>
        public WowClass(Guid aGuid, string aDesignation, string aDescription) : base(aGuid, aDesignation)
        {
            Description = aDescription;
            Specializations = new Specialization[4];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aDesignation">The name of the World of Warcraft class as a string which will be set in the constructor of the derived class.</param>
        /// <param name="aDescription">The description of the World of Warcraft class as a string.</param>
        public WowClass(string aDesignation, string aDescription) : base(aDesignation)
        {
            Description = aDescription;
            Specializations = new Specialization[4];
        }
    }
}
