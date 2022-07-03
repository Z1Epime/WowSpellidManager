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
    public class IDHolderViewModel : INotifyPropertyChanged
    {
        private IDHolder fIDHolder;

        public string ID
        {
            get
            {
                return fIDHolder.ID;
            }
            set
            {
                if (fIDHolder.ID != value)
                {
                    fIDHolder.ID = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public IDHolderViewModel(IDHolder aIDHolder)
        {
            fIDHolder = aIDHolder;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
