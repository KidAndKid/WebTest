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
    
    public partial class PromotionSchedule
    {
        public string PromotionScheduleID { get; set; }
        public string PromotionName { get; set; }
        public string AppID { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string PromotionDescription { get; set; }
        public Nullable<int> PromotionTagID { get; set; }
        public Nullable<int> ProductDescription { get; set; }
        public bool DisplayOnStore { get; set; }
        public string ShowText { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int Creator { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public int Updater { get; set; }
        public string TranslateId { get; set; }
        public string PromotionRemark { get; set; }
        public bool IsDeleted { get; set; }
        public bool UsePromotionBasicPrice { get; set; }
        public Nullable<System.DateTime> ShowTime { get; set; }
    }
}
