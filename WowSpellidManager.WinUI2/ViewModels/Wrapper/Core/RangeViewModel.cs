using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Spells;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Core
{
    public class RangeViewModel
    {
        private Range fRange;

        public int Number
        {
            get => fRange.Number;
            set => fRange.Number = value;
        }

        public RangeUnit RangeUnit
        {
            get => fRange.Unit;
            set => fRange.Unit = value;
        }

        public RangeViewModel(Range aRange)
        {
            fRange = aRange;
        }
    }
}
