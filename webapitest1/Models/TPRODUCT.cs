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
    
    public partial class TPRODUCT
    {
        public int mobile_id { get; set; }
        public string mobile_type { get; set; }
        public string mobile_model { get; set; }
        public Nullable<decimal> mobile_premium { get; set; }
        public Nullable<int> policy_period { get; set; }
        public Nullable<decimal> mobile_device_price { get; set; }
        public Nullable<decimal> screen_ee_deduct { get; set; }
        public Nullable<decimal> other_deduct { get; set; }
        public Nullable<int> max_claim_count { get; set; }
        public string major_line_cd { get; set; }
        public string minor_line_cd { get; set; }
        public string class_Period_cd { get; set; }
        public Nullable<System.DateTime> PROD_EFF_DATE { get; set; }
        public Nullable<System.DateTime> PROD_EXP_DATE { get; set; }
        public string MOF_code { get; set; }
        public string Prod_status { get; set; }
        public string userid_cd { get; set; }
        public Nullable<System.DateTime> timestamp { get; set; }
        public string REF_GROUP_CD { get; set; }
        public Nullable<int> TPRODUCTCreatedId { get; set; }
        public Nullable<System.DateTime> TPRODUCTCreatedDate { get; set; }
        public Nullable<int> TPRODUCTEditedId { get; set; }
        public Nullable<System.DateTime> TPRODUCTEditedDate { get; set; }
        public Nullable<bool> TPRODUCTIsDeleted { get; set; }
    }
}
