﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pvara.Models
{
    public class PivoDTO
    {
        [Required(ErrorMessage = "Obavezno uneti naziv")]
        [Display(Name = "Naziv")]
        [StringLength(128)]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Obavezno uneti procenat alkohola")]
        [Range(0, int.MaxValue)]
        [Display(Name = "Procenat Alkohola")]
        public decimal ProcenatAlkohola { get; set; }

        [Required(ErrorMessage = "Obavezno uneti IBU")]
        [Range(0, int.MaxValue)]
        [Display(Name = "IBU")]
        public decimal IBU { get; set; }
     
        [Required(ErrorMessage = "Obavezno uneti kolicinu na stanju")]
        [Range(1, 10)]
        public int Kolicina { get; set; }

        public string PivaraNaziv { get; set; }

        public string VrstePivaNaziv { get; set; }

    }
}