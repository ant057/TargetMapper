using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetMapperData.Models;

namespace TargetMapperData.Domain
{
    public interface IReferenceMapping
    {
        IEnumerable<ReferenceMappingModel> GetReferenceMapTables();
        ReferenceMappingModel GetReferenceMap(string table);
        int UpdateReferenceMap(ReferenceMappingModel row);
    }
}
