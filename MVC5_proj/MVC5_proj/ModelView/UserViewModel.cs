using MVC5_proj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5_proj.ModelView
{
    public class UserViewModel
    {
        public User User { get; set; }

        public List<User> Users { get; set; }

        public List<Contact> contacts { get; set; }

        public List<Language> languages { get; set; }

        public List<IT> its { get; set; }


    }
}