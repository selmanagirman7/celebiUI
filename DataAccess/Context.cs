using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Context : DbContext
    {
        public DbSet<About> Abouts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Corporate> Corporates { get; set; }

        public DbSet<Galery> Galeries { get; set; }

        public DbSet<HomeAbout> HomeAbouts { get; set; }

        public DbSet<OurService> OurServices { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Referance> Referances { get; set; }
        public DbSet<Slider> Sliders { get; set; }


        //user id = sa; password=CRy5RcSGe526aS;                                                                                                                                                                                                                                                                                                         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder. UseSqlServer(@"Server=193.53.87.166;Database=CelebiHırdavatDb;user id = sa;  password=CRy5RcSGe526aS; Trusted_Connection=false");
        }
    }
}
