using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JETech.SIC.Web.Models
{
    public class AddUserViewModel
    {
        public int Id { get; set; }  

        [Display(Name = "Nombres")]
        [MaxLength(60, ErrorMessage = "El campo {0} no pueden contener mas de {1} caracteres.")]
        [Required(ErrorMessage = "Este campos {0} es requerido.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(60, ErrorMessage = "El campo {0} no pueden contener mas de {1} caracteres.")]
        [Required(ErrorMessage = "Este campos {0} es requerido.")]
        public string LastName { get; set; }
                
        [Required(ErrorMessage = "Este campos {0} es requerido.")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Este campos {0} es requerido.")]
        [DataType(DataType.Password)]
        [StringLength(20,MinimumLength =6, ErrorMessage = "Este campos {0} es requerido.")]
        public string Password { get; set; }

        [Display(Name = "Confirmmar contraseña")]
        [Required(ErrorMessage = "Este campos {0} es requerido.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Este campos {0} es requerido.")]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
    }
}
