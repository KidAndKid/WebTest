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
    
    public partial class PromotionDailyQuota
    {
        public int PromotionDailyQuotaID { get; set; }
        public string PromotionID { get; set; }
        public string SkuCode { get; set; }
        public System.DateTime PromotionTime { get; set; }
        public decimal Proportion { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string Creator { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string Updater { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
