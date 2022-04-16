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
        public string Description { get; set; }

        public string ID { get; set; }

        public Guid Guid { get; set; }

        public string Designation { get; set; }
    }
}
