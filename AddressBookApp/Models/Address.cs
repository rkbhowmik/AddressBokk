using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.OData.Atom;

namespace AddressBookApp.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }

        public int PostalCode { get; set; }
        public string City { get; set; }
        public string CountryName { get; set; }

        public int PeopleID { get; set; }
        public People Peoples { get; set; }

    }
}
