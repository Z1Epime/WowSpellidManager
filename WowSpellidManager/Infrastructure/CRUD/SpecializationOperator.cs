using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Infrastructure.DataManager;

namespace WowSpellidManager.Infrastructure.CRUD
{
    public class SpecializationOperator
    {
        DataOperationProvider fDataOperationProvider = new DataOperationProvider();

        public List<Specialization> GetSpecializations()
        {
            return DataProvider.DataHolder.Specializations;
        }

        public void Save()
        {
            DataProvider.DataParser.Save();
        }
    }
}
