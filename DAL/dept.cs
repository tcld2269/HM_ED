using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:dept
	/// </summary>
	public partial class dept
	{
		public dept()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("deptId", "dept"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int deptId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from dept");
			strSql.Append(" where deptId=@deptId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@deptId", OleDbType.Integer,4)
};
			parameters[0].Value = deptId;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(hm.Model.dept model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into dept(");
			strSql.Append("parentId,deptName)");
			strSql.Append(" values (");
			strSql.Append("@parentId,@deptName)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@parentId", OleDbType.Integer,4),
					new OleDbParameter("@deptName", OleDbType.VarChar,0)
                                          };
			parameters[0].Value = model.parentId;
			parameters[1].Value = model.deptName;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(hm.Model.dept model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update dept set ");
			strSql.Append("parentId=@parentId,");
			strSql.Append("deptName=@deptName");
			strSql.Append(" where deptId=@deptId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@parentId", OleDbType.Integer,4),
					new OleDbParameter("@deptName", OleDbType.VarChar,0),
					new OleDbParameter("@deptId", OleDbType.Integer,4)};
			parameters[0].Value = model.parentId;
			parameters[1].Value = model.deptName;
			parameters[2].Value = model.deptId;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int deptId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dept ");
			strSql.Append(" where deptId=@deptId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@deptId", OleDbType.Integer,4)
};
			parameters[0].Value = deptId;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string deptIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dept ");
			strSql.Append(" where deptId in ("+deptIdlist + ")  ");
			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public hm.Model.dept GetModel(int deptId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select deptId,parentId,deptName from dept ");
			strSql.Append(" where deptId=@deptId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@deptId", OleDbType.Integer,4)
};
			parameters[0].Value = deptId;

			hm.Model.dept model=new hm.Model.dept();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["deptId"]!=null && ds.Tables[0].Rows[0]["deptId"].ToString()!="")
				{
					model.deptId=int.Parse(ds.Tables[0].Rows[0]["deptId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["parentId"]!=null && ds.Tables[0].Rows[0]["parentId"].ToString()!="")
				{
					model.parentId=int.Parse(ds.Tables[0].Rows[0]["parentId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["deptName"]!=null && ds.Tables[0].Rows[0]["deptName"].ToString()!="")
				{
					model.deptName=ds.Tables[0].Rows[0]["deptName"].ToString();
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select deptId,parentId,deptName ");
			strSql.Append(" FROM dept ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OleDbParameter[] parameters = {
					new OleDbParameter("@tblName", OleDbType.VarChar, 255),
					new OleDbParameter("@fldName", OleDbType.VarChar, 255),
					new OleDbParameter("@PageSize", OleDbType.Integer),
					new OleDbParameter("@PageIndex", OleDbType.Integer),
					new OleDbParameter("@IsReCount", OleDbType.Boolean),
					new OleDbParameter("@OrderType", OleDbType.Boolean),
					new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
					};
			parameters[0].Value = "dept";
			parameters[1].Value = "deptId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
        public DataTable GetAllChild(int placeId)
        {
            string sql = "select a.* from [dept] a , f_cplaceId(" + placeId + ") b where a.deptId = b.deptId order by a.deptId";
            return DbHelperSQL.Query(sql).Tables[0];
        }
	}
}

