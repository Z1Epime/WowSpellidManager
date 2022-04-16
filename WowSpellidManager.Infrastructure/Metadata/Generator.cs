using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Metadata;
using WowSpellidManager.Domain.Models;

namespace WowSpellidManager.Infrastructure.Metadata
{
    public static class Generator
    {
        /// <summary>
        /// Generates the WowClasses and its specializations
        /// </summary>
        public static ObservableCollection<WowClass> Generate()
        {
            ObservableCollection<WowClass> wowClasses = new ObservableCollection<WowClass>();

            WowClass warrior = new WowClass(WowNames.WARRIOR, "tbd");
            warrior.Specializations.Add(new Specialization(WowNames.WARRIOR_ARMS, "tbd"));
            warrior.Specializations.Add(new Specialization(WowNames.WARRIOR_FURY, "tbd"));
            warrior.Specializations.Add(new Specialization(WowNames.WARRIOR_PROTECTION, "tbd"));
            wowClasses.Add(warrior);

            WowClass paladin = new WowClass(WowNames.PALADIN, "tbd");
            paladin.Specializations.Add(new Specialization(WowNames.PALADIN_RETRIBUTION, "tbd"));
            paladin.Specializations.Add(new Specialization(WowNames.PALADIN_HOLY, "tbd"));
            paladin.Specializations.Add(new Specialization(WowNames.PALADIN_PROTECTION, "tbd"));
            wowClasses.Add(paladin);

            WowClass hunter = new WowClass(WowNames.HUNTER, "tbd");
            hunter.Specializations.Add(new Specialization(WowNames.HUNTER_SURVIVAL, "tbd"));
            hunter.Specializations.Add(new Specialization(WowNames.HUNTER_MARKSMAN, "tbd"));
            hunter.Specializations.Add(new Specialization(WowNames.HUNTER_BEASTMASTERY, "tbd"));
            wowClasses.Add(hunter);

            WowClass rogue = new WowClass(WowNames.ROGUE, "tbd");
            rogue.Specializations.Add(new Specialization(WowNames.ROGUE_ASSASINATION, "tbd"));
            rogue.Specializations.Add(new Specialization(WowNames.ROGUE_SUBTLETY, "tbd"));
            rogue.Specializations.Add(new Specialization(WowNames.ROGUE_OUTLAW, "tbd"));
            wowClasses.Add(rogue);

            WowClass priest = new WowClass(WowNames.PRIEST, "tbd");
            priest.Specializations.Add(new Specialization(WowNames.PRIEST_HOLY, "tbd"));
            priest.Specializations.Add(new Specialization(WowNames.PRIEST_DISCIPLINE, "tbd"));
            priest.Specializations.Add(new Specialization(WowNames.PRIEST_SHADOW, "tbd"));
            wowClasses.Add(priest);

            WowClass shaman = new WowClass(WowNames.SHAMAN, "tbd");
            shaman.Specializations.Add(new Specialization(WowNames.SHAMAN_ELEMENTAL, "tbd"));
            shaman.Specializations.Add(new Specialization(WowNames.SHAMAN_ENHANCEMENT, "tbd"));
            shaman.Specializations.Add(new Specialization(WowNames.SHAMAN_RESTORATION, "tbd"));
            wowClasses.Add(shaman);

            WowClass mage = new WowClass(WowNames.MAGE, "tbd");
            mage.Specializations.Add(new Specialization(WowNames.MAGE_FROST, "tbd"));
            mage.Specializations.Add(new Specialization(WowNames.MAGE_FIRE, "tbd"));
            mage.Specializations.Add(new Specialization(WowNames.MAGE_ARCANE, "tbd"));
            wowClasses.Add(mage);

            WowClass warlock = new WowClass(WowNames.WARLOCK, "tbd");
            warlock.Specializations.Add(new Specialization(WowNames.WARLOCK_DEMONOLOGY, "tbd"));
            warlock.Specializations.Add(new Specialization(WowNames.WARLOCK_AFFLICTION, "tbd"));
            warlock.Specializations.Add(new Specialization(WowNames.WARLOCK_DESTRUCTION, "tbd"));
            wowClasses.Add(warlock);

            WowClass monk = new WowClass(WowNames.MONK, "tbd");
            monk.Specializations.Add(new Specialization(WowNames.MONK_WINDWALKER, "tbd"));
            monk.Specializations.Add(new Specialization(WowNames.MONK_MISTWEAVER, "tbd"));
            monk.Specializations.Add(new Specialization(WowNames.MONK_BREWMASTER, "tbd"));
            wowClasses.Add(monk);

            WowClass druid = new WowClass(WowNames.DRUID, "tbd");
            druid.Specializations.Add(new Specialization(WowNames.DRUID_FERAL, "tbd"));
            druid.Specializations.Add(new Specialization(WowNames.DRUID_GUARDIAN, "tbd"));
            druid.Specializations.Add(new Specialization(WowNames.DRUID_RESTORATION, "tbd"));
            druid.Specializations.Add(new Specialization(WowNames.DRUID_BALANCE, "tbd"));
            wowClasses.Add(druid);

            WowClass demonhunter = new WowClass(WowNames.DEMONHUNTER, "tbd");
            demonhunter.Specializations.Add(new Specialization(WowNames.DEMONHUNTER_VENGEANCE, "tbd"));
            demonhunter.Specializations.Add(new Specialization(WowNames.DEMONHUNTER_HAVOC, "tbd"));
            wowClasses.Add(demonhunter);

            WowClass deathknight = new WowClass(WowNames.DEATHKNIGHT, "tbd");
            deathknight.Specializations.Add(new Specialization(WowNames.DEATHKNIGHT_FROST, "tbd"));
            deathknight.Specializations.Add(new Specialization(WowNames.DEATHKNIGHT_UNHOLY, "tbd"));
            deathknight.Specializations.Add(new Specialization(WowNames.DEATHKNIGHT_BLOOD, "tbd"));
            wowClasses.Add(deathknight);


            return wowClasses;
        }
    }
}
