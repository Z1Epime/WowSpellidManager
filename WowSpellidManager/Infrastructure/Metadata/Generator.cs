using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            WowClass warrior = new WowClass("Warrior", "tbd");
            warrior.Specializations.Add(new Specialization("Arms", "tbd"));
            warrior.Specializations.Add(new Specialization("Fury", "tbd"));
            warrior.Specializations.Add(new Specialization("Protection", "tbd"));
            warrior.Specializations[^1].Spells.Add(new Spell("Stormbolt", "k thx bye", 578335));
            wowClasses.Add(warrior);

            WowClass paladin = new WowClass("Paladin", "tbd");
            paladin.Specializations.Add(new Specialization("Retribution", "tbd"));
            paladin.Specializations.Add(new Specialization("Holy", "tbd"));
            paladin.Specializations.Add(new Specialization("Protection", "tbd"));
            wowClasses.Add(paladin);

            WowClass hunter = new WowClass("Hunter", "tbd");
            hunter.Specializations.Add(new Specialization("Survival", "tbd"));
            hunter.Specializations.Add(new Specialization("Marksman", "tbd"));
            hunter.Specializations.Add(new Specialization("Beastmaster", "tbd"));
            wowClasses.Add(hunter);

            WowClass rogue = new WowClass("Rogue", "tbd");
            rogue.Specializations.Add(new Specialization("Assasination", "tbd"));
            rogue.Specializations.Add(new Specialization("Subtley", "tbd"));
            rogue.Specializations.Add(new Specialization("Outlaw", "tbd"));
            wowClasses.Add(rogue);

            WowClass priest = new WowClass("Priest", "tbd");
            priest.Specializations.Add(new Specialization("Holy", "tbd"));
            priest.Specializations.Add(new Specialization("Discipline", "tbd"));
            priest.Specializations.Add(new Specialization("Shadow", "tbd"));
            wowClasses.Add(priest);

            WowClass shaman = new WowClass("Shaman", "tbd");
            shaman.Specializations.Add(new Specialization("Elemental", "tbd"));
            shaman.Specializations.Add(new Specialization("Enhancement", "tbd"));
            shaman.Specializations.Add(new Specialization("Restoration", "tbd"));
            wowClasses.Add(shaman);

            WowClass mage = new WowClass("Mage", "tbd");
            mage.Specializations.Add(new Specialization("Frost", "tbd"));
            mage.Specializations.Add(new Specialization("Fire", "tbd"));
            mage.Specializations.Add(new Specialization("Arcane", "tbd"));
            wowClasses.Add(mage);

            WowClass warlock = new WowClass("Warlock", "tbd");
            warlock.Specializations.Add(new Specialization("Demonology", "tbd"));
            warlock.Specializations.Add(new Specialization("Affliction", "tbd"));
            warlock.Specializations.Add(new Specialization("Destruction", "tbd"));
            wowClasses.Add(warlock);

            WowClass monk = new WowClass("Monk", "tbd");
            monk.Specializations.Add(new Specialization("Windwalker", "tbd"));
            monk.Specializations.Add(new Specialization("Mistweaver", "tbd"));
            monk.Specializations.Add(new Specialization("Brewmaster", "tbd"));
            wowClasses.Add(monk);

            WowClass druid = new WowClass("Druid", "tbd");
            druid.Specializations.Add(new Specialization("Feral", "tbd"));
            druid.Specializations.Add(new Specialization("Guardian", "tbd"));
            druid.Specializations.Add(new Specialization("Restoration", "tbd"));
            druid.Specializations.Add(new Specialization("Balance", "tbd"));
            wowClasses.Add(druid);

            WowClass demonhunter = new WowClass("Demonhunter", "tbd");
            demonhunter.Specializations.Add(new Specialization("Vengeance", "tbd"));
            demonhunter.Specializations.Add(new Specialization("Havoc", "tbd"));
            wowClasses.Add(demonhunter);

            WowClass deathknight = new WowClass("Deathknight", "tbd");
            deathknight.Specializations.Add(new Specialization("Frost", "tbd"));
            deathknight.Specializations.Add(new Specialization("Unholy", "tbd"));
            deathknight.Specializations.Add(new Specialization("Blood", "tbd"));
            wowClasses.Add(deathknight);


            return wowClasses;
        }
    }
}
