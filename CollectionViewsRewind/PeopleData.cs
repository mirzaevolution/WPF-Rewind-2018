using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace CollectionViewsRewind
{
    public class PeopleData
    {
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>
        {
            new Person { FirstName="Bob", LastName="Green", Age=41, Gender="Male" },
            new Person { FirstName="Sue", LastName="Brown", Age=25, Gender="Female" },
            new Person { FirstName="Jim", LastName="White", Age=31, Gender="Male" },
            new Person { FirstName="Mel", LastName="Black", Age=18, Gender="Female" },
            new Person { FirstName="Jen", LastName="Smith", Age=31, Gender="Female" },
            new Person { FirstName="Tim", LastName="Jones", Age=64, Gender="Male" }
        };
    }
}
