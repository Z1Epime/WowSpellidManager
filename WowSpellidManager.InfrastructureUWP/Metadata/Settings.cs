using Windows.Storage;

namespace WowSpellidManager.Infrastructure.Metadata
{
    public class Settings
    {
        private string fSavingsPath;
        private bool fIsDarkThemeActive;
        private bool fIsMainNavigationLayoutVertical;
        public string SavingsPath
        {
            get
            {
                if (fSavingsPath == null)
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

        public bool IsMainNavigationLayoutVertical
        {
            get
            {
                return fIsMainNavigationLayoutVertical;
            }
            set
            {
                fIsMainNavigationLayoutVertical = value;
            }
        }

    }
}
