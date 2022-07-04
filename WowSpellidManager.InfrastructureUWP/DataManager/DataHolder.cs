using System.Collections.ObjectModel;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Infrastructure.Metadata;

namespace WowSpellidManager.Infrastructure.DataManager
{
    public class DataHolder
    {
        public static DataProvider DataProvider { get; set; }

        private ObservableCollection<WowClass> fWowClasses;
        private Settings fSettings;
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

        public Settings Settings
        {
            get
            {
                return fSettings;
            }
            set
            {
                fSettings = value;
            }
        }

    }
}
