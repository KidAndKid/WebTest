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
    
    public partial class Ship
    {
        public string ShipID { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public string TrackingNo { get; set; }
        public string ShipCompany { get; set; }
        public string OrderID { get; set; }
        public string ShipCompanyCode { get; set; }
        public Nullable<int> HasShipDetail { get; set; }
        public Nullable<System.DateTime> FirstSearchTime { get; set; }
        public Nullable<System.DateTime> LastSearchTime { get; set; }
        public Nullable<int> LastSearchStatus { get; set; }
        public int ApiType { get; set; }
    }
}