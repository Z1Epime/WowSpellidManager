using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;

namespace WowSpellidManager.Infrastructure.ViewModels.Wrapper
{
    public class SpellViewModel : ViewModel, INotifyPropertyChanged
    {
        private Spell fSpell;

        public string Description
        {
            get
            {
                return fSpell.Description;
            }
            set
            {
                NotifyPropertyChanged();
                fSpell.Description = value;
            }
        }
        public int ID
        {
            get
            {
                return fSpell.ID;
            }
            set
            {
                NotifyPropertyChanged();
                fSpell.ID = value;
            }
        }

        public Guid Guid
        {
            get
            {
                return fSpell.Guid;
            }
            set
            {
                NotifyPropertyChanged();
                fSpell.Guid = value;
            }
        }

        public string Designation
        {
            get
            {
                return fSpell.Designation;
            }
            set
            {
                NotifyPropertyChanged();
                fSpell.Designation = value;
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
