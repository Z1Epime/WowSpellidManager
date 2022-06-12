using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace WowSpellidManager.Infrastructure.Metadata
{
    public class Settings
    {
        private string fSavingsPath;
        private bool fIsDarkThemeActive;
        public string SavingsPath
        {
            get 
            {
                if(fSavingsPath == null)
                {
                    fSavingsPath = ApplicationData.Current.LocalFolder.Path;
                }
                return fSavingsPath; 
            }
            set 
            {
                fSavingsPath = value; 
            }
        }

        public bool IsDarkThemeActive
        {
            get 
            {
                return fIsDarkThemeActive;
            }
            set 
            {
                fIsDarkThemeActive = value; 
            }
        }

    }
}
