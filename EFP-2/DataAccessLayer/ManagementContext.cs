using EFP_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFP_2.DataAccessLayer
{
    public class ManagementContext : DbContext
    {
        public ManagementContext() : base("ManagementDatabase") { }

        public DbSet<Customer> Customers { get; set; }


    }
}