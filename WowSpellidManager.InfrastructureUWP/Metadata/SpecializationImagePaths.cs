using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Metadata;

namespace WowSpellidManager.Infrastructure.Metadata
{
    public class SpecializationImagePaths
    {
        public const string DEATHKNIGHT_FROST = "ms-appx:///Assets/Images/specializations/deathknight/frost.PNG";
        public const string DEATHKNIGHT_BLOOD = "ms-appx:///Assets/Images/specializations/deathknight/blood.PNG";
        public const string DEATHKNIGHT_UNHOLY = "ms-appx:///Assets/Images/specializations/deathknight/unholy.PNG";

        public const string DEMONHUNTER_VENGEANCE = "ms-appx:///Assets/Images/specializations/demonhunter/vengeance.PNG";
        public const string DEMONHUNTER_HAVOC = "ms-appx:///Assets/Images/specializations/demonhunter/havoc.PNG";

        public const string DRUID_BALANCE = "ms-appx:///Assets/Images/specializations/druid/balance.PNG";
        public const string DRUID_FERAL = "ms-appx:///Assets/Images/specializations/druid/feral.PNG";
        public const string DRUID_RESTORATION = "ms-appx:///Assets/Images/specializations/druid/restoration.PNG";
        public const string DRUID_GUARDIAN = "ms-appx:///Assets/Images/specializations/druid/guardian.PNG";

        public const string HUNTER_SURVIVAL = "ms-appx:///Assets/Images/specializations/hunter/survival.PNG";
        public const string HUNTER_MARKSMAN = "ms-appx:///Assets/Images/specializations/hunter/marksman.PNG";
        public const string HUNTER_BEASTMASTERY = "ms-appx:///Assets/Images/specializations/hunter/beastmastery.PNG";

        public const string MAGE_FROST = "ms-appx:///Assets/Images/specializations/mage/frost.PNG";
        public const string MAGE_FIRE = "ms-appx:///Assets/Images/specializations/mage/fire.PNG";
        public const string MAGE_ARCANE = "ms-appx:///Assets/Images/specializations/mage/arcane.PNG";

        public const string MONK_WINDWALKER = "ms-appx:///Assets/Images/specializations/monk/windwalker.PNG";
        public const string MONK_MISTWEAVER = "ms-appx:///Assets/Images/specializations/monk/mistweaver.PNG";
        public const string MONK_BREWMASTER = "ms-appx:///Assets/Images/specializations/monk/brewmaster.PNG";

        public const string PALADIN_HOLY = "ms-appx:///Assets/Images/specializations/paladin/holy.PNG";
        public const string PALADIN_PROTECTION = "ms-appx:///Assets/Images/specializations/paladin/protection.PNG";
        public const string PALADIN_RETRIBUTION = "ms-appx:///Assets/Images/specializations/paladin/retribution.PNG";

        public const string PRIEST_SHADOW = "ms-appx:///Assets/Images/specializations/priest/shadow.PNG";
        public const string PRIEST_HOLY = "ms-appx:///Assets/Images/specializations/priest/holy.PNG";
        public const string PRIEST_DISCIPLINE = "ms-appx:///Assets/Images/specializations/priest/discipline.PNG";

        public const string ROGUE_SUBTLETY = "ms-appx:///Assets/Images/specializations/rogue/subtlety.PNG";
        public const string ROGUE_OUTLAW = "ms-appx:///Assets/Images/specializations/rogue/outlaw.PNG";
        public const string ROGUE_ASSASINATION = "ms-appx:///Assets/Images/specializations/rogue/assasination.PNG";

        public const string SHAMAN_ELEMENTAL = "ms-appx:///Assets/Images/specializations/shaman/elemental.PNG";
        public const string SHAMAN_ENHANCEMENT = "ms-appx:///Assets/Images/specializations/shaman/enhancement.PNG";
        public const string SHAMAN_RESTORATION = "ms-appx:///Assets/Images/specializations/shaman/restoration.PNG";

        public const string WARLOCK_DEMONOLOGY = "ms-appx:///Assets/Images/specializations/warlock/demonology.PNG";
        public const string WARLOCK_DESTRUCTION = "ms-appx:///Assets/Images/specializations/warlock/destruction.PNG";
        public const string WARLOCK_AFFLICTION = "ms-appx:///Assets/Images/specializations/warlock/affliction.PNG";

        public const string WARRIOR_ARMS = "ms-appx:///Assets/Images/specializations/warrior/arms.PNG";
        public const string WARRIOR_FURY = "ms-appx:///Assets/Images/specializations/warrior/fury.PNG";
        public const string WARRIOR_PROTECTION = "ms-appx:///Assets/Images/specializations/warrior/protection.PNG";

