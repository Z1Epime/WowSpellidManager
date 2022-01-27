using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;

namespace WowSpellidManager.Infrastructure.DataManager
{
    internal class DataHolder
    {
        private List<Spell> fSpells;
        private List<Specialization> fSpecializations;
        private List<WowClass> fWowClasses;

        public List<Spell> Spells
        { 
            get 
            { 
                return fSpells; 
            } 
        }

        public List<Specialization> Specializations
        { 
            get 
            { 
                return fSpecializations; 
            }
        }

        public List <WowClass> WowClasses 
        { 
            get 
            { 
                return fWowClasses; 
            } 
        }

    }
}
