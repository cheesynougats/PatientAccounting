using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public StateName State { get; set; }
        public string PostalCode { get; set; }
    }
}
