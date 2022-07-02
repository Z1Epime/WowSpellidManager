using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Exceptions;
using WowSpellidManager.DomainUWP.Models.Helper;

namespace WowSpellidManager.Domain.Models
{
    public class Entity
    {
        #region Fields
        private Guid fGuid;
        private DesignationHolder fDesignation;
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

        public DesignationHolder Designation
        {
            get 
            { 
                return fDesignation; 
            }

            set 
            {
                ArgumentGuard.StringNullOrEmpty(((DesignationHolder)value).Designation);
                fDesignation = value; 
            }
        }
        #endregion

        #region Constructors
        public Entity(Guid aGuid, DesignationHolder aDesignation)
        {
            fGuid = aGuid;
            fDesignation = aDesignation;
        }

        public Entity(DesignationHolder aDesignation)
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
