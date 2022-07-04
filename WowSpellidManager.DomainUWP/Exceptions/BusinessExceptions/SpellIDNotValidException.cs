using System;

namespace WowSpellidManager.Domain.Exceptions.BusinessExceptions
{
    internal class SpellIDNotValidException : Exception
    {
        public SpellIDNotValidException(string message) : base(message)
        {

        }
    }
}
