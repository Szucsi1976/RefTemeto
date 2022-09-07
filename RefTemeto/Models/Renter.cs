using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RefTemeto.Models
{
    public class Renter         //Sírbérlő, megváltó
    {
        [Key]
        [DisplayName("Azonosító")]
        public int RenterId { get; set; }

        [Required]
        [DisplayName("Vezetéknév")]
        public string RenterLastname{ get; set; }

        [Required]
        [DisplayName("Keresztnév")]
        public string RenterFirstname { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        [DisplayName("Település")]
         public int RenterSettlementId { get; set; }

        [Required]
        [DisplayName("Cím")]
        public string RenterAdress { get; set; }

        [DisplayName("e-mail")]
        [EmailAddress]
        public string RenterEmail { get; set; }

        [DisplayName("telefon")]
        [Phone]
        public string RenterPhoneNumber { get; set; }

        [ForeignKey("RenterSettlementId")]
        public virtual Settlement Settlement { get; set; }   //Ez a csatolt tábla
    }
}
