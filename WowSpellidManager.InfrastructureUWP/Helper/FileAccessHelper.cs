using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.Infrastructure.Helper
{
    public class FileAccessHelper
    {
        public static bool CheckDirectoryExists(string aDirectoryPath)
        {
            return Directory.Exists(aDirectoryPath);
        }
    }
}
