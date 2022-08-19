using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TwilioWeb.Models;

namespace TwilioWeb.Data
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        { }

        public DbSet<messages> messagess { get; set; }
        public DbSet<sentmessages> sentmessagess { get; set; }
        public DbSet<TwilioCredentials> twilioCredentials { get; set; }

    }
}
