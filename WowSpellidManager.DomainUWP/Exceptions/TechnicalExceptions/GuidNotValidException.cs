using System;

namespace WowSpellidManager.Domain.Exceptions.TechnicalExceptions
{
    internal class GuidNotValidException : Exception
    {
        public GuidNotValidException(string message) : base(message)
        {

        }
    }
}
