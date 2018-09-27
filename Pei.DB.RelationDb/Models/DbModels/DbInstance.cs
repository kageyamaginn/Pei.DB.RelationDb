using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pei.DB.RelationDb.Models.DbModels
{
    public class DbInstance : DbObject
    {
        public String ConnectionString { get; set; }
        public String ConnectionStringWithTNS { get; set; }
        
    }
}