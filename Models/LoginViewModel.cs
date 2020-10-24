using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JETech.SIC.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Este campo {0} es requerido.")]
        [EmailAddress]
        [Display(Name = "Usuario")]
        public string Username { get;  set; }

        [Required(ErrorMessage = "Este campo {0} es requerido.")]
        [Display(Name = "Contraseña")]        
        [DataType(DataType.Password)]        
        public string Password { get;  set; }

        [Display(Name = "Recuerdame")]        
        public bool RememberMe { get;  set; }
    }
}
