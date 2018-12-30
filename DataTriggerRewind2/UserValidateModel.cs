using System.ComponentModel;

namespace DataTriggerRewind2
{
    public class UserValidateModel : INotifyPropertyChanged
    {
        private string _employeeId="", _email="";
        public string EmployeeID
        {
            get
            {
                return _employeeId;
            }
            set
            {
                if (_employeeId != value)
                {
                    _employeeId = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EmployeeID)));
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
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
