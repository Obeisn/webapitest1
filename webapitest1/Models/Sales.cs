//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace webapitest1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Sales
    {
        public int SalesId { get; set; }
        [Required(ErrorMessage ="請填寫帳號")]
        public string SalesAccount { get; set; }
        public string SalesPassword { get; set; }
        public string SalesEmail { get; set; }
        public string SalesPathCode { get; set; }
        public string SalesBranchOffice { get; set; }
        public string SalesCertificateNumber { get; set; }
        public Nullable<System.DateTime> Sales_is_date { get; set; }
        public Nullable<System.DateTime> Sales_exp_date { get; set; }
        public Nullable<System.DateTime> Sales_lg_date { get; set; }
        public Nullable<System.DateTime> Sales_exp_pw_date { get; set; }
        public Nullable<System.DateTime> Sales_exp_Invalid_date { get; set; }
        public Nullable<System.DateTime> Sales_exp_leave_date { get; set; }
        public Nullable<bool> SalesIsDeleted { get; set; }
        public Nullable<System.DateTime> SalesCreatedDate { get; set; }
        public Nullable<int> SalesCreatedId { get; set; }
        public Nullable<int> SalesEditedId { get; set; }
        public Nullable<System.DateTime> SalesEditedDate { get; set; }
        public string SalesPasswordAgain { get; set; }
    }
}