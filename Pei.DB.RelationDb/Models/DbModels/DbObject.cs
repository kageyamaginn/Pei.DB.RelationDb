using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pei.DB.RelationDb.Models.DbModels
{
    public class DbObject
    {
        public DbObject()
        {
            ExInfo = new List<ExternalInfo>();
        }
        public DbObject Parent { get; set; }
        public String Name { get; set; }
        public String Status { get; set; }

        public List<ExternalInfo> ExInfo { get; set; }
    }

    public class ExternalInfo
    {

    }
}