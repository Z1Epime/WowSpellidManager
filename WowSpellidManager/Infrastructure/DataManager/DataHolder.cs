using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;

namespace WowSpellidManager.Infrastructure.DataManager
{
    public class DataHolder
    {
        public static DataProvider DataProvider { get; set; }

        private ObservableCollection<Spell> fSpells;
        private ObservableCollection<Specialization> fSpecializations;
        private ObservableCollection<WowClass> fWowClasses;

        public ObservableCollection<Spell> Spells
        { 
            get 
            { 
                return fSpells;
            }
            set
            {
                fSpells = value;
            }
        }

        public ObservableCollection<Specialization> Specializations
        { 
            get 
            { 
                return fSpecializations; 
            }
            set
            {
                fSpecializations = value;
            }
        }

        public ObservableCollection<WowClass> WowClasses 
        { 
            get 
            { 
                return fWowClasses; 
            }
            set
            {
                fWowClasses = value;
            }
        }

    }
}
