using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookApp.Models
{
    public class People
    {
        public int  PeopleID { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your social security number.")]

       public string PersonNumber { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
