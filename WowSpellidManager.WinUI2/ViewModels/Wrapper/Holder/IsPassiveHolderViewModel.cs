using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.DomainUWP.Models.Helper;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Holder
{
    public class IsPassiveHolderViewModel : INotifyPropertyChanged
    {
        private IsPassiveHolder fIsPassiveHolder;

        public bool IsPassive
        {
            get
            {
                return fIsPassiveHolder.IsPassive;
            }
            set
            {
                if (fIsPassiveHolder.IsPassive != value)
                {
                    fIsPassiveHolder.IsPassive = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public IsPassiveHolderViewModel(IsPassiveHolder aIDHolder)
        {
            fIsPassiveHolder = aIDHolder;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
