using System;
using System.Windows.Input;
namespace BasicCustomCommand
{
    public class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            
            if (parameter is NameList list)
            {
                if (!string.IsNullOrEmpty(list.FirstName) && !string.IsNullOrEmpty(list.LastName))
                    return true;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            if (parameter is NameList list)
            {
                list.Names.Add($"{list.FirstName} {list.LastName}".Trim());
                list.FirstName = list.LastName = "";
            }
        }
    }
}
