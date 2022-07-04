using System;
using WowSpellidManager.Domain.Metadata;

namespace WowSpellidManager.Infrastructure.Metadata
{
    public class WowClassImagePaths
    {
        public const string Deathknight = "ms-appx:///Assets/Images/WowClasses/deathknight.PNG";
        public const string DemonHunter = "ms-appx:///Assets/Images/WowClasses/demonhunter.PNG";
        public const string Druid = "ms-appx:///Assets/Images/WowClasses/druid.PNG";
        public const string Hunter = "ms-appx:///Assets/Images/WowClasses/hunter.PNG";
        public const string Mage = "ms-appx:///Assets/Images/WowClasses/mage.PNG";
        public const string Monk = "ms-appx:///Assets/Images/WowClasses/monk.PNG";
        public const string Paladin = "ms-appx:///Assets/Images/WowClasses/paladin.PNG";
        public const string Priest = "ms-appx:///Assets/Images/WowClasses/priest.PNG";
        public const string Rogue = "ms-appx:///Assets/Images/WowClasses/rogue.PNG";
        public const string Shaman = "ms-appx:///Assets/Images/WowClasses/shaman.PNG";
        public const string Warlock = "ms-appx:///Assets/Images/WowClasses/warlock.PNG";
        public const string Warrior = "ms-appx:///Assets/Images/WowClasses/warrior.PNG";

        public static string GetPath(string aWowClassDesignation)
        {
            if (aWowClassDesignation.Equals(WowNames.DEATHKNIGHT, StringComparison.OrdinalIgnoreCase))
            {
                return Deathknight;
            }
            else if (aWowClassDesignation.Equals(WowNames.DEMONHUNTER, StringComparison.OrdinalIgnoreCase))
            {
                return DemonHunter;
            }
            else if (aWowClassDesignation.Equals(WowNames.DRUID, StringComparison.OrdinalIgnoreCase))
            {
                return Druid;
            }
            else if (aWowClassDesignation.Equals(WowNames.HUNTER, StringComparison.OrdinalIgnoreCase))
            {
                return Hunter;
            }
            else if (aWowClassDesignation.Equals(WowNames.MAGE, StringComparison.OrdinalIgnoreCase))
            {
                return Mage;
            }
            else if (aWowClassDesignation.Equals(WowNames.MONK, StringComparison.OrdinalIgnoreCase))
            {
                return Monk;
            }
            else if (aWowClassDesignation.Equals(WowNames.PALADIN, StringComparison.OrdinalIgnoreCase))
            {
                return Paladin;
            }
            else if (aWowClassDesignation.Equals(WowNames.PRIEST, StringComparison.OrdinalIgnoreCase))
            {
                return Priest;
            }
            else if (aWowClassDesignation.Equals(WowNames.ROGUE, StringComparison.OrdinalIgnoreCase))
            {
                return Rogue;
            }
            else if (aWowClassDesignation.Equals(WowNames.SHAMAN, StringComparison.OrdinalIgnoreCase))
            {
                return Shaman;
            }
            else if (aWowClassDesignation.Equals(WowNames.WARLOCK, StringComparison.OrdinalIgnoreCase))
            {
                return Warlock;
            }
            else if (aWowClassDesignation.Equals(WowNames.WARRIOR, StringComparison.OrdinalIgnoreCase))
            {
                return Warrior;
            }
            else
            {
                return Warrior;
            }
        }

    }
}
