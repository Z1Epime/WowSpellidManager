using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Spells;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Core
{
    public class RangeViewModel : INotifyPropertyChanged
    {
        private Range fRange;

        public int Number
        {
            get
            {
                return fRange.Number;
            }

            set
            {
                if (fRange.Number != value)
                {
                    fRange.Number = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public RangeUnit Unit
        {
            get
            {
                return fRange.Unit;
            }

            set
            {
                if (fRange.Unit != value)
                {
                    fRange.Unit = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool fHasRange;
        public bool HasRange
        {
            get 
            {
                if (Number > 0)
                    fHasRange = true;
                else
                    fHasRange = false;
                return fHasRange;
            }

            set
            {
                if (value == false)
                    Number = 0;
                else
                    Number = 1;
                fHasRange = value;
            }
        }

        public IEnumerable<RangeUnit> RangeUnitValues
        {
            get
            {
                return Enum.GetValues(typeof(RangeUnit))
                    .Cast<RangeUnit>();
            }
        }

        public RangeViewModel(Range aRange)
        {
            fRange = aRange;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
