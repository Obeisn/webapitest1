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
    
    public partial class PolicyD
    {
        public int PolicyDId { get; set; }
        public Nullable<int> PolicyDFlatFileId { get; set; }
        public Nullable<bool> PolicyDIsDeleted { get; set; }
        public Nullable<int> PolicyDCreatedId { get; set; }
        public Nullable<System.DateTime> PolicyDCreatedDate { get; set; }
        public Nullable<int> PolicyDEditedId { get; set; }
        public Nullable<System.DateTime> PolicyDEditedDate { get; set; }
        public Nullable<int> PolicyDPolicyAcId { get; set; }
        public string PolicyD_tran_id { get; set; }
        public string PolicyD_AC_Contract_No { get; set; }
        public string PolicyD_Serial_No { get; set; }
        public string PolicyD_Contract_No { get; set; }
    
        public virtual FlatFile FlatFile { get; set; }
        public virtual PolicyAc PolicyAc { get; set; }
    }
}