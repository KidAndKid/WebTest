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
    
    public partial class PreProductSpec
    {
        public int PreProductSpecsID { get; set; }
        public int PreProductID { get; set; }
        public string Specs { get; set; }
        public string MainPicture { get; set; }
        public string SupplierNo { get; set; }
        public string Barcode { get; set; }
        public int InventoryNum { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<decimal> BasicPrice { get; set; }
        public Nullable<decimal> PromotionBasicPrice { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
    }
}
