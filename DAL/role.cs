using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:role
	/// </summary>
	public partial class role
	{
		public role()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("roleId", "role"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int roleId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from role");
			strSql.Append(" where roleId=@roleId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@roleId", OleDbType.Integer,4)
};
			parameters[0].Value = roleId;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(hm.Model.role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into role(");
			strSql.Append("roleName)");
			strSql.Append(" values (");
			strSql.Append("@roleName)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@roleName", OleDbType.VarChar,0)};
			parameters[0].Value = model.roleName;

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
		public bool Update(hm.Model.role model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update role set ");
			strSql.Append("roleName=@roleName");
			strSql.Append(" where roleId=@roleId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@roleName", OleDbType.VarChar,0),
					new OleDbParameter("@roleId", OleDbType.Integer,4)};
			parameters[0].Value = model.roleName;
			parameters[1].Value = model.roleId;

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
		public bool Delete(int roleId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from role ");
			strSql.Append(" where roleId=@roleId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@roleId", OleDbType.Integer,4)
};
			parameters[0].Value = roleId;

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
		public bool DeleteList(string roleIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from role ");
			strSql.Append(" where roleId in ("+roleIdlist + ")  ");
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
		public hm.Model.role GetModel(int roleId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select roleId,roleName from role ");
			strSql.Append(" where roleId=@roleId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@roleId", OleDbType.Integer,4)
};
			parameters[0].Value = roleId;

			hm.Model.role model=new hm.Model.role();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["roleId"]!=null && ds.Tables[0].Rows[0]["roleId"].ToString()!="")
				{
					model.roleId=int.Parse(ds.Tables[0].Rows[0]["roleId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["roleName"]!=null && ds.Tables[0].Rows[0]["roleName"].ToString()!="")
				{
					model.roleName=ds.Tables[0].Rows[0]["roleName"].ToString();
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
			strSql.Append("select roleId,roleName ");
			strSql.Append(" FROM role ");
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
			parameters[0].Value = "role";
			parameters[1].Value = "roleId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

