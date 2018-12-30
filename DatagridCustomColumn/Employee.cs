using System;
using System.Collections.Generic;

namespace DatagridCustomColumn
{
    public class Employee
    {
        public Employee() { }
        public Employee(string firstName, string lastName, string email, bool isActive, DateTime dateOfBirth, DateTime dateAccepted, string country, string url, List<string> technologies)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            IsActive = isActive;
            DateOfBirth = dateOfBirth;
            DateAccepted = dateAccepted;
            Country = country;
            Url = url;
            Technologies = technologies;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateAccepted { get; set; }
        public string Country { get; set; }
        public string Url { get; set; }
        public List<string> Technologies { get; set; } = new List<string>();
    }
}
