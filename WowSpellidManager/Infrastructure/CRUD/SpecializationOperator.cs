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
    public class SpecializationOperator
    {
        private static DataOperationProvider fDataOperationProvider = new DataOperationProvider();

        public ObservableCollection<Specialization> GetSpecializations()
        {
            return DataHolder.DataProvider.DataHolder.Specializations;
        }

        public void Save()
        {
            DataHolder.DataProvider.DataParser.Save();
        }
    }
}
