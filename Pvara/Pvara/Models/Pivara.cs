using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pvara.Models
{
    [Table("Pivara", Schema = "dbo")]
    public class Pivara
    {
        [Key]
        [Display(Name = "ID Pivare")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obavezno uneti naziv pivare")]
        [Display(Name = "Naziv pivare")]
        [StringLength(128)]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Obavezno uneti PIB")]
        [Display(Name = "PIB")]
        [StringLength(128)]
        public string PIB { get; set; }

        [Required(ErrorMessage = "Obavezno uneti naziv drzave")]
        [Display(Name = "Drzava")]
        [StringLength(128)]
        public string Drzava { get; set; }

        public virtual List<Pivo> Pivo { get; set; }

    }
}