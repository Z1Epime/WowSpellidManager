using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.Domain.Exceptions
{
    internal class InvalidParsingMethodException : Exception
    {
        public InvalidParsingMethodException(string message) : base(message)
        {
            
        }

    }
}
