using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Infrastructure.CRUD.JSON;
using WowSpellidManager.Infrastructure.DataManager;
using WowSpellidManager.Infrastructure.Metadata;

namespace WowSpellidManager.Infrastructure.CRUD
{
    public class SettingsOperator
    {
        public string GetSavingsPath()
        {
            return Settings.SavingsPath;
        }

        public void Save()
        {
            JsonSaver.SaveSettings();
        }
    }
}
