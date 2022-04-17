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
using WowSpellidManager.Domain.Models.Spells;

namespace WowSpellidManager.ViewModels.Wrapper
{
    public class SpellViewModel
    {
        public string ID { get; set; }

        public Guid Guid { get; set; }

        public string Designation { get; set; }

#nullable enable
        public string? AdditionalInfo { get; set; }

        public Resource? Cost { get; set; }

        public Cooldown? Cooldown { get; set; }

        public int? Charges { get; set; }

        public Domain.Models.Spells.Range? Range { get; set; }
#nullable disable
        public string ToolTipText { get; set; }

        public Cast Cast { get; set; }

        public bool IsTalent { get; set; }
        
        public bool IsPvPTalent { get; set; }

        public bool IsPassive { get; set; }
    }
}
