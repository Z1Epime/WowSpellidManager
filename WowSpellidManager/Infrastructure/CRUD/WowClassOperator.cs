using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Infrastructure.DataManager;

namespace WowSpellidManager.Infrastructure.CRUD
{
    public class WowClassOperator
    {
        DataOperationProvider fDataOperationProvider = new DataOperationProvider();

        public List<WowClass> GetWowClasses()
        {
            return DataProvider.DataHolder.WowClasses;
        }

        public void Save()
        {
            DataProvider.DataParser.Save();
            
        }
    }
}
