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
    
    public partial class PromotionScheduleProductAudit
    {
        public int RecordID { get; set; }
        public string PromotionScheduleID { get; set; }
        public string PromotionScheduleProductID { get; set; }
        public int AuditStatus { get; set; }
        public string AuditRemark { get; set; }
        public int Auditor { get; set; }
        public System.DateTime AuditDate { get; set; }
    }
}