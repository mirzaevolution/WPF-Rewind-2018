using System.ComponentModel;
namespace MultiBinding2
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstName, _lastName, _middleName;
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
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
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
                if(_lastName != value)
                {
                    _lastName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
                }
            }
        }
        public string MiddleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                if (_middleName != value)
                {
                    _middleName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MiddleName)));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
