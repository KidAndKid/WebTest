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
    
    public partial class LamaOrderRefund
    {
        public string LamaOrderRefundID { get; set; }
        public string OrderID { get; set; }
        public string Reason { get; set; }
        public int AcountType { get; set; }
        public string AlipayAcount { get; set; }
        public string Remark { get; set; }
        public string VoucherImgs { get; set; }
        public int Status { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string CustomerServiceRemark { get; set; }
        public Nullable<int> Auditor { get; set; }
        public Nullable<System.DateTime> AuditTime { get; set; }
        public string RefuseReason { get; set; }
        public Nullable<decimal> ShippingFee { get; set; }
        public string InternalRemark { get; set; }
    }
}