using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:ed_node
	/// </summary>
	public partial class ed_node
	{
		public ed_node()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("ID", "ed_node"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ed_node");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
};
			parameters[0].Value = ID;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(hm.Model.ed_node model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ed_node(");
			strSql.Append("parentId,title,pic,url,types,orders,isShow,models)");
			strSql.Append(" values (");
            strSql.Append("@parentId,@title,@pic,@url,@types,@orders,@isShow,@models)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@parentId", OleDbType.Integer,4),
					new OleDbParameter("@title", OleDbType.VarChar,255),
					new OleDbParameter("@pic", OleDbType.VarChar,255),
					new OleDbParameter("@url", OleDbType.VarChar,255),
					new OleDbParameter("@types", OleDbType.Integer,4),
					new OleDbParameter("@orders", OleDbType.Integer,4),
					new OleDbParameter("@isShow", OleDbType.Integer,4),
                    new OleDbParameter("@models", OleDbType.Integer,4)};
			parameters[0].Value = model.parentId;
			parameters[1].Value = model.title;
			parameters[2].Value = model.pic;
			parameters[3].Value = model.url;
			parameters[4].Value = model.types;
			parameters[5].Value = model.orders;
			parameters[6].Value = model.isShow;
            parameters[7].Value = model.models;

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
		public bool Update(hm.Model.ed_node model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ed_node set ");
			strSql.Append("parentId=@parentId,");
			strSql.Append("title=@title,");
			strSql.Append("pic=@pic,");
			strSql.Append("url=@url,");
			strSql.Append("types=@types,");
			strSql.Append("orders=@orders,");
			strSql.Append("isShow=@isShow,");
            strSql.Append("models=@models");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@parentId", OleDbType.Integer,4),
					new OleDbParameter("@title", OleDbType.VarChar,255),
					new OleDbParameter("@pic", OleDbType.VarChar,255),
					new OleDbParameter("@url", OleDbType.VarChar,255),
					new OleDbParameter("@types", OleDbType.Integer,4),
					new OleDbParameter("@orders", OleDbType.Integer,4),
					new OleDbParameter("@isShow", OleDbType.Integer,4),
                    new OleDbParameter("@models", OleDbType.Integer,4),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
			parameters[0].Value = model.parentId;
			parameters[1].Value = model.title;
			parameters[2].Value = model.pic;
			parameters[3].Value = model.url;
			parameters[4].Value = model.types;
			parameters[5].Value = model.orders;
			parameters[6].Value = model.isShow;
            parameters[7].Value = model.models;
			parameters[8].Value = model.ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ed_node ");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ed_node ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public hm.Model.ed_node GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,parentId,title,pic,url,types,orders,isShow,models from ed_node ");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
};
			parameters[0].Value = ID;

			hm.Model.ed_node model=new hm.Model.ed_node();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["parentId"]!=null && ds.Tables[0].Rows[0]["parentId"].ToString()!="")
				{
					model.parentId=int.Parse(ds.Tables[0].Rows[0]["parentId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["title"]!=null && ds.Tables[0].Rows[0]["title"].ToString()!="")
				{
					model.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["pic"]!=null && ds.Tables[0].Rows[0]["pic"].ToString()!="")
				{
					model.pic=ds.Tables[0].Rows[0]["pic"].ToString();
				}
				if(ds.Tables[0].Rows[0]["url"]!=null && ds.Tables[0].Rows[0]["url"].ToString()!="")
				{
					model.url=ds.Tables[0].Rows[0]["url"].ToString();
				}
				if(ds.Tables[0].Rows[0]["types"]!=null && ds.Tables[0].Rows[0]["types"].ToString()!="")
				{
					model.types=int.Parse(ds.Tables[0].Rows[0]["types"].ToString());
				}
				if(ds.Tables[0].Rows[0]["orders"]!=null && ds.Tables[0].Rows[0]["orders"].ToString()!="")
				{
					model.orders=int.Parse(ds.Tables[0].Rows[0]["orders"].ToString());
				}
				if(ds.Tables[0].Rows[0]["isShow"]!=null && ds.Tables[0].Rows[0]["isShow"].ToString()!="")
				{
					model.isShow=int.Parse(ds.Tables[0].Rows[0]["isShow"].ToString());
				}
                if (ds.Tables[0].Rows[0]["models"] != null && ds.Tables[0].Rows[0]["models"].ToString() != "")
                {
                    model.models = int.Parse(ds.Tables[0].Rows[0]["models"].ToString());
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
            strSql.Append("select ID,parentId,title,pic,url,types,orders,isShow,models ");
			strSql.Append(" FROM ed_node ");
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
			parameters[0].Value = "ed_node";
			parameters[1].Value = "ID";
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

