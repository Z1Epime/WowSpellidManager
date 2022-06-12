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
        public ObservableCollection<SpellViewModel> Spells { get; set; }

        public Guid Guid { get; set; }

        public string Designation { get; set; }

        public string Image { get; set; }
    }
}
