using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WowSpellidManager.DomainUWP.Models.Helper;
using WowSpellidManager.Infrastructure.CRUD;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Holder
{
    public class IsPassiveHolderViewModel : INotifyPropertyChanged, IAutoSave
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
                    Save();
                }
            }
        }

        public string DisplayText
        {
            get
            {
                if (fIsPassiveHolder.IsPassive)
                    return "Passive";
                return String.Empty;
            }
        }

        public DataOperationProvider DataOperationProvider => new DataOperationProvider();

        public IsPassiveHolderViewModel(IsPassiveHolder aIDHolder)
        {
            fIsPassiveHolder = aIDHolder;
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
