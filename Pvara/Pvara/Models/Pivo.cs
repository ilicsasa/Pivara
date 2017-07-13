using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pvara.Models
{
    [Table("Pivo", Schema = "dbo")]
    public class Pivo
    {
        [Key]
        [Display(Name = "ID Piva")]
        public int Id { get; set; }

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

        [Required(ErrorMessage = "Obavezno uneti cenu")]
        [Range(0, int.MaxValue)]
        [Display(Name = "Cena Propizvoda")]
        public decimal Cena { get; set; }

        [Required(ErrorMessage = "Obavezno uneti kolicinu na stanju")]
        [Range(1, 10)]
        public int Kolicina { get; set; }

        [Required(ErrorMessage = "Obavezno uneti datum proizvodnje")]
        [DataType(DataType.Date)]
        public DateTime? DatumProizvodnje { get; set; }

        [ForeignKey("Pivara")]
        public int PivaraId { get; set; }
                
        public Pivara Pivara { get; set; }


        
        [ForeignKey("VrstePiva")]
        public int VrstePivaId { get; set; }
                
        public VrstePiva VrstePiva { get; set; }



    }
}