using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JETech.SIC.Web.Models.Client
{
    public class ClientViewModel
    {
        public int Id { get; set; }

        public int ClientType { get; set; }

        [Display(Name ="Nombre")]
        public string FullName { get; set; }

        [Display(Name = "Primer Nombre")]
        public string FirstName { get; set; }

        [Display(Name = "Segundo Nombre")]
        public string LastName { get; set; }

        [Display(Name = "Tipo Identificacion")]
        public string TypeIdentityId { get; set; }

        [Display(Name = "Identificacion")]
        public string IdentityId { get; set; }

        [Display(Name = "Telefono")]
        public string HomePhone { get; set; }

        [Display(Name = "Celular")]
        public string CellPhome { get; set; }

        [Display(Name = "Fax")]
        public string Fax { get; set; }

        [Display(Name = "Pais")]
        public string Contry { get; set; }

        [Display(Name = "Ciudad")]
        public string City { get; set; }

        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [Display(Name = "Código postal")]
        public int? ZipCode { get; set; }
                
        public string Email { get; set; }

        [Display(Name = "Estado")]
        public string StatusName { get; set; }        
    }
}
