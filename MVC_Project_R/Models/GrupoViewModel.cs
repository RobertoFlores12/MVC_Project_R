using ADS_Project.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project_R.Models
{
    public class GrupoViewModel
    {
        [Display(Name = "ID")]
        public int idGrupo { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor a 3 caracteres.")]
        [Display(Name = "idCarrera")]
        public int idCarrera { get; set; }


        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor a 3 caracteres.")]
        [Display(Name = "idMateria")]

        public int idMateria { get; set; }


        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor a 3 caracteres.")]
        [Display(Name = "idProfesor")]
        public int idProfesor { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor a 3 caracteres.")]
        [Display(Name = "Ciclo")]

        public String Ciclo { get; set; }

        [Required(ErrorMessage = Constants.REQUIRED_FIELD)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La longitud del campo no debe ser mayor a 50 caracteres ni menor a 3 caracteres.")]
        [Display(Name = "year")]

        public String year { get; set; }

    }
}





