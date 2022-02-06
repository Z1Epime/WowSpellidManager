using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.WinUI3.ViewModels.Helper
{
    public class HelperSettingsViewModel : ViewModel
    {
        public string GetSavingsPath()
        {
            return fDataOperationProvider.SettingsOperator.GetSavingsPath();
        }
    }
}
