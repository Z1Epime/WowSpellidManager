using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Infrastructure.CRUD;

namespace WowSpellidManager.Infrastructure.ViewModels
{
    public abstract class ViewModel
    {
        protected DataOperationProvider fDataOperationProvider = new DataOperationProvider();

        public void Save()
        {
            fDataOperationProvider.fSpellOperator.Save();
        }
    }
}
