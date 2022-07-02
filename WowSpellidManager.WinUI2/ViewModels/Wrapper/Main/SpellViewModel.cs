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

namespace WowSpellidManager.ViewModels.Wrapper.Main
{
    public class SpellViewModel
    {
        public IDHolder IDHolder { get; set; }

        public GuidHolder GuidHolder { get; set; }

        public DesignationHolder DesignationHolder { get; set; }

#nullable enable
        public AdditionalInfoHolder? AdditionalInfoHolder { get; set; }

        public Resource? Cost { get; set; }

        public Cooldown? Cooldown { get; set; }

        public ChargesHolder? ChargesHolder { get; set; }

        public Range? Range { get; set; }
#nullable disable
        public ToolTipTextHolder ToolTipTextHolder { get; set; }

        public Cast Cast { get; set; }

        public AvailabilityHolder AvailabilityHolder { get; set; }

        public IsPassiveHolder IsPassiveHolder { get; set; }



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
