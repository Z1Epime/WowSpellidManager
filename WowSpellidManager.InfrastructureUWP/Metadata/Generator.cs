using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Metadata;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.DomainUWP.Models.Helper;

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

            WowClass warrior = new WowClass(new DesignationHolder() { Designation = WowNames.WARRIOR });
            warrior.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.WARRIOR_ARMS }));
            warrior.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.WARRIOR_FURY }));
            warrior.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.WARRIOR_PROTECTION }));
            wowClasses.Add(warrior);

            WowClass paladin = new WowClass(new DesignationHolder() { Designation = WowNames.PALADIN });
            paladin.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.PALADIN_RETRIBUTION }));
            paladin.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.PALADIN_HOLY }));
            paladin.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.PALADIN_PROTECTION }));
            wowClasses.Add(paladin);

            WowClass hunter = new WowClass(new DesignationHolder() { Designation = WowNames.HUNTER });
            hunter.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.HUNTER_SURVIVAL }));
            hunter.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.HUNTER_MARKSMAN }));
            hunter.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.HUNTER_BEASTMASTERY }));
            wowClasses.Add(hunter);

            WowClass rogue = new WowClass(new DesignationHolder() { Designation = WowNames.ROGUE });
            rogue.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.ROGUE_ASSASINATION }));
            rogue.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.ROGUE_SUBTLETY }));
            rogue.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.ROGUE_OUTLAW }));
            wowClasses.Add(rogue);

            WowClass priest = new WowClass(new DesignationHolder() { Designation = WowNames.PRIEST });
            priest.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.PRIEST_HOLY }));
            priest.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.PRIEST_DISCIPLINE }));
            priest.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.PRIEST_SHADOW }));
            wowClasses.Add(priest);

            WowClass shaman = new WowClass(new DesignationHolder() { Designation = WowNames.SHAMAN });
            shaman.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.SHAMAN_ELEMENTAL }));
            shaman.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.SHAMAN_ENHANCEMENT }));
            shaman.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.SHAMAN_RESTORATION }));
            wowClasses.Add(shaman);

            WowClass mage = new WowClass(new DesignationHolder() { Designation = WowNames.MAGE });
            mage.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.MAGE_FROST }));
            mage.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.MAGE_FIRE }));
            mage.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.MAGE_ARCANE }));
            wowClasses.Add(mage);

            WowClass warlock = new WowClass(new DesignationHolder() { Designation = WowNames.WARLOCK });
            warlock.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.WARLOCK_DEMONOLOGY }));
            warlock.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.WARLOCK_AFFLICTION }));
            warlock.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.WARLOCK_DESTRUCTION }));
            wowClasses.Add(warlock);

            WowClass monk = new WowClass(new DesignationHolder() { Designation = WowNames.MONK });
            monk.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.MONK_WINDWALKER }));
            monk.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.MONK_MISTWEAVER }));
            monk.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.MONK_BREWMASTER }));
            wowClasses.Add(monk);

            WowClass druid = new WowClass(new DesignationHolder() { Designation = WowNames.DRUID });
            druid.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.DRUID_FERAL }));
            druid.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.DRUID_GUARDIAN }));
            druid.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.DRUID_RESTORATION }));
            druid.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.DRUID_BALANCE }));
            wowClasses.Add(druid);

            WowClass demonhunter = new WowClass(new DesignationHolder() { Designation = WowNames.DEMONHUNTER });
            demonhunter.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.DEMONHUNTER_VENGEANCE }));
            demonhunter.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.DEMONHUNTER_HAVOC }));
            wowClasses.Add(demonhunter);

            WowClass deathknight = new WowClass(new DesignationHolder() { Designation = WowNames.DEATHKNIGHT });
            deathknight.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.DEATHKNIGHT_FROST }));
            deathknight.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.DEATHKNIGHT_UNHOLY }));
            deathknight.Specializations.Add(new Specialization(new DesignationHolder() { Designation = WowNames.DEATHKNIGHT_BLOOD }));
            wowClasses.Add(deathknight);


            return wowClasses;
        }
    }
}
