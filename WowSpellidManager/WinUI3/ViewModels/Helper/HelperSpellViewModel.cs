using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.Domain.Models;
using WowSpellidManager.WinUI3.ViewModels.Wrapper;

namespace WowSpellidManager.WinUI3.ViewModels.Helper
{
    public class HelperSpellViewModel : ViewModel
    {
        

        public ObservableCollection<SpellViewModel> GetSpells2()
        {
            ObservableCollection<SpellViewModel> spellViewModels = new ObservableCollection<SpellViewModel>();

            foreach(var spell in fDataOperationProvider.SpellOperator.GetSpells())
            {
                SpellViewModel spellViewModel = new SpellViewModel();
                spellViewModel.Spell = spell;
                spellViewModels.Add(spellViewModel);
            }

            return spellViewModels;
        }

        public ObservableCollection<Spell> GetSpells()
        {
            return fDataOperationProvider.SpellOperator.GetSpells();
        }


        public void AddSpell(string aDesignation, string aDescription, string aID)
        {
            fDataOperationProvider.SpellOperator.AddSpell(new Spell(aDesignation, aDescription, Convert.ToInt32(aID)));
        }

        public void SaveSpells()
        {
            fDataOperationProvider.SpellOperator.Save();
        }

    }
}