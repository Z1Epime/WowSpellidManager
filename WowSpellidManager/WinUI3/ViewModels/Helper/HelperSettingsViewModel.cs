using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Infrastructure.Metadata;

namespace WowSpellidManager.WinUI3.ViewModels.Helper
{
    public class HelperSettingsViewModel : ViewModel
    {
        public Settings GetSettings()
        {
            return fDataOperationProvider.SettingsOperator.GetSettings();
        }

        public void SaveSettings()
        {
            fDataOperationProvider.SettingsOperator.Save();
        }
    }
}
