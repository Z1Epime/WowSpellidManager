using System.IO;

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
