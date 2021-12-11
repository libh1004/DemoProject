using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoProject.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=MyConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}