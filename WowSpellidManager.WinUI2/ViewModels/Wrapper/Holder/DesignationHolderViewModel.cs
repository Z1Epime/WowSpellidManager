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
    public  class DesignationHolderViewModel : INotifyPropertyChanged
    {
        private DesignationHolder fDesignationHolder;

        public string Designation
        {
            get
            {
                return fDesignationHolder.Designation;
            }
            set
            {
                if (fDesignationHolder.Designation != value)
                {
                    fDesignationHolder.Designation = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public DesignationHolderViewModel(DesignationHolder aDesignationHolder)
        {
            fDesignationHolder = aDesignationHolder;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
