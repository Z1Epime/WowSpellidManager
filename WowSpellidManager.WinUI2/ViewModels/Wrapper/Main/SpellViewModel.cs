﻿using System;
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
using WowSpellidManager.WinUI2.ViewModels.Wrapper.Core;

namespace WowSpellidManager.ViewModels.Wrapper.Main
{
    public class SpellViewModel
    {
        public IDHolder IDHolder { get; set; }

        public GuidHolder GuidHolder { get; set; }

        public DesignationHolder DesignationHolder { get; set; }

        public AdditionalInfoHolder AdditionalInfoHolder { get; set; }

        public ResourceViewModel CostViewModel { get; set; }

        public CooldownViewModel CooldownViewModel { get; set; }

        public ChargesHolder ChargesHolder { get; set; }

        public RangeViewModel RangeViewModel { get; set; }

        public ToolTipTextHolder ToolTipTextHolder { get; set; }

        public CastViewModel CastViewModel { get; set; }

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
                if (CooldownViewModel.Number > 0)
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
                    CooldownViewModel.Number = 0;
                }
                else
                {
                    //Cooldown.NotifyPropertyChanged("Number");
                    CooldownViewModel.Number = 1;
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