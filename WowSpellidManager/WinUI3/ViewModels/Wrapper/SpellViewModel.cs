using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;

namespace WowSpellidManager.WinUI3.ViewModels.Wrapper
{
    public class SpellViewModel : ViewModel, INotifyPropertyChanged
    {
        public Spell Spell;

        public string Description
        {
            get
            {
                return Spell.Description;
            }
            set
            {
                NotifyPropertyChanged();
                Spell.Description = value;
            }
        }
        public int ID
        {
            get
            {
                return Spell.ID;
            }
            set
            {
                NotifyPropertyChanged();
                Spell.ID = value;
            }
        }

        public Guid Guid
        {
            get
            {
                return Spell.Guid;
            }
            set
            {
                NotifyPropertyChanged();
                Spell.Guid = value;
            }
        }

        public string Designation
        {
            get
            {
                return Spell.Designation;
            }
            set
            {
                NotifyPropertyChanged();
                Spell.Designation = value;
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
