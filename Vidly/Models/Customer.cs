using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }


        // This is a nav property
        public MembershipType MembershipType { get; set; }


        // Entity Framework recognizes this convention
        public byte MembershipTypeId { get; set; }
    
    }
}
