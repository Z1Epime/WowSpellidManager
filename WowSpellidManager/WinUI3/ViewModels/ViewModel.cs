using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Infrastructure.CRUD;

namespace WowSpellidManager.WinUI3.ViewModels
{
    public abstract class ViewModel
    {
        protected DataOperationProvider fDataOperationProvider = new DataOperationProvider();

        
    }
}
