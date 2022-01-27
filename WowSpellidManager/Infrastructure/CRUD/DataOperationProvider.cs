using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WowSpellidManager.Infrastructure.CRUD
{
    public class DataOperationProvider
    {
        public SpellOperator fSpellOperator = new SpellOperator();
        public SpecializationOperator fspecializationOperator = new SpecializationOperator();
        public WowClassOperator fWowClassOperator = new WowClassOperator();
    }
}
