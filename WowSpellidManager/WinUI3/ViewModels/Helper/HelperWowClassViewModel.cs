using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.WinUI3.ViewModels.Wrapper;

namespace WowSpellidManager.WinUI3.ViewModels.Helper
{
    public class HelperWowClassViewModel : ViewModel
    {
        public ObservableCollection<WowClass> GetWowClasses()
        {
            return fDataOperationProvider.WowClassOperator.GetWowClasses();
        }

        public void AddWowClass(string aDesignation, string aDescription)
        {
            fDataOperationProvider.WowClassOperator.AddWowClass(new WowClass(aDesignation, aDescription));
        }
        
        public void SaveWowClasses()
        {
            fDataOperationProvider.SpellOperator.Save();
        }
    }
}