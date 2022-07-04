using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Infrastructure.CRUD;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper
{
    public interface IAutoSave
    {
        DataOperationProvider DataOperationProvider { get; }
        void Save();
    }
}
