using System;
using WowSpellidManager.DomainUWP.Models.Spells;

namespace WowSpellidManager.WinUI2.ViewModels.Helper
{
    public class TypeHelper
    {
        public static Type GetCastTypeType()
        {
            return typeof(CastType);
        }

        public static Type GetAvailabilityType()
        {
            return typeof(Availability);
        }
    }
}
