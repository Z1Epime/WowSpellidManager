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
    public class AdditionalInfoHolderViewModel : INotifyPropertyChanged
    {
        private AdditionalInfoHolder fAdditionalInfoHolder;

        public string AdditionalInfo
        {
            get
            {
                return fAdditionalInfoHolder.AdditionalInfo;
            }
            set
            {
                if (fAdditionalInfoHolder.AdditionalInfo != value)
                {
                    fAdditionalInfoHolder.AdditionalInfo = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public AdditionalInfoHolderViewModel(AdditionalInfoHolder aAdditionalInfoHolder)
        {
            fAdditionalInfoHolder = aAdditionalInfoHolder;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
