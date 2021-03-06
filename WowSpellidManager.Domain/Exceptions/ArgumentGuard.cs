using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Exceptions.BusinessExceptions;
using WowSpellidManager.Domain.Exceptions.TechnicalExceptions;
using WowSpellidManager.Domain.Models;

namespace WowSpellidManager.Domain.Exceptions
{
    public class ArgumentGuard
    {
        public static void CheckNull(object aObject)
        {
            if(aObject == null)
            {
                throw new ArgumentNullException(nameof(aObject));
            }
        }

        public static void CheckGuid(Guid aGuid)
        {
            if(!Guid.TryParse(aGuid.ToString(), out var aGuid2))
            {
                throw new GuidNotValidException(nameof(aGuid2));
            }
        }

        public static void CheckID(string aID)
        {
            if(!Int64.TryParse(aID, out _))
            {
                throw new SpellIDNotValidException(nameof(aID));
            }
        } 

        public static void StringNullOrEmpty(string aString)
        {
            if (string.IsNullOrEmpty(aString))
            {
                throw new ArgumentException(nameof(aString));
            }
        }

        public static void CheckNumberOfSpecializations(List<Specialization> aSpecializations)
        {
            if(aSpecializations.Count < 2 ||
                aSpecializations.Count > 4)
            {
                throw new NumberOfSpecializationsInvalidException(nameof(aSpecializations));
            }
        }
    }
}
