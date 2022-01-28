using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.Domain.Exceptions.BusinessExceptions
{
    internal class SpellIDNotValidException : Exception
    {
        public SpellIDNotValidException(string message) : base(message)
        {

        }
    }
}
