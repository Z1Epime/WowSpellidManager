using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;

namespace WowSpellidManager.Infrastructure
{
    public class Holder : INotifyCollectionChanged
    {
        private ObservableCollection<Spell> fSpells;
        public ObservableCollection<Spell> Spells
        {
            get 
            { 
                if(fSpells == null)
                {
                    fSpells = new ObservableCollection<Spell>();
                }
                return fSpells; 
            }
            set 
            {   if(value != null)
                { 
                    fSpells = value; 
                }
            }
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public virtual void OnCollectionChange(NotifyCollectionChangedEventArgs e)
        {
            if (CollectionChanged != null)
                CollectionChanged(this, e);
        }


    }
}
