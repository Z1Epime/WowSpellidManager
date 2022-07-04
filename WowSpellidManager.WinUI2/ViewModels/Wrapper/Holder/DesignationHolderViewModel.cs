using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WowSpellidManager.DomainUWP.Models.Helper;
using WowSpellidManager.Infrastructure.CRUD;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Holder
{
    public class DesignationHolderViewModel : INotifyPropertyChanged, IAutoSave
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
                    Save();
                }
            }
        }

        public DataOperationProvider DataOperationProvider => new DataOperationProvider();

        public DesignationHolderViewModel(DesignationHolder aDesignationHolder)
        {
            fDesignationHolder = aDesignationHolder;
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
