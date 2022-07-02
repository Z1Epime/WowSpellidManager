using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models.Spells;

namespace WowSpellidManager.DomainUWP.Models.Helper
{
    public class Wrapper<T> where T : Cooldown
    {
        public T Cooldown { get; set; }
    }
}
