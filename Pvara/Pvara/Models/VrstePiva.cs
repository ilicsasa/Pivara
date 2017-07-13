using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pvara.Models
{
    [Table("Vrste_Piva", Schema = "dbo")]
    public class VrstePiva
    {

        [Key]
        [Display(Name = "ID Vrste Piva")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obavezno uneti naziv vrste piva")]
        [Display(Name = "Naziv vrste piva")]
        [StringLength(128)]
        public string Naziv { get; set; }


        public virtual List<Pivo> Pivo { get; set; }
    }
}