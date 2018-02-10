using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Movie
    {
            [Key]
            public int idMovie { get; set; }
            public string movieName { get; set; }
        
    }
}