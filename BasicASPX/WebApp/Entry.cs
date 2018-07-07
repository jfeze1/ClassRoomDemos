using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class Entry
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string EmailAddress { get; set; }

        public Entry()
        {

        }

        public Entry(string firstName,
                     string lastName,
                     string streetAddress1,
                     string streetAddress2,
                     string city,
                     string province,
                     string postalCode,
                     string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            StreetAddress1 = streetAddress1;
            StreetAddress1 = streetAddress2;
            City = city;
            Province = province;
            PostalCode = postalCode;
            EmailAddress = emailAddress;


        }
    }
   
}