using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Infrastructure.Helper;
using WowSpellidManager.Infrastructure.Metadata;
using WowSpellidManager.WinUI3.ViewModels.Validators.Errors;

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

        public Error CheckDirectoryExists(string aDirectoryPath)
        {
            Error error = null;

            if(!FileAccessHelper.CheckDirectoryExists(aDirectoryPath))
            {
                error = new Error("This directory does not exist.");
            }
            return error;
        }
    }
}
