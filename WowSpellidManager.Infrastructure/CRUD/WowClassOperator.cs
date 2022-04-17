using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Infrastructure.DataManager;

namespace WowSpellidManager.Infrastructure.CRUD
{
    public class WowClassOperator
    {
        private static DataOperationProvider fDataOperationProvider = new DataOperationProvider();

        public ObservableCollection<WowClass> GetWowClasses()
        {
            return DataHolder.DataProvider.DataHolder.WowClasses;
        }

        public void Save()
        {
            DataHolder.DataProvider.DataParser.Save();
        }
    }
}
