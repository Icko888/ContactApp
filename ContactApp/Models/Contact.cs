using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactApp.Models
{
   
    public class Contact
    {
        [Required]
        [MinLength(3),MaxLength(25)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3), MaxLength(25)]
        public string LastName { get; set; }

        [Required]
        public bool IsCloseFriend { get; set; }

        [Required]
        [Range(10000000,99999999999)]
        public long PhoneNumber { get; set; }

        public Contact()
        {
                
        }

        public Contact(string firstName, string lastName, bool isCloseFriend, int phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            IsCloseFriend = isCloseFriend;
            PhoneNumber = phoneNumber;
        }
    }
}
