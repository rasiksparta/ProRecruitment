using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProRecruiter.Models
{
    public class Client
    {
        private string name, address, contactInfo, email;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string ContactInfo { get => contactInfo; set => contactInfo = value; }
        public string Email { get => email; set => email = value; }
    }
}