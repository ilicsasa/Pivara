using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pvara.Models
{
    public class PivaraDTO
    {
        [Required(ErrorMessage = "Obavezno uneti naziv pivare")]
        [Display(Name = "Naziv pivare")]
        [StringLength(128)]
        public string Naziv { get; set; }
        
        [Required(ErrorMessage = "Obavezno uneti naziv drzave")]
        [Display(Name = "Drzava")]
        [StringLength(128)]
        public string Drzava { get; set; }

        public string PivoNaziv { get; set; }
    }
}