using System.Collections.ObjectModel;
using System.ComponentModel;
namespace DataTemplates
{
    public class ContactList : INotifyPropertyChanged
    {
        private ContactDetails _editableContact = new ContactDetails();
        public ObservableCollection<ContactDetails> Contacts { get; set; } = new ObservableCollection<ContactDetails>();
        public ContactDetails EditableContact
        {
            get
            {
                return _editableContact;
            }
            set
            {
                _editableContact = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(EditableContact)));
            }
        } 
        public void AddEditableContact()
        {
            Contacts.Add(EditableContact);
            EditableContact = new ContactDetails();
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
