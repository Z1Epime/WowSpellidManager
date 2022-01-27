using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Exceptions;
using WowSpellidManager.Infrastructure.CRUD.JSON;
using WowSpellidManager.Infrastructure.CRUD;

namespace WowSpellidManager.Infrastructure.DataManager
{
    public class DataParser
    {
        public string fParsingMethod;

        public void Save()
        {
            switch (fParsingMethod)
            {
                case "JSON":
                    JsonSaver.SaveWowClasses();
                    JsonSaver.SaveSpecializations();
                    JsonSaver.SaveSpells();
                    break;

                default:
                    throw new InvalidParsingMethodException("The given parsing method is invalid!");
            }
        }
    }
}