        public static string GetPath(string aWowClassDesignation, string aSpecializationDesignation)
        {
            if (aSpecializationDesignation.Equals(WowNames.FROST, StringComparison.OrdinalIgnoreCase))
            {
                if (aWowClassDesignation.Equals(WowNames.DEATHKNIGHT, StringComparison.OrdinalIgnoreCase))
                {
                    return DEATHKNIGHT_FROST;
                }
                else if (aWowClassDesignation.Equals(WowNames.MAGE, StringComparison.OrdinalIgnoreCase))
                {
                    return MAGE_FROST;
                }
                else
                {
                    return WARRIOR_ARMS;
                }
            }
            else if (aSpecializationDesignation.Equals(WowNames.DEATHKNIGHT_BLOOD, StringComparison.OrdinalIgnoreCase))
            {
                return DEATHKNIGHT_BLOOD;
            }
            else if (aSpecializationDesignation.Equals(WowNames.DEATHKNIGHT_UNHOLY, StringComparison.OrdinalIgnoreCase))
            {
                return DEATHKNIGHT_UNHOLY;
            }
            else if (aSpecializationDesignation.Equals(WowNames.MAGE_ARCANE, StringComparison.OrdinalIgnoreCase))
            {
                return MAGE_ARCANE;
            }
            else if (aSpecializationDesignation.Equals(WowNames.MAGE_FIRE, StringComparison.OrdinalIgnoreCase))
            {
                return MAGE_FIRE;
            }
            else if (aSpecializationDesignation.Equals(WowNames.DEMONHUNTER_HAVOC, StringComparison.OrdinalIgnoreCase))
            {
                return DEMONHUNTER_HAVOC;
            }
            else if (aSpecializationDesignation.Equals(WowNames.DEMONHUNTER_VENGEANCE, StringComparison.OrdinalIgnoreCase))
            {
                return DEMONHUNTER_VENGEANCE;
            }
            else if (aSpecializationDesignation.Equals(WowNames.RESTORATION, StringComparison.OrdinalIgnoreCase))
            {
                if (aWowClassDesignation.Equals(WowNames.DRUID, StringComparison.OrdinalIgnoreCase))
                {
                    return DRUID_RESTORATION;
                }
                else if (aWowClassDesignation.Equals(WowNames.SHAMAN, StringComparison.OrdinalIgnoreCase))
                {
                    return SHAMAN_RESTORATION;
                }else
                {
                    return WARRIOR_ARMS;
                }
            }
            else if (aSpecializationDesignation.Equals(WowNames.DRUID_FERAL, StringComparison.OrdinalIgnoreCase))
            {
                return DRUID_FERAL;
            }
            else if (aSpecializationDesignation.Equals(WowNames.DRUID_BALANCE, StringComparison.OrdinalIgnoreCase))
            {
                return DRUID_BALANCE;
            }
            else if (aSpecializationDesignation.Equals(WowNames.DRUID_GUARDIAN, StringComparison.OrdinalIgnoreCase))
            {
                return DRUID_GUARDIAN;
            }
            else if (aSpecializationDesignation.Equals(WowNames.ROGUE_ASSASINATION, StringComparison.OrdinalIgnoreCase))
            {
                return ROGUE_ASSASINATION;
            }
            else if (aSpecializationDesignation.Equals(WowNames.ROGUE_OUTLAW, StringComparison.OrdinalIgnoreCase))
            {
                return ROGUE_OUTLAW;
            }
            else if (aSpecializationDesignation.Equals(WowNames.ROGUE_SUBTLETY, StringComparison.OrdinalIgnoreCase))
            {
                return ROGUE_SUBTLETY;
            }
            else if (aSpecializationDesignation.Equals(WowNames.WARRIOR_ARMS, StringComparison.OrdinalIgnoreCase))
            {
                return WARRIOR_ARMS;
            }
            else if (aSpecializationDesignation.Equals(WowNames.WARRIOR_FURY, StringComparison.OrdinalIgnoreCase))
            {
                return WARRIOR_FURY;
            }
            else if (aSpecializationDesignation.Equals(WowNames.PROTECTION, StringComparison.OrdinalIgnoreCase))
            {
                if (aWowClassDesignation.Equals(WowNames.WARRIOR, StringComparison.OrdinalIgnoreCase))
                {
                    return WARRIOR_PROTECTION;
                }
                else if(aWowClassDesignation.Equals(WowNames.PALADIN, StringComparison.OrdinalIgnoreCase))
                {
                    return PALADIN_PROTECTION;
                }
                else
                {
                    return WARRIOR_ARMS;
                }
            }
            else if (aSpecializationDesignation.Equals(WowNames.HUNTER_BEASTMASTERY, StringComparison.OrdinalIgnoreCase))
            {
                return HUNTER_BEASTMASTERY;
            }
            else if (aSpecializationDesignation.Equals(WowNames.HUNTER_MARKSMAN, StringComparison.OrdinalIgnoreCase))
            {
                return HUNTER_MARKSMAN;
            }
            else if (aSpecializationDesignation.Equals(WowNames.HUNTER_SURVIVAL, StringComparison.OrdinalIgnoreCase))
            {
                return HUNTER_SURVIVAL;
            }
            else if (aSpecializationDesignation.Equals(WowNames.WARLOCK_DEMONOLOGY, StringComparison.OrdinalIgnoreCase))
            {
                return WARLOCK_DEMONOLOGY;
            }
            else if (aSpecializationDesignation.Equals(WowNames.WARLOCK_DESTRUCTION, StringComparison.OrdinalIgnoreCase))
            {
                return WARLOCK_DESTRUCTION;
            }
            else if (aSpecializationDesignation.Equals(WowNames.WARLOCK_AFFLICTION, StringComparison.OrdinalIgnoreCase))
            {
                return WARLOCK_AFFLICTION;
            }
            else if (aSpecializationDesignation.Equals(WowNames.PALADIN_RETRIBUTION, StringComparison.OrdinalIgnoreCase))
            {
                return PALADIN_RETRIBUTION;
            }
            else if (aSpecializationDesignation.Equals(WowNames.HOLY, StringComparison.OrdinalIgnoreCase))
            {
                if (aWowClassDesignation.Equals(WowNames.PALADIN, StringComparison.OrdinalIgnoreCase))
                {
                    return PALADIN_HOLY;
                }
                else if (aWowClassDesignation.Equals(WowNames.PRIEST, StringComparison.OrdinalIgnoreCase))
                {
                    return PRIEST_HOLY;
                }
                else
                {
                    return WARRIOR_ARMS;
                }
            }
            else if (aSpecializationDesignation.Equals(WowNames.PRIEST_SHADOW, StringComparison.OrdinalIgnoreCase))
            {
                return PRIEST_SHADOW;
            }
            else if (aSpecializationDesignation.Equals(WowNames.PRIEST_DISCIPLINE, StringComparison.OrdinalIgnoreCase))
            {
                return PRIEST_DISCIPLINE;
            }
            else if (aSpecializationDesignation.Equals(WowNames.SHAMAN_ELEMENTAL, StringComparison.OrdinalIgnoreCase))
            {
                return SHAMAN_ELEMENTAL;
            }
            else if (aSpecializationDesignation.Equals(WowNames.SHAMAN_ENHANCEMENT, StringComparison.OrdinalIgnoreCase))
            {
                return SHAMAN_ENHANCEMENT;
            }
            else if (aSpecializationDesignation.Equals(WowNames.MONK_BREWMASTER, StringComparison.OrdinalIgnoreCase))
            {
                return MONK_BREWMASTER;
            }
            else if (aSpecializationDesignation.Equals(WowNames.MONK_MISTWEAVER, StringComparison.OrdinalIgnoreCase))
            {
                return MONK_MISTWEAVER;
            }
            else if (aSpecializationDesignation.Equals(WowNames.MONK_WINDWALKER, StringComparison.OrdinalIgnoreCase))
            {
                return MONK_WINDWALKER;
            }
            else if (aSpecializationDesignation.Equals(WowNames.MONK_WINDWALKER, StringComparison.OrdinalIgnoreCase))
            {
                return MONK_WINDWALKER;
            }
            else if (aSpecializationDesignation.Equals(WowNames.MONK_WINDWALKER, StringComparison.OrdinalIgnoreCase))
            {
                return MONK_WINDWALKER;
            }
            else if (aSpecializationDesignation.Equals(WowNames.MONK_WINDWALKER, StringComparison.OrdinalIgnoreCase))
            {
                return MONK_WINDWALKER;
            }
            else if (aSpecializationDesignation.Equals(WowNames.MONK_WINDWALKER, StringComparison.OrdinalIgnoreCase))
            {
                return MONK_WINDWALKER;
            } else
            {
                return WARRIOR_ARMS; // TODO: Add "?" Icon here
            }
        }
    }
}
