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
    
    public partial class CompensationReportItem
    {
        public int Id { get; set; }
        public Nullable<int> SupplierReportId { get; set; }
        public string SupplierOrderId { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Skuname { get; set; }
        public string Skucode { get; set; }
        public Nullable<int> Num { get; set; }
        public Nullable<decimal> CostAmount { get; set; }
        public Nullable<decimal> CompensateAmount { get; set; }
        public Nullable<decimal> CouponCompensationAmount { get; set; }
        public Nullable<decimal> SupplierShippingFeeAmount { get; set; }
        public Nullable<decimal> SupplierCouponAmount { get; set; }
        public string ReceiverName { get; set; }
        public Nullable<decimal> CompensationAmount { get; set; }
        public string Remark { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> TrackOverTime { get; set; }
        public Nullable<int> PurchasePlusID { get; set; }
        public Nullable<decimal> CompensationAmount2 { get; set; }
        public string TrackRemark { get; set; }
        public string CompensationType { get; set; }
        public string SupplierRemark { get; set; }
        public string ManagerRemark { get; set; }
        public string BossRemark { get; set; }
    }
}
