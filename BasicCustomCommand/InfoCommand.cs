using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BasicCustomCommand
{
    public class InfoCommand : ICommand
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
            return parameter != null;
        }

        public void Execute(object parameter)
        {
            if(!string.IsNullOrEmpty((string)parameter))
            {
                MessageBox.Show(parameter.ToString());
            }
        }
    }
}
