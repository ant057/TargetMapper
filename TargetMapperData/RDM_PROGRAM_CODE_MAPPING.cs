//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TargetMapperData
{
    using System;
    using System.Collections.Generic;
    
    public partial class RDM_PROGRAM_CODE_MAPPING
    {
        public decimal PROGRAM_CODE_ID { get; set; }
        public string SOURCE_SYSTEM { get; set; }
        public string SRC_PROGRAM_CODE { get; set; }
        public string SRC_PROGRAM_DESC { get; set; }
        public string TRG_PROGRAM_CODE { get; set; }
        public string TRG_PROGRAM_DESC { get; set; }
        public Nullable<System.DateTime> FROM_EFF_TIMESTAMP { get; set; }
        public Nullable<System.DateTime> THRU_EFF_TIMESTAMP { get; set; }
        public string IN_EFFECT { get; set; }
        public string REC_UPD_FLAG { get; set; }
        public string RDM_DESC { get; set; }
        public string INSERTED_BY { get; set; }
        public Nullable<System.DateTime> INSERTED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public Nullable<System.DateTime> UPDATED_DATE { get; set; }
    }
}
