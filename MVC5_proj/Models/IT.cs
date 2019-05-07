using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC5_proj.Models
{
    
    [Table("IT")]
    public class IT
    {
        public string ID{ get; set; }

        public string Message { get; set; }

    }
    
}