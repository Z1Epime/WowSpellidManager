using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using WowSpellidManager.Domain.Models.Spells;
using WowSpellidManager.DomainUWP.Models.Spells;
using WowSpellidManager.Infrastructure.CRUD;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Core
{
    public class RangeViewModel : INotifyPropertyChanged, IAutoSave
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
                    Save();
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
                    Save();
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
                Save();
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

        public DataOperationProvider DataOperationProvider => new DataOperationProvider();

        public RangeViewModel(Range aRange)
        {
            fRange = aRange;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Save()
        {
            DataOperationProvider.WowClassOperator.Save();
        }
    }
}
