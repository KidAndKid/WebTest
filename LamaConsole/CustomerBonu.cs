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
    
    public partial class CustomerBonu
    {
        public string CustomerBonusID { get; set; }
        public string CustomerID { get; set; }
        public string OrderID { get; set; }
        public decimal Bonus { get; set; }
        public int Level { get; set; }
        public string Status { get; set; }
        public string OrderCustomerID { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string Sku { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Num { get; set; }
        public Nullable<decimal> Percent { get; set; }
    }
}