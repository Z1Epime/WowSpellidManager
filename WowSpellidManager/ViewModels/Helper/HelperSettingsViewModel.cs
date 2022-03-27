using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Infrastructure.Helper;
using WowSpellidManager.Infrastructure.Metadata;
using WowSpellidManager.ViewModels;
using WowSpellidManager.ViewModels.Validators.Errors;

namespace WowSpellidManager.ViewModels.Helper
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
            fDataOperationProvider.WowClassOperator.Save();
        }

        public Error CheckDirectoryExists(string aDirectoryPath)
        {
            Error error = null;

            if (!FileAccessHelper.CheckDirectoryExists(aDirectoryPath))
            {
                error = new Error("This directory does not exist.");
            }
            return error;
        }
    }
}
