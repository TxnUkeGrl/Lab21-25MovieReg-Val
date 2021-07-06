using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab21MovieRegistration.Models
{
    public class Movie
    {
        [Required(ErrorMessage = "This Title Field allows only 50 characters MAX")]
        [StringLength(50)]
        public string Title { get; set; }

        //[Required(ErrorMessage = "A Genre MUST be selected by the provided list")]

        public string Genre { get; set; }

        //TODO: insert year
        //public static int currentYear = DateTime.Now.Year;
        [Range(1880, 2021, ErrorMessage = "Only films produced BETWEEN the years of 1880-" + "may be submitted")]
        public string Year { get; set; }

        //TODO: change to list
        public string Actors { get; set; }

        //TODO: change to list
        public string Directors { get; set; }
        
        public int ID { get; set; }

        public List<SelectListItem> ListGenre { get; set; } = new List<SelectListItem>();
    }
}
