using AFFMUSA.Models;
using Ext.Net;
using PruebasNetCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AFFMUSA.ViewModel
{
    public class AddClientViewModel
    {
        public int ClientID { get; set; }

        [Required, MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Company_Name { get; set; }
        [Required, MaxLength(30, ErrorMessage = "Name cannot exceed 30 characters")]
        public string Contact_Name { get; set; }
        [Required, MaxLength(30, ErrorMessage = "Name cannot exceed 30 characters")]
        public string Job_Title { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
           ErrorMessage = "Invalid email format")]
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Ext { get; set; }
        public string Fax { get; set; }
        [Required, MaxLength(30, ErrorMessage = "Name cannot exceed 30 characters")]
        public string City { get; set; }
        public int ZipCode { get; set; }
        [Required]
        public string Notes { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        //public IFromFile Photo { get; set; }
        [Required]
        public bool AllowBilling { get; set; }

    }
}
