using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AFFMUSA.Models
{
    public class Country
    {
        public int CountryID { get; set; }

        [Required, MaxLength(30, ErrorMessage = "The Country Name can just contain 30 characters.")]
        public string CountryName { get; set; }

    }
}
