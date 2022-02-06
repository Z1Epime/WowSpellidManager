using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.Infrastructure.Metadata
{
    public class Settings
    {
        /// <summary>
        /// Singleton
        /// </summary>
        private static string fSavingsPath;
        public static string SavingsPath
        {
            get 
            {
                if(fSavingsPath == null)
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
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
