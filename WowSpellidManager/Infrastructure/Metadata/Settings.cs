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

    }
}
