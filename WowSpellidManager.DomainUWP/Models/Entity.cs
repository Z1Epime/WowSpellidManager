using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Exceptions;

namespace WowSpellidManager.Domain.Models
{
    public class Entity
    {
        #region Fields
        private Guid fGuid;
        private string fDesignation;
        #endregion

        #region Properties
        public Guid Guid
        {
            get
            {
                return fGuid;
            }

            set
            {
                ArgumentGuard.CheckGuid(value);
                fGuid = value;
            }
        }

        public string Designation
        {
            get 
            { 
                return fDesignation; 
            }

            set 
            {
                ArgumentGuard.StringNullOrEmpty(value);
                fDesignation = value; 
            }
        }
        #endregion

        #region Constructors
        public Entity(Guid aGuid, string aDesignation)
        {
            fGuid = aGuid;
            fDesignation = aDesignation;
        }

        public Entity(string aDesignation)
        {
            fGuid = Guid.NewGuid();
            this.fDesignation = aDesignation;
        }

        /// <summary>
        /// For json deserializing only
        /// </summary>
        public Entity()
        {

        }
        #endregion
    }
}
