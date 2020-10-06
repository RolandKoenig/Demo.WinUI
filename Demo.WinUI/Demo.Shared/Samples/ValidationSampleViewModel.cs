using System;
using System.Collections.Generic;
using System.Text;
using Demo.Shared.Util;

namespace Demo.Shared.Samples
{
    public class ValidationSampleViewModel : ValidatableViewModelBase
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _likes;
        private int _carsCount;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    this.RaisePropertyChanged();

                    if (string.IsNullOrEmpty(_firstName)) { this.SetError("FirstName is required!"); }
                    else { this.RemoveErrors(); }
                }
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    this.RaisePropertyChanged();

                    if (string.IsNullOrEmpty(_lastName)) { this.SetError("LastName is required!"); }
                    else { this.RemoveErrors(); }
                }
            }
        }

        public string Likes
        {
            get => _likes;
            set
            {
                if(_likes != value)
                {
                    _likes = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        public int CarsCount
        {
            get => _carsCount;
            set
            {
                if(_carsCount != value)
                {
                    _carsCount = value;
                    this.RaisePropertyChanged();
                }
            }
        }
    }
}
