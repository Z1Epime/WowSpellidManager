using WowSpellidManager.Infrastructure.CRUD;
using WowSpellidManager.Infrastructure.Helper;
using WowSpellidManager.Infrastructure.Metadata;
using WowSpellidManager.ViewModels.Validators.Errors;

namespace WowSpellidManager.ViewModels.Helper
{
    public class SettingsHelper
    {
        private DataOperationProvider fDataOperationProvider = new DataOperationProvider();
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
