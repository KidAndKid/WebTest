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
    
    public partial class PurchasePlu
    {
        public int PurchasePlusID { get; set; }
        public string Name { get; set; }
        public string Appid { get; set; }
        public int Type { get; set; }
        public int PromotionTagID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public bool IsAllGoods { get; set; }
        public bool IsExclude { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<int> ProductRangeType { get; set; }
    }
}