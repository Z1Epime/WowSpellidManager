using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.Domain.Exceptions.BusinessExceptions
{
    internal class NumberOfSpecializationsInvalidException : Exception
    {
        public NumberOfSpecializationsInvalidException(string message) : base(message)
        {

        }

    }
}
