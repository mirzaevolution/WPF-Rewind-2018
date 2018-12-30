using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace BasicCustomCommand
{
    public class RemoveCommand : ICommand
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
            if(parameter is NameList list)
            {
                return list.SelectedName != null;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            if(parameter is NameList list)
            {
                list.Names.Remove(list.SelectedName);
            }
        }
    }
}
