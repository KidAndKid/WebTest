//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LamaConsole
{
    using System;
    using System.Collections.Generic;
    
    public partial class GiftOrderRefundRecord
    {
        public int GiftOrderRefundRecordID { get; set; }
        public string GiftOrderID { get; set; }
        public int RefundStatus { get; set; }
        public decimal PaymentMoney { get; set; }
        public decimal RefundMoney { get; set; }
        public string Remark { get; set; }
        public System.DateTime ApplyTime { get; set; }
        public string ApplyUser { get; set; }
        public Nullable<System.DateTime> AuditTime { get; set; }
        public string Auditor { get; set; }
    }
}
