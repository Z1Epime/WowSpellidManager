using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using WowSpellidManager.Domain.Models;

namespace WowSpellidManager.ViewModels.Wrapper
{
    public class SpecializationViewModel
    {
        public Specialization Specialization;

        public string Description
        {
            get
            {
                return Specialization.Description;
            }
            set
            {
                Specialization.Description = value;
            }
        }

        public ObservableCollection<Spell> Spells
        {
            get
            {
                return Specialization.Spells;
            }
            set
            {
                Specialization.Spells = value;
            }
        }

        public Guid Guid
        {
            get
            {
                return Specialization.Guid;
            }
            set
            {
                Specialization.Guid = value;
            }
        }

        public string Designation
        {
            get
            {
                return new ResourceLoader().GetString(Specialization.Designation);
            }
            set
            {
                Specialization.Designation = value;
            }
        }

        public SpecializationViewModel(object aSpecialization)
        {
            Specialization = aSpecialization as Specialization;
        }

        private ObservableCollection<SpellViewModel> WrapSpells(ObservableCollection<Spell> aSpells)
        {
            var list = new ObservableCollection<SpellViewModel>();
            foreach (var spell in aSpells)
            {
                list.Add(new SpellViewModel(spell));
            }
            return list;
        }

        private ObservableCollection<Spell> UnwrapSpells(ObservableCollection<SpellViewModel> aSpellViewModels)
        {
            var list = new ObservableCollection<Spell>();
            foreach (var spellViewModel in aSpellViewModels)
            {
                list.Add(spellViewModel.Spell);
            }
            return list;
        }
    }
}
