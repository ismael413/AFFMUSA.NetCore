﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AFFMUSA.Models.Lists
{
    public class States
    {
        public int StatesID { get; set; }

        [Required, MaxLength(30, ErrorMessage = "The Country Name can just contain 30 characters.")]
        public string StateName { get; set; }
    }
}
