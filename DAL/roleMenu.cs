using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:roleMenu
	/// </summary>
	public partial class roleMenu
	{
		public roleMenu()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("rmId", "roleMenu"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int rmId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from roleMenu");
			strSql.Append(" where rmId=@rmId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@rmId", OleDbType.Integer,4)
};
			parameters[0].Value = rmId;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(hm.Model.roleMenu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into roleMenu(");
			strSql.Append("roleId,menuId)");
			strSql.Append(" values (");
			strSql.Append("@roleId,@menuId)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@roleId", OleDbType.Integer,4),
					new OleDbParameter("@menuId", OleDbType.Integer,4)};
			parameters[0].Value = model.roleId;
			parameters[1].Value = model.menuId;

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
		public bool Update(hm.Model.roleMenu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update roleMenu set ");
			strSql.Append("roleId=@roleId,");
			strSql.Append("menuId=@menuId");
			strSql.Append(" where rmId=@rmId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@roleId", OleDbType.Integer,4),
					new OleDbParameter("@menuId", OleDbType.Integer,4),
					new OleDbParameter("@rmId", OleDbType.Integer,4)};
			parameters[0].Value = model.roleId;
			parameters[1].Value = model.menuId;
			parameters[2].Value = model.rmId;

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
		public bool Delete(int rmId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from roleMenu ");
			strSql.Append(" where rmId=@rmId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@rmId", OleDbType.Integer,4)
};
			parameters[0].Value = rmId;

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
		public bool DeleteList(string rmIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from roleMenu ");
			strSql.Append(" where rmId in ("+rmIdlist + ")  ");
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
		public hm.Model.roleMenu GetModel(int rmId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select rmId,roleId,menuId from roleMenu ");
			strSql.Append(" where rmId=@rmId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@rmId", OleDbType.Integer,4)
};
			parameters[0].Value = rmId;

			hm.Model.roleMenu model=new hm.Model.roleMenu();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["rmId"]!=null && ds.Tables[0].Rows[0]["rmId"].ToString()!="")
				{
					model.rmId=int.Parse(ds.Tables[0].Rows[0]["rmId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["roleId"]!=null && ds.Tables[0].Rows[0]["roleId"].ToString()!="")
				{
					model.roleId=int.Parse(ds.Tables[0].Rows[0]["roleId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["menuId"]!=null && ds.Tables[0].Rows[0]["menuId"].ToString()!="")
				{
					model.menuId=int.Parse(ds.Tables[0].Rows[0]["menuId"].ToString());
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
			strSql.Append("select rmId,roleId,menuId ");
			strSql.Append(" FROM roleMenu ");
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
			parameters[0].Value = "roleMenu";
			parameters[1].Value = "rmId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
        public bool DeleteByRoleId(int roleId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from roleMenu ");
            strSql.Append(" where roleId=@roleId");
            OleDbParameter[] parameters = {
					new OleDbParameter("@roleId", OleDbType.Integer,4)
            };
            parameters[0].Value = roleId;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
	}
}

