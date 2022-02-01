using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;

namespace WowSpellidManager.WinUI3.ViewModels.Wrapper
{
    internal class WowClassViewModel : ViewModel, INotifyPropertyChanged
    {
        public WowClass WowClass;

        public string Description
        {
            get
            {
                return WowClass.Description;
            }
            set
            {
                NotifyPropertyChanged();
                WowClass.Description = value;
            }
        }

        public List<Specialization> Specializations
        {
            get
            {
                return WowClass.Specializations;
            }
            set
            {
                NotifyPropertyChanged();
                WowClass.Specializations = value;
            }
        }

        public Guid Guid
        {
            get
            {
                return WowClass.Guid;
            }
            set
            {
                NotifyPropertyChanged();
                WowClass.Guid = value;
            }
        }

        public string Designation
        {
            get
            {
                return WowClass.Designation;
            }
            set
            {
                NotifyPropertyChanged();
                WowClass.Designation = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
