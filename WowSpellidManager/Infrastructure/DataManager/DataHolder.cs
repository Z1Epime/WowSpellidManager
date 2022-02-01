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

        private ObservableCollection<WowClass> fWowClasses;
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
