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
    
    public partial class SupplierShippingFeeHistory
    {
        public int ID { get; set; }
        public int SupplierId { get; set; }
        public System.DateTime BeginTime { get; set; }
        public decimal ShippingFee { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string Updater { get; set; }
    }
}
