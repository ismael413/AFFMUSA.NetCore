using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebasNetCore.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        [Required, MinLength(3, ErrorMessage = "The country can not contain less than 3 characters")]
        public string CountryName { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
