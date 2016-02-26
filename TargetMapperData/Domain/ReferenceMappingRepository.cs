using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TargetMapperData.Models;

namespace TargetMapperData.Domain
{
    public class ReferenceMappingRepository : IReferenceMapping
    {
        private RDMEntities context;

        public ReferenceMappingRepository(RDMEntities context)
        {
            this.context = context;
        }

        //TODO: refactor 
        public ReferenceMappingModel GetReferenceMap(string table)
        {
            ReferenceMappingModel obj = new ReferenceMappingModel();
            obj.tableName = table;
            obj.data = new List<ReferenceData>();

            if (table.Equals("Company Code"))
            {
                RDM_COMPANY_CODE_MAPPING[] data = context.RDM_COMPANY_CODE_MAPPING.ToArray();
                for(int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].COMPANY_CODE_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_COMPANY_CODE,
                            data[i].SRC_COMPANY_DESC,
                            data[i].TRG_COMPANY_CODE,
                            data[i].TRG_COMPANY_DESC));
                }
            }
            else if (table.Equals("Agent Code"))
            {
                RDM_AGENT_CODE_MAPPING[] data = context.RDM_AGENT_CODE_MAPPING.ToArray();
                for (int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].AGENT_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_AGENT_CODE,
                            data[i].SRC_AGENT_DESC,
                            data[i].TRG_AGENT_CODE,
                            data[i].TRG_AGENT_DESC));
                }
            }
            else if (table.Equals("Business Unit Code"))
            {
                RDM_BUS_UNIT_CODE_MAPPING[] data = context.RDM_BUS_UNIT_CODE_MAPPING.ToArray();
                for (int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].BUS_UNIT_CODE_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_BUS_UNIT_CODE,
                            data[i].SRC_BUS_UNIT_DESC,
                            data[i].TRG_BUS_UNIT_CODE,
                            data[i].TRG_BUS_UNIT_DESC));
                }
            }
            else if (table.Equals("ASL Code"))
            {
                RDM_ASL_CODE_MAPPING[] data = context.RDM_ASL_CODE_MAPPING.ToArray();
                for (int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].ASL_CODE_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_ASL_CODE,
                            data[i].SRC_ASL_DESC,
                            data[i].TRG_ASL_CODE,
                            data[i].TRG_ASL_DESC));
                }
            }
            else if (table.Equals("Class Code"))
            {
                RDM_CLASS_CODE_MAPPING[] data = context.RDM_CLASS_CODE_MAPPING.ToArray();
                for (int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].CLASS_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_CLASS_CODE,
                            data[i].SRC_CLASS_DESC,
                            data[i].TRG_CLASS_CODE,
                            data[i].TRG_CLASS_DESC));
                }
            }
            else if (table.Equals("Coverage Code"))
            {
                RDM_COVERAGE_CODE_MAPPING[] data = context.RDM_COVERAGE_CODE_MAPPING.ToArray();
                for (int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].COVERAGE_CODE_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_COVERAGE_CODE,
                            data[i].SRC_COVERAGE_DESC,
                            data[i].TRG_COVERAGE_CODE,
                            data[i].TRG_COVERAGE_DESC));
                }
            }
            else if (table.Equals("Program Code"))
            {
                RDM_PROGRAM_CODE_MAPPING[] data = context.RDM_PROGRAM_CODE_MAPPING.ToArray();
                for (int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].PROGRAM_CODE_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_PROGRAM_CODE,
                            data[i].SRC_PROGRAM_DESC,
                            data[i].TRG_PROGRAM_CODE,
                            data[i].TRG_PROGRAM_DESC));
                }
            }
            else if (table.Equals("State Code"))
            {
                RDM_STATE_CODE_MAPPING[] data = context.RDM_STATE_CODE_MAPPING.ToArray();
                for (int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].STATE_CODE_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_STATE_CODE,
                            data[i].SRC_STATE_DESC,
                            data[i].TRG_STATE_CODE,
                            data[i].TRG_STATE_DESC));
                }
            }
            else if (table.Equals("Underwriter Code"))
            {
                RDM_UNDERWRITER_CODE_MAPPING[] data = context.RDM_UNDERWRITER_CODE_MAPPING.ToArray();
                for (int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].UNDERWRITER_CODE_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_UNDERWRITER_CODE,
                            data[i].SRC_UNDERWRITER_DESC,
                            data[i].TRG_UNDERWRITER_CODE,
                            data[i].TRG_UNDERWRITER_DESC));
                }
            } else if (table.Equals("Catastrophe Code"))
            {
                RDM_CAT_CODE_MAPPING[] data = context.RDM_CAT_CODE_MAPPING.ToArray();
                for (int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].CAT_CODE_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_CAT_CODE,
                            data[i].SRC_CAT_DESC,
                            data[i].TRG_CAT_CODE,
                            data[i].TRG_CAT_DESC));
                }
            } else if (table.Equals("County Unit Code"))
            {
                RDM_COUNTY_UNIT_CODE_MAPPING[] data = context.RDM_COUNTY_UNIT_CODE_MAPPING.ToArray();
                for (int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].COUNTY_UNIT_CODE_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_COUNTY_UNIT_CODE,
                            data[i].SRC_COUNTY_UNIT_DESC,
                            data[i].TRG_COUNTY_UNIT_CODE,
                            data[i].TRG_COUNTY_UNIT_DESC));
                }
            }
            else if (table.Equals("Groupline Code"))
            {
                RDM_GRPLINE_CODE_MAPPING[] data = context.RDM_GRPLINE_CODE_MAPPING.ToArray();
                for (int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].GRPLINE_CODE_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_GRPLINE_CODE,
                            data[i].SRC_GRPLINE_DESC,
                            data[i].TRG_GRPLINE_CODE,
                            data[i].TRG_GRPLINE_DESC));
                }
            }
            else if (table.Equals("Management Code"))
            {
                RDM_MGMT_SEG_CODE_MAPPING[] data = context.RDM_MGMT_SEG_CODE_MAPPING.ToArray();
                for (int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].MGMT_SEG_CODE_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_MGMT_SEG_CODE,
                            data[i].SRC_MGMT_SEG_DESC,
                            data[i].TRG_MGMT_SEG_CODE,
                            data[i].TRG_MGMT_SEG_DESC));
                }
            }
            else if (table.Equals("Subline Code"))
            {
                RDM_SUB_LINE_CODE_MAPPING[] data = context.RDM_SUB_LINE_CODE_MAPPING.ToArray();
                for (int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].SUB_LINE_CODE_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_SUB_LINE_CODE,
                            data[i].SRC_SUB_LINE_DESC,
                            data[i].TRG_SUB_LINE_CODE,
                            data[i].TRG_SUB_LINE_DESC));
                }
            }
            else if (table.Equals("Territory Code"))
            {
                RDM_TERR_UNDR_CODE_MAPPING[] data = context.RDM_TERR_UNDR_CODE_MAPPING.ToArray();
                for (int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].TERR_UNDR_CODE_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_TERR_UNDR_CODE,
                            data[i].SRC_TERR_UNDR_DESC,
                            data[i].TRG_TERR_UNDR_CODE,
                            data[i].TRG_TERR_UNDR_DESC));
                }
            }
            else if (table.Equals("Userline Code"))
            {
                RDM_USERLINE_CODE_MAPPING[] data = context.RDM_USERLINE_CODE_MAPPING.ToArray();
                for (int i = 0; i < data.Length; i++)
                {
                    obj.data.Add(
                        new ReferenceData(
                            int.Parse(data[i].USERLINE_CODE_ID.ToString()),
                            data[i].SOURCE_SYSTEM,
                            data[i].SRC_USERLINE_CODE,
                            data[i].SRC_USERLINE_DESC,
                            data[i].TRG_USERLINE_CODE,
                            data[i].TRG_USERLINE_DESC));
                }
            }

            return obj;
        }

        public IEnumerable<ReferenceMappingModel> GetReferenceMapTables()
        {
            throw new NotImplementedException();
        }

        public int UpdateReferenceMap(ReferenceMappingModel row)
        {
            try
            {
                ReferenceData refData = row.data.SingleOrDefault();

                using (context)
                {
                    if (row.tableName.Equals("Company Code"))
                    {
                        var rowData = context.RDM_COMPANY_CODE_MAPPING
                        .FirstOrDefault(c => c.COMPANY_CODE_ID == refData.id);

                        rowData.TRG_COMPANY_CODE = refData.targetSystemCode;
                        rowData.TRG_COMPANY_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;

                    } else if (row.tableName.Equals("Agent Code"))
                    {
                        var rowData = context.RDM_AGENT_CODE_MAPPING
                        .FirstOrDefault(c => c.AGENT_ID == refData.id);

                        rowData.TRG_AGENT_CODE = refData.targetSystemCode;
                        rowData.TRG_AGENT_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;
                    }
                    else if (row.tableName.Equals("ASL Code"))
                    {
                        var rowData = context.RDM_ASL_CODE_MAPPING
                        .FirstOrDefault(c => c.ASL_CODE_ID == refData.id);

                        rowData.TRG_ASL_CODE = refData.targetSystemCode;
                        rowData.TRG_ASL_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;
                    }
                    else if (row.tableName.Equals("Business Unit Code"))
                    {
                        var rowData = context.RDM_BUS_UNIT_CODE_MAPPING
                        .FirstOrDefault(c => c.BUS_UNIT_CODE_ID == refData.id);

                        rowData.TRG_BUS_UNIT_CODE = refData.targetSystemCode;
                        rowData.TRG_BUS_UNIT_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;
                    }
                    else if (row.tableName.Equals("Catastrophe Code"))
                    {
                        var rowData = context.RDM_CAT_CODE_MAPPING
                        .FirstOrDefault(c => c.CAT_CODE_ID == refData.id);

                        rowData.TRG_CAT_CODE = refData.targetSystemCode;
                        rowData.TRG_CAT_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;
                    }
                    else if (row.tableName.Equals("Class Code"))
                    {
                        var rowData = context.RDM_CLASS_CODE_MAPPING
                        .FirstOrDefault(c => c.CLASS_ID == refData.id);

                        rowData.TRG_CLASS_CODE = refData.targetSystemCode;
                        rowData.TRG_CLASS_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;
                    }
                    else if (row.tableName.Equals("County Unit Code"))
                    {
                        var rowData = context.RDM_COUNTY_UNIT_CODE_MAPPING
                        .FirstOrDefault(c => c.COUNTY_UNIT_CODE_ID == refData.id);

                        rowData.TRG_COUNTY_UNIT_CODE = refData.targetSystemCode;
                        rowData.TRG_COUNTY_UNIT_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;
                    }
                    else if (row.tableName.Equals("Coverage Code"))
                    {
                        var rowData = context.RDM_COVERAGE_CODE_MAPPING
                        .FirstOrDefault(c => c.COVERAGE_CODE_ID == refData.id);

                        rowData.TRG_COVERAGE_CODE = refData.targetSystemCode;
                        rowData.TRG_COVERAGE_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;
                    }
                    else if (row.tableName.Equals("Groupline Code"))
                    {
                        var rowData = context.RDM_GRPLINE_CODE_MAPPING
                        .FirstOrDefault(c => c.GRPLINE_CODE_ID == refData.id);

                        rowData.TRG_GRPLINE_CODE = refData.targetSystemCode;
                        rowData.TRG_GRPLINE_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;
                    }
                    else if (row.tableName.Equals("Management Code"))
                    {
                        var rowData = context.RDM_MGMT_SEG_CODE_MAPPING
                        .FirstOrDefault(c => c.MGMT_SEG_CODE_ID == refData.id);

                        rowData.TRG_MGMT_SEG_CODE = refData.targetSystemCode;
                        rowData.TRG_MGMT_SEG_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;
                    }
                    else if (row.tableName.Equals("Program Code"))
                    {
                        var rowData = context.RDM_PROGRAM_CODE_MAPPING
                        .FirstOrDefault(c => c.PROGRAM_CODE_ID == refData.id);

                        rowData.TRG_PROGRAM_CODE = refData.targetSystemCode;
                        rowData.TRG_PROGRAM_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;
                    }
                    else if (row.tableName.Equals("State Code"))
                    {
                        var rowData = context.RDM_STATE_CODE_MAPPING
                        .FirstOrDefault(c => c.STATE_CODE_ID == refData.id);

                        rowData.TRG_STATE_CODE = refData.targetSystemCode;
                        rowData.TRG_STATE_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;
                    }
                    else if (row.tableName.Equals("Subline Code"))
                    {
                        var rowData = context.RDM_SUB_LINE_CODE_MAPPING
                        .FirstOrDefault(c => c.SUB_LINE_CODE_ID == refData.id);

                        rowData.TRG_SUB_LINE_CODE = refData.targetSystemCode;
                        rowData.TRG_SUB_LINE_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;
                    }
                    else if (row.tableName.Equals("Territory Code"))
                    {
                        var rowData = context.RDM_TERR_UNDR_CODE_MAPPING
                        .FirstOrDefault(c => c.TERR_UNDR_CODE_ID == refData.id);

                        rowData.TRG_TERR_UNDR_CODE = refData.targetSystemCode;
                        rowData.TRG_TERR_UNDR_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;
                    }
                    else if (row.tableName.Equals("Underwriter Code"))
                    {
                        var rowData = context.RDM_UNDERWRITER_CODE_MAPPING
                        .FirstOrDefault(c => c.UNDERWRITER_CODE_ID == refData.id);

                        rowData.TRG_UNDERWRITER_CODE = refData.targetSystemCode;
                        rowData.TRG_UNDERWRITER_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;
                    }
                    else if (row.tableName.Equals("Userline Code"))
                    {
                        var rowData = context.RDM_UNDERWRITER_CODE_MAPPING
                        .FirstOrDefault(c => c.UNDERWRITER_CODE_ID == refData.id);

                        rowData.TRG_UNDERWRITER_CODE = refData.targetSystemCode;
                        rowData.TRG_UNDERWRITER_DESC = refData.targetSystemDesc;
                        rowData.UPDATED_BY = "Target Mapper";
                        rowData.UPDATED_DATE = DateTime.Now;
                    }


                    context.SaveChanges();

                }

                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
            
        
    }
}