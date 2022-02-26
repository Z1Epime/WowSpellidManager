//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.ComponentModel;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;
//using WowSpellidManager.Domain.Models;

//namespace WowSpellidManager.WinUI3.ViewModels.Wrapper
//{
//    internal class SpecializationViewModel : ViewModel, INotifyPropertyChanged
//    {
//        public Specialization Specialization;

//        public string Description
//        {
//            get
//            {
//                return Specialization.Description;
//            }
//            set
//            {
//                NotifyPropertyChanged();
//                Specialization.Description = value;
//            }
//        }

//        public ObservableCollection<Spell> Spells
//        {
//            get
//            {
//                return Specialization.Spells;
//            }
//            set
//            {
//                NotifyPropertyChanged();
//                Specialization.Spells = value;
//            }
//        }

//        public Guid Guid
//        {
//            get
//            {
//                return Specialization.Guid;
//            }
//            set
//            {
//                NotifyPropertyChanged();
//                Specialization.Guid = value;
//            }
//        }

//        public string Designation
//        {
//            get
//            {
//                return Specialization.Designation;
//            }
//            set
//            {
//                NotifyPropertyChanged();
//                Specialization.Designation = value;
//            }
//        }


//        public event PropertyChangedEventHandler PropertyChanged;
//        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
//        {
//            if (PropertyChanged != null)
//            {
//                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
//            }
//        }

//    }
//}
