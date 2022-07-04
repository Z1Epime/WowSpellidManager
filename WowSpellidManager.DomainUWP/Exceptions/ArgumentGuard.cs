using System;
using System.Collections.Generic;
using WowSpellidManager.Domain.Exceptions.BusinessExceptions;
using WowSpellidManager.Domain.Exceptions.TechnicalExceptions;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.DomainUWP.Models.Helper;

namespace WowSpellidManager.Domain.Exceptions
{
    public class ArgumentGuard
    {
        public static void CheckNull(object aObject)
        {
            if (aObject == null)
            {
                throw new ArgumentNullException(nameof(aObject));
            }
        }

        public static void CheckGuid(GuidHolder aGuid)
        {
            if (!Guid.TryParse(aGuid.Guid.ToString(), out var aGuid2))
            {
                throw new GuidNotValidException(nameof(aGuid2));
            }
        }

        public static void CheckID(IDHolder aID)
        {
            if (!Int64.TryParse(aID.ID, out _))
            {
                throw new SpellIDNotValidException(nameof(aID.ID));
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
            if (aSpecializations.Count < 2 ||
                aSpecializations.Count > 4)
            {
                throw new NumberOfSpecializationsInvalidException(nameof(aSpecializations));
            }
        }
    }
}
