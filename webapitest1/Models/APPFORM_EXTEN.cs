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
    
    public partial class APPFORM_EXTEN
    {
        public string tran_id { get; set; }
        public long endorsement_no { get; set; }
        public string first_tran_id { get; set; }
        public Nullable<int> Eds_status { get; set; }
        public Nullable<System.DateTime> Eds_BillingDate { get; set; }
        public string Eds_BillingURL { get; set; }
        public string PolicyNO_All { get; set; }
        public string id_no { get; set; }
        public string endorse_no_All { get; set; }
        public Nullable<bool> is_logout { get; set; }
    }
}