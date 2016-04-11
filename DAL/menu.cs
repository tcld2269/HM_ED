using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:menu
	/// </summary>
	public partial class menu
	{
		public menu()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("menuId", "menu"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int menuId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from menu");
			strSql.Append(" where menuId=@menuId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@menuId", OleDbType.Integer,4)
};
			parameters[0].Value = menuId;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(hm.Model.menu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into menu(");
			strSql.Append("parentId,menuName,[level],orders,url)");
			strSql.Append(" values (");
			strSql.Append("@parentId,@menuName,@level,@orders,@url)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@parentId", OleDbType.Integer,4),
					new OleDbParameter("@menuName", OleDbType.VarChar,0),
					new OleDbParameter("@level", OleDbType.Integer,4),
					new OleDbParameter("@orders", OleDbType.Integer,4),
					new OleDbParameter("@url", OleDbType.VarChar,0)};
			parameters[0].Value = model.parentId;
			parameters[1].Value = model.menuName;
			parameters[2].Value = model.level;
			parameters[3].Value = model.orders;
			parameters[4].Value = model.url;

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
		public bool Update(hm.Model.menu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [menu] set ");
			strSql.Append("parentId=@parentId,");
			strSql.Append("menuName=@menuName,");
			strSql.Append("[level]=@level,");
			strSql.Append("orders=@orders,");
			strSql.Append("url=@url");
			strSql.Append(" where menuId=@menuId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@parentId", OleDbType.Integer,4),
					new OleDbParameter("@menuName", OleDbType.VarChar,0),
					new OleDbParameter("@level", OleDbType.Integer,4),
					new OleDbParameter("@orders", OleDbType.Integer,4),
					new OleDbParameter("@url", OleDbType.VarChar,0),
					new OleDbParameter("@menuId", OleDbType.Integer,4)};
			parameters[0].Value = model.parentId;
			parameters[1].Value = model.menuName;
			parameters[2].Value = model.level;
			parameters[3].Value = model.orders;
			parameters[4].Value = model.url;
			parameters[5].Value = model.menuId;

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
		public bool Delete(int menuId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from menu ");
			strSql.Append(" where menuId=@menuId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@menuId", OleDbType.Integer,4)
};
			parameters[0].Value = menuId;

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
		public bool DeleteList(string menuIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from menu ");
			strSql.Append(" where menuId in ("+menuIdlist + ")  ");
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
		public hm.Model.menu GetModel(int menuId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select menuId,parentId,menuName,[level],orders,url from menu ");
			strSql.Append(" where menuId=@menuId");
			OleDbParameter[] parameters = {
					new OleDbParameter("@menuId", OleDbType.Integer,4)
};
			parameters[0].Value = menuId;

			hm.Model.menu model=new hm.Model.menu();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["menuId"]!=null && ds.Tables[0].Rows[0]["menuId"].ToString()!="")
				{
					model.menuId=int.Parse(ds.Tables[0].Rows[0]["menuId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["parentId"]!=null && ds.Tables[0].Rows[0]["parentId"].ToString()!="")
				{
					model.parentId=int.Parse(ds.Tables[0].Rows[0]["parentId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["menuName"]!=null && ds.Tables[0].Rows[0]["menuName"].ToString()!="")
				{
					model.menuName=ds.Tables[0].Rows[0]["menuName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["level"]!=null && ds.Tables[0].Rows[0]["level"].ToString()!="")
				{
					model.level=int.Parse(ds.Tables[0].Rows[0]["level"].ToString());
				}
				if(ds.Tables[0].Rows[0]["orders"]!=null && ds.Tables[0].Rows[0]["orders"].ToString()!="")
				{
					model.orders=int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
				}
				if(ds.Tables[0].Rows[0]["url"]!=null && ds.Tables[0].Rows[0]["url"].ToString()!="")
				{
					model.url=ds.Tables[0].Rows[0]["url"].ToString();
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
			strSql.Append("select menuId,parentId,menuName,[level],orders,url ");
			strSql.Append(" FROM menu ");
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
			parameters[0].Value = "menu";
			parameters[1].Value = "menuId";
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

