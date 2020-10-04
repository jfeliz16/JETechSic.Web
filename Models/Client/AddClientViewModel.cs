using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JETech.SIC.Web.Models.Client
{
    public class AddClientViewModel
    {
        public int ClientType { get; set; }

        public string FullName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TypeIdentityId { get; set; }

        public string IdentityId { get; set; }

        public string HomePhone { get; set; }

        public string CellPhome { get; set; }

        public string Fax { get; set; }

        public string Contry { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public int? ZipCode { get; set; }

        public string Email { get; set; }
    }
}
