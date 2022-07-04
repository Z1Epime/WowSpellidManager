using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WowSpellidManager.DomainUWP.Models.Helper;
using WowSpellidManager.Infrastructure.CRUD;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Holder
{
    public class IDHolderViewModel : INotifyPropertyChanged, IAutoSave
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
                    Save();
                }
            }
        }

        public DataOperationProvider DataOperationProvider => new DataOperationProvider();

        public IDHolderViewModel(IDHolder aIDHolder)
        {
            fIDHolder = aIDHolder;
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
