using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Demo.Shared.Util
{
    public class ValidatableViewModelBase : ViewModelBase, INotifyDataErrorInfo
    {
        private static readonly string[] NO_ERRORS = new string[0];

        private Dictionary<string, List<string>> _errorsByPropertyName = new Dictionary<string, List<string>>();

        /// <inheritdoc />
        public virtual IEnumerable GetErrors(string propertyName)
        {
            if (_errorsByPropertyName.TryGetValue(propertyName, out var errorList))
            {
                return errorList;
            }
            return NO_ERRORS;
        }

        /// <inheritdoc />
        public bool HasErrors => _errorsByPropertyName.Count > 0;

        /// <inheritdoc />
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        protected virtual void SetError(string error, [CallerMemberName] string propertyName = "")
        {
            if (_errorsByPropertyName.TryGetValue(propertyName, out var errorList))
            {
                if (!errorList.Contains(error))
                {
                    errorList.Add(error);
                }
            }
            else
            {
                _errorsByPropertyName.Add(propertyName, new List<string>{ error });
            }

            this.ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        protected virtual void RemoveErrors([CallerMemberName] string propertyName = "")
        {
            if (_errorsByPropertyName.ContainsKey(propertyName))
            {
                _errorsByPropertyName.Remove(propertyName);
                this.ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            }
        }
    }
}
