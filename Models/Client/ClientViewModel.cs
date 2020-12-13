﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JETech.SIC.Web.Models.Client
{
    public class ClientViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Client Type")]
        public int ClientType { get; set; }

        [Display(Name = "Full Name")]
        [MaxLength(120, ErrorMessage = Global.Messages.MaxLengthVal)]
        [Required(ErrorMessage = Global.Messages.NullFieldVal)]
        public string FullName { get; set; }

        [Display(Name = "Names")]
        [MaxLength(60, ErrorMessage = Global.Messages.MaxLengthVal)]
        [Required(ErrorMessage = Global.Messages.NullFieldVal)]
        public string FirstName { get; set; }

        [Display(Name = "Last Names")]
        [MaxLength(60, ErrorMessage = Global.Messages.MaxLengthVal)]
        [Required(ErrorMessage = Global.Messages.NullFieldVal)]
        public string LastName { get; set; }

        [Display(Name = "ID Type")]
        [MaxLength(1, ErrorMessage = Global.Messages.MaxLengthVal)]
        public int? TypeIdentityId { get; set; }

        [Display(Name = "ID")]
        [MaxLength(20, ErrorMessage = Global.Messages.MaxLengthVal)]
        public string IdentityId { get; set; }

        [Display(Name = "Home Phone")]
        [MaxLength(10, ErrorMessage = Global.Messages.MaxLengthVal)]
        public string HomePhone { get; set; }

        [Display(Name = "Cell Phone")]
        [MaxLength(10, ErrorMessage = Global.Messages.MaxLengthVal)]
        public string CellPhone { get; set; }

        [Display(Name = "Fax")]
        [MaxLength(10, ErrorMessage = Global.Messages.MaxLengthVal)]
        public string Fax { get; set; }

        [Display(Name = "Contry")]
        [MaxLength(60, ErrorMessage = Global.Messages.MaxLengthVal)]
        public string Contry { get; set; }

        [Display(Name = "City")]
        [MaxLength(60, ErrorMessage = Global.Messages.MaxLengthVal)]
        public string City { get; set; }

        [Display(Name = "Address")]
        [MaxLength(100, ErrorMessage = Global.Messages.MaxLengthVal)]
        public string Address { get; set; }

        [Display(Name = "Zip Code")]
        [MaxLength(6, ErrorMessage = Global.Messages.MaxLengthVal)]
        public int? ZipCode { get; set; }

        [Display(Name = "Email")]
        [MaxLength(50, ErrorMessage = Global.Messages.MaxLengthVal)]
        public string Email { get; set; }

        [Display(Name = "Status")]
        public string StatusName { get; set; }

        public int StatusId { get; set; }
    }
}
