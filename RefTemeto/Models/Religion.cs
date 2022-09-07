using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RefTemeto.Models
{
    public class Religion
    {
        [Key]
        public int ReligionId { get; set; }

        [Required]
        [DisplayName("Vallás")]
        public string ReligionName { get; set; }
    }
}
