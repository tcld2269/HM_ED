using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Maticsoft.DBUtility;
using System.Data;

namespace hm.DAL
{
    public partial class SqlHelper
    {
        public int ExecSql(string sql)
        {
            return DbHelperOleDb.ExecuteSql(sql);
        }

        public object GetSingle(string sql)
        {
            return DbHelperOleDb.GetSingle(sql);
        }

        public DataTable GetList(string sql)
        {
            return DbHelperOleDb.Query(sql).Tables[0];
        }
    }
}
