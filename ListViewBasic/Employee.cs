using System.ComponentModel;

namespace ListViewBasic
{
    public class Employee:INotifyPropertyChanged
    {
        private string _firstName, _lastName, _email, _department;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(FirstName)));
                }
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
                }
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
                }
            }
        }
        public string Department
        {
            get
            {
                return _department;
            }
            set
            {
                if (_department != value)
                {
                    _department = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Department)));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
