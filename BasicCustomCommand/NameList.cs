using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Collections;
using System;
using System.Windows;

namespace BasicCustomCommand
{
    public class NameList : INotifyPropertyChanged
    {
        private string _firstName, _lastName, _selectedName;

        #region Old Private Codes
        //private ICommand _infoCommand = new InfoCommand();
        //private ICommand _addCommand = new AddCommand();
        //private ICommand _removeCommand = new RemoveCommand();
        //private ICommand _removeSelectedCommand;
        #endregion

        public NameList()
        {
            //_removeSelectedCommand = new RemoveSelectedCommand(this);
            AddCommand = new RelayCommand<NameList>(AddAction, CanAdd);
            RemoveCommand = new RelayCommand<NameList>(RemoveAction, CanRemove);
            RemoveSelectedCommand = new RelayCommand<IList>(RemoveSelectedAction, CanRemoveSelected);
            InfoCommand = new RelayCommand<string>(InfoAction, CanInfo);
        }

        

        private bool CanInfo(string arg)
        {
            return !string.IsNullOrEmpty(arg);
        }
        private void InfoAction(string obj)
        {
            if (!string.IsNullOrEmpty((string)obj))
            {
                MessageBox.Show(obj.ToString());
            }
        }

        private bool CanRemoveSelected(IList arg)
        {
            return arg != null && arg.Count > 0;
        }
        private void RemoveSelectedAction(IList obj)
        {
            if (obj != null)
            {

                for (int i = 0; i < obj.Count; i++)
                {
                    this.Names.Remove((string)obj[i]);
                    i--;
                }
            }
        }

        private bool CanRemove(NameList arg)
        {
            return arg != null && !string.IsNullOrEmpty(arg.SelectedName);
        }
        private void RemoveAction(NameList obj)
        {
            if (obj != null)
            {
                obj.Names.Remove(obj.SelectedName);
            }
        }

        private bool CanAdd(NameList arg)
        {
            return arg != null &&
                    !string.IsNullOrEmpty(arg.FirstName) &&
                    !string.IsNullOrEmpty(arg.LastName);
        }
        private void AddAction(NameList obj)
        {
            if (obj != null)
            {
                obj.Names.Add($"{obj.FirstName} {obj.LastName}".Trim());
                obj.FirstName = obj.LastName = "";
            }
        }

        public RelayCommand<NameList> AddCommand { get; private set; }
        public RelayCommand<NameList> RemoveCommand { get; private set; }
        public RelayCommand<IList> RemoveSelectedCommand { get; private set; }
        public RelayCommand<string> InfoCommand { get; private set; }
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
                if (_lastName != value)
                {
                    _lastName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
                }
            }
        }
        public string SelectedName
        {
            get
            {
                return _selectedName;
            }
            set
            {
                if(_selectedName != value)
                {
                    _selectedName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedName)));
                }
            }
        }
        public ObservableCollection<string> Names { get; set; } =
            new ObservableCollection<string>();

        #region Old Public Codes
        //public ICommand InfoCommand
        //{
        //    get
        //    {
        //        return _infoCommand;
        //    }
        //}
        //public ICommand AddCommand
        //{
        //    get
        //    {
        //        return _addCommand;
        //    }
        //}
        //public ICommand RemoveCommand
        //{
        //    get
        //    {
        //        return _removeCommand;
        //    }
        //}
        //public ICommand RemoveSelectedCommand
        //{
        //    get
        //    {
        //        return _removeSelectedCommand;
        //    }
        //}
        #endregion
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

