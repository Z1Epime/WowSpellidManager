using System.Collections.ObjectModel;
using WowSpellidManager.Domain.Models;

namespace WowSpellidManager.Infrastructure.CRUD
{
    public class SpecializationOperator
    {
        private static DataOperationProvider fDataOperationProvider = new DataOperationProvider();

        public ObservableCollection<Specialization> GetSpecializations()
        {
            //return DataHolder.DataProvider.DataHolder.Specializations;
            return null;
        }

        public void Save()
        {
            //DataHolder.DataProvider.DataParser.Save();
        }
    }
}
