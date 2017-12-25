using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressBookApp.Models;
using Microsoft.Data.OData.Atom;

namespace AddressBookApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Looking for any persons.

            if (context.Peoples.Any())
            {
                return; //DB has seeded
            }

            var peoples = new People[]
            {
                new People
                {
                    FirstName = "Rajib",
                    LastName = "Bhowmik",
                    PersonNumber = "19851220-3053"
                },

                new People
                {
                    FirstName = "Shathi",
                    LastName = "Bhowmik",
                    PersonNumber = "19870405-2569"
                }
            };

            foreach (People p in peoples)
            {
                context.Peoples.Add(p);
            }
            context.SaveChanges();

            var addresses = new Address[]
                {
                 new Address
                 {
                     StreetName = "Bandstolsvägen",
                     HouseNumber = 49,
                     PostalCode = 75648,
                     City = "Uppsala",
                     CountryName = "Sweden"
                 },

                    new Address
                    {
                        StreetName = "Linrepevägen",
                        HouseNumber = 4,
                        PostalCode = 75548,
                        City = "Uppsala",
                        CountryName = "Sweden"
                    }
                };

            foreach (Address a in addresses )
            {
                context.Addresses.Add(a);
            }
            context.SaveChanges();
        }
    }
}
