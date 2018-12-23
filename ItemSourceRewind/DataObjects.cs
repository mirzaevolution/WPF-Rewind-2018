using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemSourceRewind
{
    public class DataObjects
    {
        public ObservableCollection<string> ListOfItems { get; set; } = new ObservableCollection<string>
        {
            "One","Two","Three"
        };
    }
}
