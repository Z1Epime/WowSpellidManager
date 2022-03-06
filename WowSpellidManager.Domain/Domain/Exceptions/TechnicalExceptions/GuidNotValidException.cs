using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.Domain.Exceptions.TechnicalExceptions
{
    internal class GuidNotValidException : Exception
    {
        public GuidNotValidException(string message) : base(message)
        {

        }
    }
}
