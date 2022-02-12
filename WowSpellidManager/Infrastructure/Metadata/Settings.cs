using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    fSavingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
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
