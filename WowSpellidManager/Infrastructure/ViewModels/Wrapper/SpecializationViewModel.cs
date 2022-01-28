using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;

namespace WowSpellidManager.Infrastructure.ViewModels.Wrapper
{
    internal class SpecializationViewModel : ViewModel, INotifyPropertyChanged
    {
        private Specialization fSpecialization;

        public string Description
        {
            get
            {
                return fSpecialization.Description;
            }
            set
            {
                NotifyPropertyChanged();
                fSpecialization.Description = value;
            }
        }

        public ObservableCollection<Spell> Spells
        {
            get
            {
                return fSpecialization.Spells;
            }
            set
            {
                NotifyPropertyChanged();
                fSpecialization.Spells = value;
            }
        }

        public Guid Guid
        {
            get
            {
                return fSpecialization.Guid;
            }
            set
            {
                NotifyPropertyChanged();
                fSpecialization.Guid = value;
            }
        }

        public string Designation
        {
            get
            {
                return fSpecialization.Designation;
            }
            set
            {
                NotifyPropertyChanged();
                fSpecialization.Designation = value;
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
