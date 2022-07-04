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
    public class CastViewModel : INotifyPropertyChanged, IAutoSave
    {
        private Cast fCast;

        public int Time
        {
            get
            {
                return fCast.Time;
            }

            set
            {
                if (fCast.Time != value)
                {
                    fCast.Time = value;
                    NotifyPropertyChanged();
                    Save();
                }
            }
        }

        public CastType CastType
        {
            get
            {
                return fCast.CastType;
            }

            set
            {
                if (fCast.CastType != value)
                {
                    fCast.CastType = value;
                    NotifyPropertyChanged();
                    Save();
                }
            }
        }

        public bool IsOffGlobal
        {
            get
            {
                return fCast.IsOffGlobal;
            }

            set
            {
                if (fCast.IsOffGlobal != value)
                {
                    fCast.IsOffGlobal = value;
                    NotifyPropertyChanged();
                    Save();
                }
            }
        }

        public TimeUnit Unit
        {
            get
            {
                return fCast.Unit;
            }

            set
            {
                if (fCast.Unit != value)
                {
                    fCast.Unit = value;
                    NotifyPropertyChanged();
                    Save();
                }
            }
        }

        public IEnumerable<CastType> CastTypeValues
        {
            get
            {
                return Enum.GetValues(typeof(CastType))
                    .Cast<CastType>();
            }
        }

        public IEnumerable<TimeUnit> TimeUnitValues
        {
            get
            {
                return Enum.GetValues(typeof(TimeUnit))
                    .Cast<TimeUnit>();
            }
        }

        public DataOperationProvider DataOperationProvider => new DataOperationProvider();

        public CastViewModel(Cast aCast)
        {
            fCast = aCast;
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
