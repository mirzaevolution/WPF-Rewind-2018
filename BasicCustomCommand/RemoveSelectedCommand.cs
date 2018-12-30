using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace BasicCustomCommand
{
    public class RemoveSelectedCommand : ICommand
    {
        private NameList _nameList;
        public RemoveSelectedCommand() { }
        public RemoveSelectedCommand(NameList list, object canRemoveSelected)
        {
            _nameList = list;
        }
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
            var list = (parameter as IList);
            return list != null && list.Count > 0;
            
        }

        public void Execute(object parameter)
        {
            if(parameter is IList listParam)
            {
                if (_nameList != null)
                {
                    for(int i = 0; i < listParam.Count; i++)
                    {
                        _nameList.Names.Remove((string)listParam[i]);
                        i--;
                    }
                }
            }
        }
    }
}
