using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WowSpellidManager.DomainUWP.Models.Helper;
using WowSpellidManager.Infrastructure.CRUD;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Holder
{
    public class AdditionalInfoHolderViewModel : INotifyPropertyChanged, IAutoSave
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
                    Save();
                }
            }
        }

        public DataOperationProvider DataOperationProvider => new DataOperationProvider();

        public AdditionalInfoHolderViewModel(AdditionalInfoHolder aAdditionalInfoHolder)
        {
            fAdditionalInfoHolder = aAdditionalInfoHolder;
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
