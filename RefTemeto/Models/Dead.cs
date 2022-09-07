﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RefTemeto.Models
{
  
    public class Dead          // Halott 
    {
        [Key]
        [DisplayName("Azonosító")]
        public int DeadId { get; set; }

        [Required]
        [DisplayName("Születési vezetéknév")]
        public string DeadBirthLastName { get; set; }
        
        [Required]
        [DisplayName("Születési keresztnév")]
        public string DeadBirthFirstName { get; set; }

        [Required]
        [DisplayName("Anyja neve")]
        public string DeadMothersName { get; set; }

        [DisplayName("Születési hely")]
        public int DeadBirthSettlementId { get; set; }

        [DisplayName("Születési dátum")]
        public DateTime DeadBirthDate { get; set; }

        [DisplayName("Elhalálozás dátuma")]
        public DateTime DeadDeathDate { get; set; }

        [DisplayName("Vallás")]
        [Required]
        public int DeadReligionId { get; set; }

        [DisplayName("Halál oka")]
        public string DeadCauseOfDeath { get; set; }
        
        [DisplayName("Sírhely")]
        [Required]
        public int DeadGraveId { get; set; }

        [DisplayName("Temetés")]
        [Required]
        public int DeadBurialId { get; set; }


        [ForeignKey("DeadReligionId")]
        public virtual Religion Religion { get; set; }   //Ez a csatolt tábla sír tábla

        [ForeignKey("DeadGraveId")]
        public virtual Grave Grave { get; set; }   //Ez a csatolt tábla sír tábla

        [ForeignKey("DeadBurialId")]
        public virtual Burial Burial { get; set; }   //Ez a csatolt tábla temetés tábla
        
        [ForeignKey("DeadBirthSettlementId")]
        public virtual Settlement Settlement { get; set; }   //Ez a csatolt tábla születési hely tábla
    }
}
