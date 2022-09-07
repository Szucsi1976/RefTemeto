﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RefTemeto.Models
{
    public class Settlement                 //Irányítószámok
    {
        [Key]
        public int SettlementId { get; set; }
        [Required]
        [DisplayName("Irányítószám")]
        public int PostalCode { get; set; }

        [Required]
        [DisplayName("Település")]
        public string Station { get; set; }

    }
}

