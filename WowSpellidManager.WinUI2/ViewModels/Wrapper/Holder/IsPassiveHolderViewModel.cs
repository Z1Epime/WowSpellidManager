﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
