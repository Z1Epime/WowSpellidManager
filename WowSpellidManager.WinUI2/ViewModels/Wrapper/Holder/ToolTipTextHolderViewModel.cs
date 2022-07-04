using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WowSpellidManager.DomainUWP.Models.Helper;

namespace WowSpellidManager.WinUI2.ViewModels.Wrapper.Holder
{
    public class ToolTipTextHolderViewModel : INotifyPropertyChanged
    {
        private ToolTipTextHolder fToolTipTextHolder;

        public string ToolTipText
        {
            get
            {
                return fToolTipTextHolder.ToolTipText;
            }
            set
            {
                if (fToolTipTextHolder.ToolTipText != value)
                {
                    fToolTipTextHolder.ToolTipText = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ToolTipTextHolderViewModel(ToolTipTextHolder aToolTipTextHolder)
        {
            fToolTipTextHolder = aToolTipTextHolder;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
