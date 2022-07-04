using System;
using WowSpellidManager.Domain.Exceptions;
using WowSpellidManager.DomainUWP.Models.Helper;

namespace WowSpellidManager.Domain.Models
{
    public class Entity
    {
        #region Fields
        private GuidHolder fGuidHolder;
        private DesignationHolder fDesignationHolder;
        #endregion

        #region Properties
        public GuidHolder GuidHolder
        {
            get
            {
                if (fGuidHolder == null)
                    fGuidHolder = new GuidHolder();
                return fGuidHolder;
            }

            set
            {
                ArgumentGuard.CheckGuid(value);
                fGuidHolder = value;
            }
        }

        public DesignationHolder DesignationHolder
        {
            get
            {
                return fDesignationHolder;
            }

            set
            {
                ArgumentGuard.StringNullOrEmpty(value.Designation);
                fDesignationHolder = value;
            }
        }
        #endregion

        #region Constructors
        public Entity(GuidHolder aGuid, DesignationHolder aDesignation)
        {
            GuidHolder = aGuid;
            fDesignationHolder = aDesignation;
        }

        public Entity(DesignationHolder aDesignation)
        {
            GuidHolder.Guid = Guid.NewGuid();
            this.fDesignationHolder = aDesignation;
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
