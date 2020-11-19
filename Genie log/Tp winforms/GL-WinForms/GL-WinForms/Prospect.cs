using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GL_WinForms
{
    public class Prospect
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public DateTime LastContact { get; set; }
        public string LastName { get; set; }
        public string Notes { get; set; }


        public Prospect() { }

        public Prospect(string lastName, string firstName, string email, DateTime lastContact)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            LastContact = lastContact;
        }

        public Prospect(string lastName, string firstName, string email, DateTime lastContact, string notes)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            LastContact = lastContact;
            Notes = notes;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}
