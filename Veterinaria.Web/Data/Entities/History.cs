using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Web.Data.Entities
{
    public class History
    {
        public int Id { get; set; }

        public ServiceType ServiceType { get; set; }
        public BreedType BreedType { get; set; }

        [Display(Name = "Historia*")]
        [MaxLength(100, ErrorMessage = "El {0} campo no puede tener mas de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatoria.")]
        public string Description { get; set; }

        [Display(Name = "Fecha*")]
        [Required(ErrorMessage = "El campo {0} es obligatoria.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public string Remarks { get; set; }

        public Pet Pet { get; set; }

        [Display(Name = "Fecha*")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateLocal => Date.ToLocalTime();

    }
}
