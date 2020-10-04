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
        [Required]
        [EmailAddress]
        [Display(Name = "Usuario")]
        public string Username { get;  set; }

        [Display(Name = "Contraseña")]        
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Este campos {0} es requerido.")]
        public string Password { get;  set; }

        [Display(Name = "Recuerdame")]        
        public bool RememberMe { get;  set; }
    }
}
