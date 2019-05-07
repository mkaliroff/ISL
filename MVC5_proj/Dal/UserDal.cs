using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVC5_proj.Models;

namespace MVC5_proj.Dal
{
    public class UserDal : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Contact>().ToTable("Contact");
            modelBuilder.Entity<Language>().ToTable("Language");
            modelBuilder.Entity<IT>().ToTable("IT");
            modelBuilder.Entity<Admin>().ToTable("Admin");


        }

        //property Collection  that returns us Dbset of obj User
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Language> languages { get; set; }
        public DbSet<IT> it { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }

}

