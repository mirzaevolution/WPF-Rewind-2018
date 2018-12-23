using System.ComponentModel;

namespace DataContextRewind
{
    public class PersonalDetail:INotifyPropertyChanged
    {
        private string _firstName, _lastName;
        private int _age = 23;
        private static object _lock = new object();
        private static PersonalDetail _personalDetail;

        public event PropertyChangedEventHandler PropertyChanged;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
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
                _lastName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Age)));
            }
        }
        public static PersonalDetail GetDetail()
        {
            lock (_lock)
            {
                if (_personalDetail == null)
                    _personalDetail = new PersonalDetail();
            }
            return _personalDetail;
        }
    }
}
