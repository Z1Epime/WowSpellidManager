using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Spells;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Core
{
    public class CastViewModel
    {
        private Cast fCast;

        public int Time
        {
            get => fCast.Time;
            set => fCast.Time = value;
        }

        public CastType CastType
        {
            get => fCast.CastType;
            set => fCast.CastType = value;
        }

        public bool IsOffGlobal
        {
            get => fCast.IsOffGlobal;
            set => fCast.IsOffGlobal= value;
        }

        public TimeUnit TimeUnit
        {
            get => fCast.Unit;
            set => fCast.Unit = value;
        }

        public CastViewModel(Cast aCast)
        {
            fCast = aCast;
        }
    }
}
