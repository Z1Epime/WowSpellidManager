using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.Domain.Models
{
    public class Entity
    {
        private Guid fGuid;
        private string fDesignation;
        public Guid Guid
        {
            get
            {
                return fGuid;
            }
            set
            {
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
                fDesignation = value; 
            }
        }

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

    }
}
