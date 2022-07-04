using System;

namespace WowSpellidManager.Domain.Exceptions.BusinessExceptions
{
    internal class NumberOfSpecializationsInvalidException : Exception
    {
        public NumberOfSpecializationsInvalidException(string message) : base(message)
        {

        }

    }
}
