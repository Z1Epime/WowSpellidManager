using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Infrastructure.DataManager;

namespace WowSpellidManager.Infrastructure.CRUD
{
    public class WowClassOperator
    {
        private static DataOperationProvider fDataOperationProvider = new DataOperationProvider();

        public ObservableCollection<WowClass> GetWowClasses()
        {
            return DataHolder.DataProvider.DataHolder.WowClasses;
        }

        public void Save()
        {
            DataHolder.DataProvider.DataParser.Save();
        }

        public void AddWowClass(WowClass aWowClass)
        {
            aWowClass.Specializations.Add(new Specialization("Retribution", "bombin"));
            aWowClass.Specializations.Add(new Specialization("Holy", "healin"));
            aWowClass.Specializations.Add(new Specialization("Protection", "tankin"));
            foreach(var specialization in aWowClass.Specializations)
            {
                if (specialization.Designation.Equals("Retribution"))
                {
                    specialization.Spells.Add(new Spell("Hammer of Justice", "STUNLOCK", 35976));
                    specialization.Spells.Add(new Spell("Avenging Wrath", "BIG DAM", 437326));
                    specialization.Spells.Add(new Spell("Blinding Light", "Area of effect desorient", 553736));
                }

                if (specialization.Designation.Equals("Holy"))
                {
                    specialization.Spells.Add(new Spell("Word of Glory", "heal", 33625));
                }

            }

            WowClass bWowClass = new WowClass("Warrior", "Melee dps");
            bWowClass.Specializations.Add(new Specialization("Arms", "arms description"));
            bWowClass.Specializations.Add(new Specialization("Fury", "fury description"));
            bWowClass.Specializations.Add(new Specialization("Protection", "protection description"));

            foreach (var specialization in bWowClass.Specializations)
            {
                if (specialization.Designation.Equals("Arms"))
                {
                    specialization.Spells.Add(new Spell("Stormbolt", "30 yard 4 sec stun", 99024));
                    specialization.Spells.Add(new Spell("Die by the sword", "parry, 40% dmg reduce", 2454200));
                    specialization.Spells.Add(new Spell("Avatar", "DAM INCREASE", 32134));
                }

                if (specialization.Designation.Equals("Protection"))
                {
                    specialization.Spells.Add(new Spell("Shield Wall", "big deff", 47379));
                    specialization.Spells.Add(new Spell("Shockwave", "aoe stun", 5446191));
                }

            }





            DataHolder.DataProvider.DataHolder.WowClasses.Add(bWowClass);
            DataHolder.DataProvider.DataHolder.WowClasses.Add(aWowClass);

        }
    }
}
