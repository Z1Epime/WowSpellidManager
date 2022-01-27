using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.Infrastructure.DataManager
{
    internal class DataProvider
    {
        private static DataHolder fDataHolder;
        private static DataParser fDataParser;
        public static DataHolder DataHolder 
        {
            get
            { 
                return fDataHolder; 
            } 
        }

        public static DataParser DataParser
        {
            get
            {
                return fDataParser;
            }
        }
    }
}
