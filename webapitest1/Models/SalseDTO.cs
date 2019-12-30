using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webapitest1.Models
{
    public class SalseDTO
    {
        public int SalesId { get; set; }
        [Required(ErrorMessage = "請填寫帳號")]
        public string SalesAccount { get; set; }
        public string SalesEmail { get; set; }
        public string SalesPathCode { get; set; }
        public string SalesBranchOffice { get; set; }
        public string SalesCertificateNumber { get; set; }
        public string OO { get; set; }
    }
}