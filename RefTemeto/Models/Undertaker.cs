using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RefTemeto.Models
{
    public class Undertaker
    {
        [Key]
        public int UndertakerId { get; set; }

        [Required]
        [DisplayName("Temetkezési vállalat")]
        public string UndertakerName { get; set; }
    }
}
