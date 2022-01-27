using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Infrastructure.DataManager;

namespace WowSpellidManager.Infrastructure.CRUD
{
    public class SpellOperator
    {
        DataOperationProvider fDataOperationProvider = new DataOperationProvider();

        public List<Spell> GetSpells()
        {
            return DataProvider.DataHolder.Spells;
        }

        public void Save()
        {
            DataProvider.DataParser.Save();
        }
    }
}
