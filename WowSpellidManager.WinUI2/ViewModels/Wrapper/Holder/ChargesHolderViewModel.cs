﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.DomainUWP.Models.Helper;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Holder
{
    public class ChargesHolderViewModel : INotifyPropertyChanged
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
                }
            }
        }

        public ChargesHolderViewModel(ChargesHolder aChargesHolder)
        {
            fChargesHolder = aChargesHolder;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}