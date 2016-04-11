using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace hm.BLL
{
    class sqlHelper
    {
        private static hm.DAL.SqlHelper dal = new hm.DAL.SqlHelper();
        public static int ExecSql(string sql)
        {
            return dal.ExecSql(sql);
        }

        public static object GetSingle(string sql)
        {
            return dal.GetSingle(sql);
        }

        public static DataTable execSql(string sql)
        {
            return dal.GetList(sql);
        }
    }
}
