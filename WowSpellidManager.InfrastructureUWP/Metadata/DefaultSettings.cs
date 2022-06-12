using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace WowSpellidManager.Infrastructure.Metadata
{
    /// <summary>
    /// A simple class which only contains default values for settings.
    /// </summary>
    public class DefaultSettings
    {
        public static readonly string DefaultSavingsPath = ApplicationData.Current.LocalFolder.Path;
        public static readonly bool DefaultDarkThemeActive = false;
    }
}
