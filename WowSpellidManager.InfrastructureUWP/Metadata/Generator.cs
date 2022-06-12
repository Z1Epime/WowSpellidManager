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

            WowClass warrior = new WowClass(WowNames.WARRIOR);
            warrior.Specializations.Add(new Specialization(WowNames.WARRIOR_ARMS));
            warrior.Specializations.Add(new Specialization(WowNames.WARRIOR_FURY));
            warrior.Specializations.Add(new Specialization(WowNames.WARRIOR_PROTECTION));
            wowClasses.Add(warrior);

            WowClass paladin = new WowClass(WowNames.PALADIN);
            paladin.Specializations.Add(new Specialization(WowNames.PALADIN_RETRIBUTION));
            paladin.Specializations.Add(new Specialization(WowNames.PALADIN_HOLY));
            paladin.Specializations.Add(new Specialization(WowNames.PALADIN_PROTECTION));
            wowClasses.Add(paladin);

            WowClass hunter = new WowClass(WowNames.HUNTER);
            hunter.Specializations.Add(new Specialization(WowNames.HUNTER_SURVIVAL));
            hunter.Specializations.Add(new Specialization(WowNames.HUNTER_MARKSMAN));
            hunter.Specializations.Add(new Specialization(WowNames.HUNTER_BEASTMASTERY));
            wowClasses.Add(hunter);

            WowClass rogue = new WowClass(WowNames.ROGUE);
            rogue.Specializations.Add(new Specialization(WowNames.ROGUE_ASSASINATION));
            rogue.Specializations.Add(new Specialization(WowNames.ROGUE_SUBTLETY));
            rogue.Specializations.Add(new Specialization(WowNames.ROGUE_OUTLAW));
            wowClasses.Add(rogue);

            WowClass priest = new WowClass(WowNames.PRIEST);
            priest.Specializations.Add(new Specialization(WowNames.PRIEST_HOLY));
            priest.Specializations.Add(new Specialization(WowNames.PRIEST_DISCIPLINE));
            priest.Specializations.Add(new Specialization(WowNames.PRIEST_SHADOW));
            wowClasses.Add(priest);

            WowClass shaman = new WowClass(WowNames.SHAMAN);
            shaman.Specializations.Add(new Specialization(WowNames.SHAMAN_ELEMENTAL));
            shaman.Specializations.Add(new Specialization(WowNames.SHAMAN_ENHANCEMENT));
            shaman.Specializations.Add(new Specialization(WowNames.SHAMAN_RESTORATION));
            wowClasses.Add(shaman);

            WowClass mage = new WowClass(WowNames.MAGE);
            mage.Specializations.Add(new Specialization(WowNames.MAGE_FROST));
            mage.Specializations.Add(new Specialization(WowNames.MAGE_FIRE));
            mage.Specializations.Add(new Specialization(WowNames.MAGE_ARCANE));
            wowClasses.Add(mage);

            WowClass warlock = new WowClass(WowNames.WARLOCK);
            warlock.Specializations.Add(new Specialization(WowNames.WARLOCK_DEMONOLOGY));
            warlock.Specializations.Add(new Specialization(WowNames.WARLOCK_AFFLICTION));
            warlock.Specializations.Add(new Specialization(WowNames.WARLOCK_DESTRUCTION));
            wowClasses.Add(warlock);

            WowClass monk = new WowClass(WowNames.MONK);
            monk.Specializations.Add(new Specialization(WowNames.MONK_WINDWALKER));
            monk.Specializations.Add(new Specialization(WowNames.MONK_MISTWEAVER));
            monk.Specializations.Add(new Specialization(WowNames.MONK_BREWMASTER));
            wowClasses.Add(monk);

            WowClass druid = new WowClass(WowNames.DRUID);
            druid.Specializations.Add(new Specialization(WowNames.DRUID_FERAL));
            druid.Specializations.Add(new Specialization(WowNames.DRUID_GUARDIAN));
            druid.Specializations.Add(new Specialization(WowNames.DRUID_RESTORATION));
            druid.Specializations.Add(new Specialization(WowNames.DRUID_BALANCE));
            wowClasses.Add(druid);

            WowClass demonhunter = new WowClass(WowNames.DEMONHUNTER);
            demonhunter.Specializations.Add(new Specialization(WowNames.DEMONHUNTER_VENGEANCE));
            demonhunter.Specializations.Add(new Specialization(WowNames.DEMONHUNTER_HAVOC));
            wowClasses.Add(demonhunter);

            WowClass deathknight = new WowClass(WowNames.DEATHKNIGHT);
            deathknight.Specializations.Add(new Specialization(WowNames.DEATHKNIGHT_FROST));
            deathknight.Specializations.Add(new Specialization(WowNames.DEATHKNIGHT_UNHOLY));
            deathknight.Specializations.Add(new Specialization(WowNames.DEATHKNIGHT_BLOOD));
            wowClasses.Add(deathknight);


            return wowClasses;
        }
    }
}
