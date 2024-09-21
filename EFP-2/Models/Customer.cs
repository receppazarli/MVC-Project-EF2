﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFP_2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}