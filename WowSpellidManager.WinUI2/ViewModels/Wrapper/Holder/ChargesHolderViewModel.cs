using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WowSpellidManager.DomainUWP.Models.Helper;
using WowSpellidManager.Infrastructure.CRUD;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Holder
{
    public class ChargesHolderViewModel : INotifyPropertyChanged, IAutoSave
    {
        private ChargesHolder fChargesHolder;

        public int Charges
        {
            get
            {
                return fChargesHolder.Charges;
            }
            set
            {
                if (fChargesHolder.Charges != value)
                {
                    fChargesHolder.Charges = value;
                    NotifyPropertyChanged();
                    Save();
                }
            }
        }

        private bool fHasCharges;
        public bool HasCharges
        {
            get
            {
                if (Charges > 1)
                    fHasCharges = true;
                else
                    fHasCharges = false;
                return fHasCharges;
            }

            set
            {
                if (value == false)
                    Charges = 1;
                else
                    Charges = 2;
                fHasCharges = value;
                Save();
            }
        }

        public DataOperationProvider DataOperationProvider => new DataOperationProvider();

        public ChargesHolderViewModel(ChargesHolder aChargesHolder)
        {
            fChargesHolder = aChargesHolder;
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
