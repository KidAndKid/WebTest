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
    
    public partial class Payment
    {
        public string PaymentID { get; set; }
        public Nullable<System.DateTime> paymentTime { get; set; }
        public Nullable<int> PaymentMothod { get; set; }
        public string transactionNo { get; set; }
        public Nullable<decimal> amount { get; set; }
        public string OrderID { get; set; }
        public string PaymentStatusID { get; set; }
        public string ToAccountID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string nonce_str { get; set; }
        public string timestamp { get; set; }
        public string prepay_id { get; set; }
        public string paySign { get; set; }
    }
}
