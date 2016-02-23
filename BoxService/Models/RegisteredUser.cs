﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BoxService.Models
{
    public class RegisteredUser
    {
        public int ID { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ShippingAddress { get; set; }
        public string Gender { get; set; }
    }

    public class RegisteredUserDbContext : DbContext
    {
        public DbSet<RegisteredUser> RegisteredUsers { get; set; }
    }
}