using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TargetMapperData.Models
{
    public class ReferenceMappingModel
    {
        public string tableName { get; set; }
        public List<ReferenceData> data { get; set; }

        public ReferenceMappingModel()
        {

        }

    }

    public class ReferenceData
    {
        public int id { get; set; }
        public string sourceSystem { get; set; }
        public string sourceSystemCode { get; set; }
        public string sourceSystemDesc { get; set; }
        public string targetSystemCode { get; set; }
        public string targetSystemDesc { get; set; }

        public ReferenceData(int id, string sourceSys, string sourceSysCd, string sourceSysDesc
            , string targetSysCd, string targetSysDesc)
        {
            this.id = id;
            this.sourceSystem = sourceSys;
            this.sourceSystemCode = sourceSysCd;
            this.sourceSystemDesc = sourceSysDesc;
            this.targetSystemCode = targetSysCd;
            this.targetSystemDesc = targetSysDesc;
        }
    }
}