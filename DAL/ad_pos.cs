using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace hm.DAL
{
	/// <summary>
	/// 数据访问类:ad_pos
	/// </summary>
	public partial class ad_pos
	{
		public ad_pos()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("id", "ad_pos"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ad_pos");
			strSql.Append(" where id=@id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@id", OleDbType.Integer,4)
};
			parameters[0].Value = id;

			return DbHelperOleDb.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(hm.Model.ad_pos model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ad_pos(");
			strSql.Append("title,types,width,height,click)");
			strSql.Append(" values (");
			strSql.Append("@title,@types,@width,@height,@click)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@title", OleDbType.VarChar,255),
					new OleDbParameter("@types", OleDbType.Integer,4),
					new OleDbParameter("@width", OleDbType.Integer,4),
					new OleDbParameter("@height", OleDbType.Integer,4),
					new OleDbParameter("@click", OleDbType.Integer,4)};
			parameters[0].Value = model.title;
			parameters[1].Value = model.types;
			parameters[2].Value = model.width;
			parameters[3].Value = model.height;
			parameters[4].Value = model.click;

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
		public bool Update(hm.Model.ad_pos model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ad_pos set ");
			strSql.Append("title=@title,");
			strSql.Append("types=@types,");
			strSql.Append("width=@width,");
			strSql.Append("height=@height,");
			strSql.Append("click=@click");
			strSql.Append(" where id=@id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@title", OleDbType.VarChar,255),
					new OleDbParameter("@types", OleDbType.Integer,4),
					new OleDbParameter("@width", OleDbType.Integer,4),
					new OleDbParameter("@height", OleDbType.Integer,4),
					new OleDbParameter("@click", OleDbType.Integer,4),
					new OleDbParameter("@id", OleDbType.Integer,4)};
			parameters[0].Value = model.title;
			parameters[1].Value = model.types;
			parameters[2].Value = model.width;
			parameters[3].Value = model.height;
			parameters[4].Value = model.click;
			parameters[5].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ad_pos ");
			strSql.Append(" where id=@id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@id", OleDbType.Integer,4)
};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ad_pos ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public hm.Model.ad_pos GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,title,types,width,height,click from ad_pos ");
			strSql.Append(" where id=@id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@id", OleDbType.Integer,4)
};
			parameters[0].Value = id;

			hm.Model.ad_pos model=new hm.Model.ad_pos();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["title"]!=null && ds.Tables[0].Rows[0]["title"].ToString()!="")
				{
					model.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["types"]!=null && ds.Tables[0].Rows[0]["types"].ToString()!="")
				{
					model.types=int.Parse(ds.Tables[0].Rows[0]["types"].ToString());
				}
				if(ds.Tables[0].Rows[0]["width"]!=null && ds.Tables[0].Rows[0]["width"].ToString()!="")
				{
					model.width=int.Parse(ds.Tables[0].Rows[0]["width"].ToString());
				}
				if(ds.Tables[0].Rows[0]["height"]!=null && ds.Tables[0].Rows[0]["height"].ToString()!="")
				{
					model.height=int.Parse(ds.Tables[0].Rows[0]["height"].ToString());
				}
				if(ds.Tables[0].Rows[0]["click"]!=null && ds.Tables[0].Rows[0]["click"].ToString()!="")
				{
					model.click=int.Parse(ds.Tables[0].Rows[0]["click"].ToString());
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
			strSql.Append("select id,title,types,width,height,click ");
			strSql.Append(" FROM ad_pos ");
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
			parameters[0].Value = "ad_pos";
			parameters[1].Value = "id";
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

