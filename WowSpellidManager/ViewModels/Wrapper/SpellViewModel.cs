using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using WowSpellidManager.Domain.Models;

namespace WowSpellidManager.ViewModels.Wrapper
{
    public class SpellViewModel
    {
        public Spell Spell { get; set; }
        public string Description
        {
            get
            {
                return Spell.Description;
            }
            set
            {
                Spell.Description = value;
            }
        }
        public string ID
        {
            get
            {
                return Spell.ID;
            }
            set
            {
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
                Spell.Designation = value;
            }
        }

        public SpellViewModel(Spell aSpell)
        {
            Spell = aSpell;
        }
    }
}
