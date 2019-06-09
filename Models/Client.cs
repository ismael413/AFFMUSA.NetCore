using AFFMUSA.Models.Lists;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AFFMUSA.Models
{
    public class Client
    {
        public int ClientID { get; set; }

        [Required, MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Company_Name { get; set; }

        [Required, MaxLength(30, ErrorMessage = "Name cannot exceed 30 characters")]
        public string Contact_Name { get; set; }
        [Required, MaxLength(20, ErrorMessage = "Name cannot exceed 20 characters")]
        public string Job_Title { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
           ErrorMessage = "Invalid email format")]
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        [MaxLength(5, ErrorMessage = "Extension of Phone Number can not contain more than 5 digits.")]
        public int Ext { get; set; }
        public string Fax { get; set; }
        [Required, MaxLength(30, ErrorMessage = "Name cannot exceed 30 characters")]
        public string City { get; set; }
        [Required]
        public List<States> States { get; set; }
        [Range(0, 100000, ErrorMessage = "ZipCode should not contain characters")]
        public int ZipCode { get; set; }
        [Required]
        public List<Country> Countries { get; set; }
        public string Notes { get; set; }
        public string Photo { get; set; }
        [Required]
        public bool AllowBilling { get; set; }
    }
}
