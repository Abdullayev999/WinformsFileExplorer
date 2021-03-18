using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Model
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public bool Favorite { get; set; }
        public string Avatar { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
