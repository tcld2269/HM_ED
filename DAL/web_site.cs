using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:web_site
	/// </summary>
	public partial class web_site
	{
		public web_site()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("ID", "web_site"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from web_site");
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
		public bool Add(hm.Model.web_site model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into web_site(");
			strSql.Append("webName,title,keywords,description,logo,bottom,qq)");
			strSql.Append(" values (");
			strSql.Append("@webName,@title,@keywords,@description,@logo,@bottom,@qq)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@webName", OleDbType.VarChar,255),
					new OleDbParameter("@title", OleDbType.VarChar,255),
					new OleDbParameter("@keywords", OleDbType.VarChar,255),
					new OleDbParameter("@description", OleDbType.VarChar,255),
					new OleDbParameter("@logo", OleDbType.VarChar,255),
					new OleDbParameter("@bottom", OleDbType.VarChar,0),
					new OleDbParameter("@qq", OleDbType.VarChar,255)};
			parameters[0].Value = model.webName;
			parameters[1].Value = model.title;
			parameters[2].Value = model.keywords;
			parameters[3].Value = model.description;
			parameters[4].Value = model.logo;
			parameters[5].Value = model.bottom;
			parameters[6].Value = model.qq;

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
		public bool Update(hm.Model.web_site model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update web_site set ");
			strSql.Append("webName=@webName,");
			strSql.Append("title=@title,");
			strSql.Append("keywords=@keywords,");
			strSql.Append("description=@description,");
			strSql.Append("logo=@logo,");
			strSql.Append("bottom=@bottom,");
			strSql.Append("qq=@qq");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@webName", OleDbType.VarChar,255),
					new OleDbParameter("@title", OleDbType.VarChar,255),
					new OleDbParameter("@keywords", OleDbType.VarChar,255),
					new OleDbParameter("@description", OleDbType.VarChar,255),
					new OleDbParameter("@logo", OleDbType.VarChar,255),
					new OleDbParameter("@bottom", OleDbType.VarChar,0),
					new OleDbParameter("@qq", OleDbType.VarChar,255),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
			parameters[0].Value = model.webName;
			parameters[1].Value = model.title;
			parameters[2].Value = model.keywords;
			parameters[3].Value = model.description;
			parameters[4].Value = model.logo;
			parameters[5].Value = model.bottom;
			parameters[6].Value = model.qq;
			parameters[7].Value = model.ID;

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
			strSql.Append("delete from web_site ");
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
			strSql.Append("delete from web_site ");
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
		public hm.Model.web_site GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,webName,title,keywords,description,logo,bottom,qq from web_site ");
			strSql.Append(" where ID=@ID");
			OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
};
			parameters[0].Value = ID;

			hm.Model.web_site model=new hm.Model.web_site();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["webName"]!=null && ds.Tables[0].Rows[0]["webName"].ToString()!="")
				{
					model.webName=ds.Tables[0].Rows[0]["webName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["title"]!=null && ds.Tables[0].Rows[0]["title"].ToString()!="")
				{
					model.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["keywords"]!=null && ds.Tables[0].Rows[0]["keywords"].ToString()!="")
				{
					model.keywords=ds.Tables[0].Rows[0]["keywords"].ToString();
				}
				if(ds.Tables[0].Rows[0]["description"]!=null && ds.Tables[0].Rows[0]["description"].ToString()!="")
				{
					model.description=ds.Tables[0].Rows[0]["description"].ToString();
				}
				if(ds.Tables[0].Rows[0]["logo"]!=null && ds.Tables[0].Rows[0]["logo"].ToString()!="")
				{
					model.logo=ds.Tables[0].Rows[0]["logo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["bottom"]!=null && ds.Tables[0].Rows[0]["bottom"].ToString()!="")
				{
					model.bottom=ds.Tables[0].Rows[0]["bottom"].ToString();
				}
				if(ds.Tables[0].Rows[0]["qq"]!=null && ds.Tables[0].Rows[0]["qq"].ToString()!="")
				{
					model.qq=ds.Tables[0].Rows[0]["qq"].ToString();
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
			strSql.Append("select ID,webName,title,keywords,description,logo,bottom,qq ");
			strSql.Append(" FROM web_site ");
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
			parameters[0].Value = "web_site";
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

