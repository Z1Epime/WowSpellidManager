using System;

namespace WowSpellidManager.Domain.Exceptions.TechnicalExceptions
{
    public class InvalidParsingMethodException : Exception
    {
        public InvalidParsingMethodException(string message) : base(message)
        {

        }

    }
}
