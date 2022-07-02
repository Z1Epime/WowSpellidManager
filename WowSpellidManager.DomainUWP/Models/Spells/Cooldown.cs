using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WowSpellidManager.DomainUWP.Models.Spells;

namespace WowSpellidManager.Domain.Models.Spells
{
    /// <summary>
    /// This class represents the cooldown of a spell in World of Warcraft. <br></br>
    /// For simplification purposes this class does not inherit from Entity. Note that this class does not have a GUID.
    /// </summary>
    public class Cooldown : INotifyPropertyChanged
    {
        #region Fields
        private double fNumber;
        private TimeUnit fUnit;
        #endregion;

        #region Properties
        /// <summary>
        /// The number part of the cooldown.
        /// </summary>
        public double Number
        {
            get
            {
                return fNumber;
            }

            set
            {
                fNumber = value;
                NotifyPropertyChanged("Number");              
            }
        }

        /// <summary>
        /// The specified unit of the cooldown (minutes, seconds, hours etc.).
        /// </summary>
        public TimeUnit Unit
        {
            get
            {
                return fUnit;
            }

            set
            {
                if (fUnit != value)
                {
                    fUnit = value;
                    NotifyPropertyChanged();
                }
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// The main constructor to create a new instance of the Cooldown class with.
        /// </summary>
        /// <param name="aNumber"></param>
        /// <param name="aUnit"></param>
        public Cooldown(double aNumber, TimeUnit aUnit)
        {
            fNumber = aNumber;
            fUnit = aUnit;
        }

        /// <summary>
        /// For json deserializing only.
        /// </summary>
        public Cooldown()
        {

        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
