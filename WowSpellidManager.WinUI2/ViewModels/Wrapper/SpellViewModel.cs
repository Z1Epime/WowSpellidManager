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
using WowSpellidManager.DomainUWP.Models.Helper;
using WowSpellidManager.DomainUWP.Models.Spells;
using WowSpellidManager.Infrastructure.CRUD;

namespace WowSpellidManager.ViewModels.Wrapper
{
    public class SpellViewModel
    {
        public IDHolder ID { get; set; }

        public Guid Guid { get; set; }

        public DesignationHolder Designation { get; set; }

#nullable enable
        public string? AdditionalInfo { get; set; }

        public Resource? Cost { get; set; }

        public Cooldown? Cooldown { get; set; }

        public int? Charges { get; set; }

        public Domain.Models.Spells.Range? Range { get; set; }
#nullable disable
        public string ToolTipText { get; set; }

        public Cast Cast { get; set; }

        public Availability Availability { get; set; }

        public bool IsPassive { get; set; }



        public IEnumerable<TimeUnit> TimeUnitValues
        {
            get
            {
                return Enum.GetValues(typeof(TimeUnit))
                    .Cast<TimeUnit>();
            }
        }

        private bool fHasCooldown;

        
        public bool HasCooldown
        {
            get
            {
                if (Cooldown.Number > 0)
                {
                    fHasCooldown = true;
                }
                else
                {
                    fHasCooldown = false;
                }
                return fHasCooldown;
            }

            set
            {
                //if (value == true)
                //{
                //    //if(Cooldown != null)  
                //    Cooldown = new Cooldown();
                //}
                //else
                //{
                //    //if(Cooldown != null)
                //    Cooldown = null;
                //}

                //fIsCooldownNotNull = value;
                if (value == false)
                {
                    //Cooldown.NotifyPropertyChanged("Number");
                    Cooldown.Number = 0;
                }
                else
                {
                    //Cooldown.NotifyPropertyChanged("Number");
                    Cooldown.Number = 1;
                }

                fHasCooldown = value;
            }
        }

        //private Cooldown GetCooldown(Guid aSpellGuid)
        //{
        //    return new DataOperationProvider().SpellOperator.GetSpell(aSpellGuid).Cooldown;
        //}


    }
}
