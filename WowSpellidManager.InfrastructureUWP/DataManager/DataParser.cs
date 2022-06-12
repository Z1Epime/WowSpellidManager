using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Exceptions;
using WowSpellidManager.Infrastructure.CRUD.JSON;
using WowSpellidManager.Infrastructure.CRUD;
using System.Collections.ObjectModel;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.Domain.Exceptions.TechnicalExceptions;

namespace WowSpellidManager.Infrastructure.DataManager
{
    public class DataParser
    {
        public string fParsingMethod;
        public DataHolder fDataHolder;

        public void Save()
        {
            switch (fParsingMethod)
            {
                case "JSON":
                    JsonSaver.SaveWowClasses();
                    break;

                default:
                    throw new InvalidParsingMethodException("The parsing method is invalid!");
            }
        }

        public DataHolder Load()
        {
            switch (fParsingMethod)
            {
                case "JSON":
                    fDataHolder = new DataHolder();
                    fDataHolder.Settings = JsonLoader.LoadSettings();
                    fDataHolder.WowClasses = JsonLoader.LoadWowClasses();
                    break;
                default:
                    throw new InvalidParsingMethodException("The parsing method is invalid!");
            }
            return fDataHolder;
        }
    }
}
