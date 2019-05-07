using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_proj.Models
{
    public class Language
    {
        [Key]
        [Required]
        public string word { get; set; }

        public string link { get; set; }

    }
}