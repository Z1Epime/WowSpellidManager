using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;

namespace WowSpellidManager.Infrastructure.ViewModels.Wrapper
{
    internal class WowClassViewModel : ViewModel, INotifyPropertyChanged
    {
        private WowClass fWowClass;

        public string Description
        {
            get
            {
                return fWowClass.Description;
            }
            set
            {
                NotifyPropertyChanged();
                fWowClass.Description = value;
            }
        }

        public Specialization[] Specializations
        {
            get
            {
                return fWowClass.Specializations;
            }
            set
            {
                NotifyPropertyChanged();
                fWowClass.Specializations = value;
            }
        }

        public Guid Guid
        {
            get
            {
                return fWowClass.Guid;
            }
            set
            {
                NotifyPropertyChanged();
                fWowClass.Guid = value;
            }
        }

        public string Designation
        {
            get
            {
                return fWowClass.Designation;
            }
            set
            {
                NotifyPropertyChanged();
                fWowClass.Designation = value;
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
