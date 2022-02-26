//using Microsoft.Toolkit.Mvvm.ComponentModel;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Collections.Specialized;
//using System.ComponentModel;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;
//using WowSpellidManager.Domain.Models;

//namespace WowSpellidManager.WinUI3.ViewModels.Wrapper
//{
//    public class SpellViewModel : INotifyDataErrorInfo
//    {
//        private readonly Dictionary<string, List<string>> _errorsByPropertyName = new Dictionary<string, List<string>>();

//        public Spell Spell;

//        public string Description
//        {
//            get
//            {
//                return Spell.Description;
//            }
//            set
//            {
//                Spell.Description = value;
//            }
//        }
//        public int ID
//        {
//            get
//            {
//                return Spell.ID;
//            }
//            set
//            {
//                ValidateID();
//                Spell.ID = value;
//            }
//        }

//        public Guid Guid
//        {
//            get
//            {
//                return Spell.Guid;
//            }
//            set
//            {
//                Spell.Guid = value;
//            }
//        }

//        public string Designation
//        {
//            get
//            {
//                return Spell.Designation;
//            }
//            set
//            {
//                Spell.Designation = value;
//            }
//        }

//        public bool HasErrors => throw new NotImplementedException();

//        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

//        public IEnumerable GetErrors(string propertyName)
//        {
//            throw new NotImplementedException();
//        }

//        private void ValidateID()
//        {
//            ClearErrors(nameof(ID));
//            if (string.IsNullOrWhiteSpace(ID.ToString()))
//                AddError(nameof(ID), "ID cannot be empty.");
//            if (char.IsLetter(Convert.ToChar(ID)))
//                AddError(nameof(ID), "ID cannot have letters.");
//        }


//        private void AddError(string propertyName, string error)
//        {
//            if (!_errorsByPropertyName.ContainsKey(propertyName))
//                _errorsByPropertyName[propertyName] = new List<string>();

//            if (!_errorsByPropertyName[propertyName].Contains(error))
//            {
//                _errorsByPropertyName[propertyName].Add(error);
//                OnErrorsChanged(propertyName);
//            }
//        }

//        private void ClearErrors(string propertyName)
//        {
//            if (_errorsByPropertyName.ContainsKey(propertyName))
//            {
//                _errorsByPropertyName.Remove(propertyName);
//                OnErrorsChanged(propertyName);
//            }
//        }

//    }
//}
