using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;

namespace Pei.DB.RelationDb.Models.DbModels
{
    public class DbTable:DbObject
    {
        public List<DbColumn> Columns { get; set; }
        public List<DbConstraint> Cons { get; set; }
        public List<DbIndex> Indexes { get; set; }
    }

    public class DbColumn : DbObject
    {
        public OracleDbType OraDataType { get; set; }
        public Type ValueType { get; set; }
        public int DataLength { get; set; }
        public int ColumnId { get; set; }
        public bool Nullable { get; set; }
    }

    public class DbConstraint : DbObject
    {
        public String ConstraintType { get; set; }
    }
    public class PirmaryKeyDbConstraint : DbConstraint
    {
        public List<DbColumn> PKColumns { get; set; }
    }

    public class ForeignKeyDbConstraint : DbConstraint
    {
        public Tuple<DbColumn, DbColumn> Mapping { get; set; }
    }
    public class DbIndex : DbObject
    {
        public String IndexType { get; set; }
    }

    
}